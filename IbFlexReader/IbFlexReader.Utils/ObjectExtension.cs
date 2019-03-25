namespace IbFlexReader.Utils
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public static class ObjectExtension
    {
        public static bool Matches<T>(this T t, Func<T, bool> fn)
        {
            return fn(t);
        }

        public static T Clone<T>(this T from) where T : new()
        {
            var type = typeof(T);
            var newT = new T();

            foreach (var prop in type.GetProperties().Where(x => x.SetMethod != null))
            {
                prop.SetValue(newT, prop.GetValue(from));
            }

            return newT;
        }
    }
}
