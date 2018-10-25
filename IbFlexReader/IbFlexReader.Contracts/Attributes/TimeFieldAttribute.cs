using System;
using System.Collections.Generic;
using System.Text;

namespace IbFlexReader.Contracts.Attributes
{
    public class TimeFieldAttribute : Attribute
    {
        public string Field;

        public TimeFieldAttribute(string value)
        {
            Field = value;
        }
    }
}
