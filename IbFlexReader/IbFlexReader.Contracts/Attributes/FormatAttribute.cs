namespace IbFlexReader.Contracts.Attributes
{
    using System;

    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    public class FormatAttribute : Attribute
    {
        public readonly string Value;
        public readonly int Order;

        public FormatAttribute(string value, int order = 0)
        {
            Value = value;
            Order = order;
        }
    }
}
