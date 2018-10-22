using System;
using System.Collections.Generic;
using System.Text;

namespace IbFlexReader.Contracts.Attributes
{
    public class EnumNameAttribute : Attribute
    {
        public string Value { get; }

        public EnumNameAttribute(string value = null)
        {
            Value = value;
        }
    }
}
