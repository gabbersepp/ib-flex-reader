using IbFlexReader.Contracts;
using IbFlexReader.Contracts.Attributes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;

namespace IbFlexReader.Utils
{
    public static class Extensions
    {
        public static TIn PopulateFrom<TIn, TFrom>(this TIn obj, TFrom from)
        {
            if (from == null)
            {
                return obj;
            }

            var typeFrom = from.GetType();
            var typeTo = obj.GetType();
            var typeToProperties = typeTo.GetProperties();

            foreach (var p in typeFrom.GetProperties())
            {
                try
                {
                    // just for debugging purposes
                    var pName = p.Name;
                    var possible = typeToProperties.FirstOrDefault(x => x.Name == p.Name);

                    if (possible != null)
                    {
                        var possibleType = possible.PropertyType;

                        if (possibleType != typeof(string) && typeof(IEnumerable).IsAssignableFrom(possibleType))
                        {
                            var listType = typeof(List<>).MakeGenericType(possibleType.GenericTypeArguments[0]);
                            var list = (IList)Activator.CreateInstance(listType);
                            possible.SetValue(obj, list);

                            foreach (var o in (IEnumerable)p.GetValue(from))
                            {
                                var entryType = typeof(FlexQueryResponse).Assembly.GetType("IbFlexReader.Contracts." + o.GetType().Name);
                                list.Add(Activator.CreateInstance(entryType).PopulateFrom(o));
                            }
                        }
                        else if (possibleType.FullName.Contains("IbFlexReader") && !possibleType.IsEnum && (!Nullable.GetUnderlyingType(possibleType)?.IsEnum ?? true))
                        {
                            var instance = Activator.CreateInstance(possibleType);

                            possible.SetValue(obj, instance.PopulateFrom(p.GetValue(from)));
                        }
                        else
                        {
                            possible.SetValue(obj, CastValue(p.GetValue(from), possible));
                        }

                    }
                } 
                catch (Exception e)
                {
                    throw new Exception($"error during casting field '{p.Name}' of '{typeFrom.Name}'", e);
                }
            }

            return obj;
        }

        private static object CastValue(object value, PropertyInfo property)
        {
            if (value == null)
            {
                return value;
            }

            var strVal = value.ToString();

            if (strVal == string.Empty && property.PropertyType != typeof(string))
            {
                return null;
            }

            var type = property.PropertyType;

            if (type.IsEnum)
            {
                return Enum.Parse(type, strVal);
            }

            if (Nullable.GetUnderlyingType(type)?.IsEnum ?? false)
            {
                return Enum.Parse(Nullable.GetUnderlyingType(type), strVal);
            }

            if (type == typeof(DateTime))
            {
                // expet format
                var attribute = property.GetCustomAttribute<FormatAttribute>();

                if (attribute == null)
                {
                    throw new Exception("format not specified");
                }

                return DateTime.ParseExact(strVal, attribute.Value, CultureInfo.InvariantCulture);
            }

            if (type == typeof(int))
            {
                return int.Parse(strVal);
            }

            if (type == typeof(int?))
            {
                return (int?)int.Parse(strVal);
            }

            if (type == typeof(long))
            {
                return long.Parse(strVal);
            }

            if (type == typeof(long?))
            {
                return (long?)long.Parse(strVal);
            }

            if (type == typeof(double))
            {
                return double.Parse(strVal, CultureInfo.InvariantCulture);
            }

            if (type == typeof(IEnumerable<>))
            {

            }

            return value.ToString();
        }
    }
}
