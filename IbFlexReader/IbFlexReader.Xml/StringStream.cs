namespace IbFlexReader.Xml
{
    using System.IO;

    public class StringStream : IStreamBuilder<string>
    {
        public Stream GenerateStream(string content)
        {
            var stream = new MemoryStream();
            var writer = new StreamWriter(stream);

            writer.Write(content);

            writer.Flush();

            stream.Position = 0;

            return stream;
        }
    }
}