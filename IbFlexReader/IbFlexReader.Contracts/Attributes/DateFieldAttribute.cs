using System;
using System.Collections.Generic;
using System.Text;

namespace IbFlexReader.Contracts.Attributes
{
    public class DateFieldAttribute : Attribute
    {
        public string Field;

        public DateFieldAttribute(string value)
        {
            Field = value;
        }
    }
}
