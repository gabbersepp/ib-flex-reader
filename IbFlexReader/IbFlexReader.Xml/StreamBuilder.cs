using System;
using System.IO;

namespace IbFlexReader.Xml
{

    public interface IStreamBuilder
    {
        Stream GenerateStreamFromString(string Content);
    }

    public class StreamBuilder : IStreamBuilder
    {
        public Stream GenerateStreamFromString(string Content)
        {
            var stream = new MemoryStream();
            var writer = new StreamWriter(stream);

            writer.Write(Content);

            writer.Flush();

            stream.Position = 0;

            return stream;
        }
    }

}