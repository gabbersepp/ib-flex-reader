namespace IbFlexReader.Contracts.Attributes
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class TimeFieldAttribute : Attribute
    {
        public string Field;

        public TimeFieldAttribute(string value)
        {
            Field = value;
        }
    }
}
