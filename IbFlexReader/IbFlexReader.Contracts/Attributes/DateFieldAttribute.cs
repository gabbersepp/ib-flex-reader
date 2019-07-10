namespace IbFlexReader.Contracts.Attributes
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class DateFieldAttribute : Attribute
    {
        public string Field;

        public DateFieldAttribute(string value)
        {
            Field = value;
        }
    }
}
