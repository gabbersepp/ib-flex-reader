using System.IO;

namespace IbFlexReader.Xml
{
    public interface IStreamBuilder <T>
    {
        Stream GenerateStream(T Content);
    }
}