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
        private string start = @"<FlexQueryResponse queryName=""Las30Days"" type=""AF"">
<FlexStatements count=""1"">
<FlexStatement accountId=""xxxxxx"" fromDate=""20180917"" toDate=""20181016"" period=""Last30CalendarDays"" whenGenerated=""20181017;143211"">
";
        private string end = @"</FlexStatement>
</FlexStatements>
</FlexQueryResponse>";

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
            obj.Status.Should().Be("Success");
            obj.ReferenceCode.Should().Be(1735268776);
        }

        [Test]
        public void TestFlexStatementsEmpty()
        {
            var str = start + end;

            var obj = new Deserializer().Deserialize<Xml.Contracts.FlexQueryResponse, Contracts.FlexQueryResponse>(GenerateStreamFromString(str));
            obj.FlexStatements.FlexStatement.FromDate.Should().Be(new DateTime(2018, 09, 17));
            obj.FlexStatements.FlexStatement.WhenGenerated.Should().Be(new DateTime(2018, 10, 17, 14, 32, 11));
            obj.FlexStatements.FlexStatement.ToDate.Should().Be(new DateTime(2018, 10, 16));
            obj.FlexStatements.Count.Should().Be(1);
        }

        [Test]
        public void TestAccountInformation()
        {
            var str = start +
                @"<AccountInformation accountId=""xxxxxx"" acctAlias=""xxxxxx"" model="""" currency=""EUR"" name=""xxxxxx"" accountType=""Broker Client"" customerType=""Individual"" accountCapabilities=""Margin"" tradingPermissions=""Stocks,Options,Warrants,Forex,Futures,Futures Options,Fully Paid Stock Loan"" registeredRepName="""" registeredRepPhone="""" dateOpened=""20150421"" dateFunded=""20170901"" dateClosed="""" street=""xxxxxx"" street2="""" city=""xxxxxx"" state=""DE-BY"" country=""Germany"" postalCode=""00000"" streetResidentialAddress=""xxxxxx"" street2ResidentialAddress="""" cityResidentialAddress=""xxxxxx"" stateResidentialAddress=""DE-BY"" countryResidentialAddress=""Germany"" postalCodeResidentialAddress=""00000"" masterName=""FXFlat Wertpapierhandelsbank GmbH"" ibEntity=""IB-UK"" primaryEmail=""xxxx@example.com"" />"
                + end;            

            var obj = new Deserializer().Deserialize<Xml.Contracts.FlexQueryResponse, Contracts.FlexQueryResponse>(GenerateStreamFromString(str));
            var accInfo = obj.FlexStatements.FlexStatement.AccountInformation;
            accInfo.AccountId.Should().Be("xxxxxx");
            accInfo.Currency.Should().Be(Currencies.EUR);
            accInfo.DateOpened.Should().Be(new DateTime(2015, 4, 21));
            accInfo.DateFunded.Should().Be(new DateTime(2017, 09, 01));
        }

        [Test]
        public void TestEquitySummaryInBase()
        {
            var str = start + @"<EquitySummaryInBase>
<EquitySummaryByReportDateInBase accountId=""xxx"" acctAlias=""xxx  Max Mustermann"" model="""" reportDate=""20180914"" cash=""-13262.920231441"" cashLong=""18748.131125"" cashShort=""-32011.051356441"" slbCashCollateral=""0"" slbCashCollateralLong=""0"" slbCashCollateralShort=""0"" stock=""43004.90989"" stockLong=""43004.90989"" stockShort=""0"" slbDirectSecuritiesBorrowed=""0"" slbDirectSecuritiesBorrowedLong=""0"" slbDirectSecuritiesBorrowedShort=""0"" slbDirectSecuritiesLent=""0"" slbDirectSecuritiesLentLong=""0"" slbDirectSecuritiesLentShort=""0"" options=""-4578.2657522"" optionsLong=""412.9047884"" optionsShort=""-4991.1705406"" commodities=""0"" commoditiesLong=""0"" commoditiesShort=""0"" bonds=""0"" bondsLong=""0"" bondsShort=""0"" notes=""0"" notesLong=""0"" notesShort=""0"" funds=""0"" fundsLong=""0"" fundsShort=""0"" interestAccruals=""-48.0988139"" interestAccrualsLong=""0"" interestAccrualsShort=""-48.0988139"" softDollars=""0"" softDollarsLong=""0"" softDollarsShort=""0"" forexCfdUnrealizedPl=""0"" forexCfdUnrealizedPlLong=""0"" forexCfdUnrealizedPlShort=""0"" cfdUnrealizedPl=""0"" cfdUnrealizedPlLong=""0"" cfdUnrealizedPlShort=""0"" dividendAccruals=""0"" dividendAccrualsLong=""0"" dividendAccrualsShort=""0"" fdicInsuredBankSweepAccountCashComponent=""0"" fdicInsuredBankSweepAccountCashComponentLong=""0"" fdicInsuredBankSweepAccountCashComponentShort=""0"" fdicInsuredAccountInterestAccrualsComponent=""0"" fdicInsuredAccountInterestAccrualsComponentLong=""0"" fdicInsuredAccountInterestAccrualsComponentShort=""0"" total=""25115.625092459"" totalLong=""62165.9458034"" totalShort=""-37050.320710941"" />
<EquitySummaryByReportDateInBase accountId=""xxx"" acctAlias=""xxx  Max Mustermann"" model="""" reportDate=""20180917"" cash=""-17586.197864108"" cashLong=""18748.131125"" cashShort=""-36334.328989108"" slbCashCollateral=""0"" slbCashCollateralLong=""0"" slbCashCollateralShort=""0"" stock=""46148.1537"" stockLong=""46148.1537"" stockShort=""0"" slbDirectSecuritiesBorrowed=""0"" slbDirectSecuritiesBorrowedLong=""0"" slbDirectSecuritiesBorrowedShort=""0"" slbDirectSecuritiesLent=""0"" slbDirectSecuritiesLentLong=""0"" slbDirectSecuritiesLentShort=""0"" options=""-3609.971252"" optionsLong=""432.161028"" optionsShort=""-4042.13228"" commodities=""0"" commoditiesLong=""0"" commoditiesShort=""0"" bonds=""0"" bondsLong=""0"" bondsShort=""0"" notes=""0"" notesLong=""0"" notesShort=""0"" funds=""0"" fundsLong=""0"" fundsShort=""0"" interestAccruals=""-58.637709"" interestAccrualsLong=""0"" interestAccrualsShort=""-58.637709"" softDollars=""0"" softDollarsLong=""0"" softDollarsShort=""0"" forexCfdUnrealizedPl=""0"" forexCfdUnrealizedPlLong=""0"" forexCfdUnrealizedPlShort=""0"" cfdUnrealizedPl=""0"" cfdUnrealizedPlLong=""0"" cfdUnrealizedPlShort=""0"" dividendAccruals=""0"" dividendAccrualsLong=""0"" dividendAccrualsShort=""0"" fdicInsuredBankSweepAccountCashComponent=""0"" fdicInsuredBankSweepAccountCashComponentLong=""0"" fdicInsuredBankSweepAccountCashComponentShort=""0"" fdicInsuredAccountInterestAccrualsComponent=""0"" fdicInsuredAccountInterestAccrualsComponentLong=""0"" fdicInsuredAccountInterestAccrualsComponentShort=""0"" total=""24893.346874892"" totalLong=""65328.445853"" totalShort=""-40435.098978108"" />
</EquitySummaryInBase>" + end;

            var obj = new Deserializer().Deserialize<Xml.Contracts.FlexQueryResponse, Contracts.FlexQueryResponse>(GenerateStreamFromString(str));
            var summaryInBase = obj.FlexStatements.FlexStatement.EquitySummaryInBase;
            summaryInBase.EquitySummaryByReportDateInBase.Count.Should().Be(2);
            var entry = summaryInBase.EquitySummaryByReportDateInBase[0];
            entry.Cash.Should().BeApproximately(-13262.92, 0.01);
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
