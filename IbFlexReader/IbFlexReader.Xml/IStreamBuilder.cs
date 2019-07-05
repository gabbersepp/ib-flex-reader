namespace IbFlexReader.Xml
{
    using System.IO;

    public interface IStreamBuilder<T>
    {
        Stream GenerateStream(T content);
    }
}