namespace IbFlexReader.Utils
{
    using System;
    using System.IO;

    public static class DumpFileWriter
    {
        public static void DumpSendRequest(Stream stream, string filename)
        {
            filename = ToDumpFilename(filename, "1");
            DumpStream(stream, filename);
        }

        public static void DumpGetStatement(Stream stream, string filename)
        {
            filename = ToDumpFilename(filename, "2");
            DumpStream(stream, filename);
        }

        /// <summary>
        /// Insert the token between filename and extension.
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="token"></param>
        /// <returns></returns>
        public static string ToDumpFilename(string filename, string token)
        {
            string path = Path.GetDirectoryName(filename);

            string extension = Path.GetExtension(filename);
            string file = Path.GetFileNameWithoutExtension(filename);

            filename = Path.Combine(path, string.Concat(file, ".", token, extension));

            return filename;
        }

        public static void DumpStream(Stream stream, string filename)
        {
            using (StreamReader w = new StreamReader(stream, System.Text.Encoding.Default, false, 1024, true))
            {
                File.WriteAllText(filename, w.ReadToEnd());
                stream.Seek(0, SeekOrigin.Begin);
            }
        }
    }
}
