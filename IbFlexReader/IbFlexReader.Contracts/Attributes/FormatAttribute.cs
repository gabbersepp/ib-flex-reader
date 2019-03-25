namespace IbFlexReader.Contracts.Attributes
{
    using System;

    public class FormatAttribute : Attribute
    {
        public readonly string Value;

        public FormatAttribute(string value)
        {
            Value = value;
        }
    }
}
