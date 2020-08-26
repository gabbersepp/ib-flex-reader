namespace IbFlexReader.Xml
{
    using System.Collections.Generic;
    using System.IO;
    using System.Xml;
    using System.Xml.Serialization;
    using IbFlexReader.Contracts;
    using IbFlexReader.Utils;
    using IbFlexReader.Xml.Contracts;

    public static class Deserializer
    {
        public static TOut Deserialize<TXml, TOut>(Stream content, out List<ErrorMessage> errorObjects)
            where TXml : XmlBase where TOut : class, new()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(TXml));
            using (XmlReader reader = XmlReader.Create(content))
            {
                var obj = (TXml)serializer.Deserialize(reader);
                errorObjects = new List<ErrorMessage>();
                return new TOut().PopulateFrom(obj, errorObjects);
            }
        }

        public static TOut Deserialize<TXml, TOut>(XmlReader content, out List<ErrorMessage> errorObjects)
            where TXml : XmlBase where TOut : class, new()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(TXml));
            var obj = (TXml)serializer.Deserialize(content);
            errorObjects = new List<ErrorMessage>();
            return new TOut().PopulateFrom(obj, errorObjects);
        }
    }
}
