using System;

namespace IbFlexReader.Contracts.Attributes
{
    public class FormatAttribute : Attribute
    {
        public readonly string Value;

        public FormatAttribute(string value)
        {
            Value = value;
        }
    }
}
