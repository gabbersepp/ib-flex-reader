using IbFlexReader.Contracts.Attributes;
using System;
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
                var possible = typeToProperties.FirstOrDefault(x => x.Name == p.Name);

                if (possible != null)
                {
                    var possibleType = possible.PropertyType;

                    if (possibleType.FullName.Contains("IbFlexReader"))
                    {
                        var instance = Activator.CreateInstance(possibleType);

                        possible.SetValue(obj, instance.PopulateFrom(p.GetValue(from)));
                    } else
                    {
                        possible.SetValue(obj, CastValue(p.GetValue(from), possible));
                    }
                    
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

            var type = property.PropertyType;

            if (type.IsEnum)
            {
                return Enum.Parse(type, value.ToString());
            }

            if (type == typeof(DateTime))
            {
                // expet format
                var attribute = property.GetCustomAttribute<FormatAttribute>();

                if (attribute == null)
                {
                    throw new Exception("format not specified");
                }

                return DateTime.ParseExact(value.ToString(), attribute.Value, CultureInfo.InvariantCulture);
            }

            return value.ToString();
        }
    }
}
