namespace IbFlexReader.Xml
{
    using System.IO;

    public class StringStream : IStreamBuilder<string>
    {
        public Stream GenerateStream(string Content)
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