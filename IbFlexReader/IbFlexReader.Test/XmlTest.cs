using FluentAssertions;
using IbFlexReader.Contracts;
using IbFlexReader.Xml;
using IbFlexReader.Xml.Contracts;
using NUnit.Framework;
using System;
using System.IO;

namespace IbFlexReader.Test
{
    public class XmlTest
    {
        [Test]
        public void TestFlexStatementResponse() {
            var str = @"<FlexStatementResponse timestamp=""17 October, 2018 02:32 PM EDT"">
<Status>Success</Status>
<ReferenceCode>1735268776</ReferenceCode>
<Url>
https://gdcdyn.interactivebrokers.com/Universal/servlet/FlexStatementService.GetStatement
</Url>
</FlexStatementResponse>
";
            
            var obj = new Deserializer().Deserialize<XmlFlexStatementResponse, FlexStatementResponse>(GenerateStreamFromString(str));
        }

        [Test]
        public void TestFlexStatementsEmpty()
        {
            var str = @"<FlexQueryResponse queryName=""Las30Days"" type=""AF"">
<FlexStatements count=""1"">
<FlexStatement accountId=""xxxxxx"" fromDate=""20180917"" toDate=""20181016"" period=""Last30CalendarDays"" whenGenerated=""20181017;143211"">
</FlexStatement>
</FlexStatements>
</FlexQueryResponse>";

            var obj = new Deserializer().Deserialize<Xml.Contracts.FlexQueryResponse, Contracts.FlexQueryResponse>(GenerateStreamFromString(str));
        }

        [Test]
        public void TestAccountInformation()
        {
            var str = @"<FlexQueryResponse queryName=""Las30Days"" type=""AF"">
<FlexStatements count=""1"">
<FlexStatement accountId=""xxxxxx"" fromDate=""20180917"" toDate=""20181016"" period=""Last30CalendarDays"" whenGenerated=""20181017;143211"">
<AccountInformation accountId=""xxxxxx"" acctAlias=""xxxxxx"" model="""" currency=""EUR"" name=""xxxxxx"" accountType=""Broker Client"" customerType=""Individual"" accountCapabilities=""Margin"" tradingPermissions=""Stocks,Options,Warrants,Forex,Futures,Futures Options,Fully Paid Stock Loan"" registeredRepName="""" registeredRepPhone="""" dateOpened=""20150421"" dateFunded=""20170901"" dateClosed="""" street=""xxxxxx"" street2="""" city=""xxxxxx"" state=""DE-BY"" country=""Germany"" postalCode=""00000"" streetResidentialAddress=""xxxxxx"" street2ResidentialAddress="""" cityResidentialAddress=""xxxxxx"" stateResidentialAddress=""DE-BY"" countryResidentialAddress=""Germany"" postalCodeResidentialAddress=""00000"" masterName=""FXFlat Wertpapierhandelsbank GmbH"" ibEntity=""IB-UK"" primaryEmail=""xxxx@example.com"" />
</FlexStatement>
</FlexStatements>
</FlexQueryResponse>";
            

            var obj = new Deserializer().Deserialize<Xml.Contracts.FlexQueryResponse, Contracts.FlexQueryResponse>(GenerateStreamFromString(str));
        }

        public static Stream GenerateStreamFromString(string s)
        {
            var stream = new MemoryStream();
            var writer = new StreamWriter(stream);
            writer.Write(s);
            writer.Flush();
            stream.Position = 0;
            return stream;
        }
    }
}
