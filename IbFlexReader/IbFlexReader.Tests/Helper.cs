using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace IbFlexReader.Test
{
    public static class Helper
    {
        public static Stream GenerateStreamFromString(string s)
        {
            var stream = new MemoryStream();
            var writer = new StreamWriter(stream);
            writer.Write(s);
            writer.Flush();
            stream.Position = 0;
            return stream;
        }


        public static string XmlStart = @"<FlexQueryResponse queryName=""Las30Days"" type=""AF"">
<FlexStatements count=""1"">
<FlexStatement accountId=""xxxxxx"" fromDate=""20180917"" toDate=""20181016"" period=""Last30CalendarDays"" whenGenerated=""20181017;143211"">
";
        public static string XmlEnd = @"</FlexStatement>
</FlexStatements>
</FlexQueryResponse>";
    }
}
