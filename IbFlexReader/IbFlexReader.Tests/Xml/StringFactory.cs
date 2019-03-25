namespace IbFlexReader.Tests
{
    public static class StringFactory
    {
        public static string XmlStart = @"<FlexQueryResponse queryName=""Las30Days"" type=""AF"">
<FlexStatements count=""1"">
<FlexStatement accountId=""xxxxxx"" fromDate=""20180917"" toDate=""20181016"" period=""Last30CalendarDays"" whenGenerated=""20181017;143211"">
";
        public static string XmlEnd = @"</FlexStatement>
</FlexStatements>
</FlexQueryResponse>";
    }
}
