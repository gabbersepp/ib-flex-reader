namespace IbFlexReader.Xml
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Xml;
    using System.Xml.Serialization;
    using IbFlexReader.Contracts;
    using IbFlexReader.Utils;
    using IbFlexReader.Xml.Contracts;

    public static class Deserializer
    {
        public static TOut Deserialize<TXml, TOut>(Stream content, out List<ErrorMessage> errorObjects, out string mappingError)
            where TXml : XmlBase where TOut : class, new()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(TXml));
            serializer.AddDebugHooks();

            using (XmlReader reader = XmlReader.Create(content))
            {
                try
                {
                    var obj = (TXml)serializer.Deserialize(reader);
                    errorObjects = new List<ErrorMessage>();
                    //mappingError = uknowns.ToString();
                    mappingError = string.Join(Environment.NewLine, uknownTags.Select(d => $"{d}"));
                    return new TOut().PopulateFrom(obj, errorObjects);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
                finally
                {
                    Console.Write(uknowns.ToString());
                }
            }
        }

        public static TOut Deserialize<TXml, TOut>(XmlReader content, out List<ErrorMessage> errorObjects, out string mappingError)
            where TXml : XmlBase where TOut : class, new()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(TXml));
            serializer.AddDebugHooks();

            try
            {
                var obj = (TXml)serializer.Deserialize(content);
                errorObjects = new List<ErrorMessage>();
                //mappingError = uknowns.ToString();
                mappingError = string.Join(Environment.NewLine, uknownTags.Select(d => $"{d}"));
                return new TOut().PopulateFrom(obj, errorObjects);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                Console.Write(uknowns.ToString());
            }
        }

        private static void AddDebugHooks(this XmlSerializer serializer)
        {
            uknowns = new StringBuilder();
            uknownTags = new HashSet<string>();

            serializer.UnknownAttribute += (sender, args) =>
            {
                System.Xml.XmlAttribute attr = args.Attr;
                string msg = $"{args.LineNumber}:{args.LinePosition},{args.ObjectBeingDeserialized.GetType()},Unknown attribute,{attr.Name},{attr.Value}";
                uknowns.AppendLine(msg);
                uknownTags.Add($"{args.ObjectBeingDeserialized.GetType()},{attr.Name}");
            };
            serializer.UnknownNode += (sender, args) =>
            {
                string msg = $"{args.LineNumber}:{args.LinePosition},{args.ObjectBeingDeserialized.GetType()},Unknown Node,{args.Name},{args.Text}";
                uknowns.AppendLine(msg);
                uknownTags.Add($"{args.ObjectBeingDeserialized.GetType()},{args.Name}");
            };

            serializer.UnknownElement     += (sender, args) =>
            {
                string msg = $"{args.LineNumber}:{args.LinePosition},{args.ObjectBeingDeserialized.GetType()},Unknown Element,{args.Element.Name},{args.Element.InnerXml}";
                uknowns.AppendLine(msg);
                uknownTags.Add($"{args.ObjectBeingDeserialized.GetType()},{args.Element.Name}");
            };

            serializer.UnreferencedObject += (sender, args) =>
            {
                string msg = $"0:0,{args.UnreferencedObject.GetType()},Unreferenced Object,{args.UnreferencedId},{args.UnreferencedObject}";
                uknowns.AppendLine(msg);
            };
        }

        private static StringBuilder uknowns = new StringBuilder();
        private static HashSet<string> uknownTags = new HashSet<string>();
    }
}
