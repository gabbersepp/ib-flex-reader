using IbFlexReader.Utils;
using IbFlexReader.Xml.Contracts;
using System;
using System.IO;
using System.Xml.Serialization;

namespace IbFlexReader.Xml
{
    public class Deserializer
    {
        public TOut Deserialize<TXml, TOut>(Stream content)
            where TXml : XmlBase where TOut : new()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(TXml));
            var obj = (TXml)serializer.Deserialize(content);
            return new TOut().PopulateFrom(obj);
        }
    }
}
