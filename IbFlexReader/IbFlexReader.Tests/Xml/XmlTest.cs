namespace IbFlexReader.Tests.Xml
{
    using System;
    using FluentAssertions;
    using IbFlexReader.Contracts;
    using IbFlexReader.Contracts.Enums;
    using IbFlexReader.Xml;
    using IbFlexReader.Xml.Contracts;
    using NUnit.Framework;
    using FlexQueryResponse = IbFlexReader.Xml.Contracts.QueryResponse.FlexQueryResponse;

    public class XmlTest
    {
        private IStreamBuilder<string> sb;

        [SetUp]
        public void InitTests()
        {
            sb = new StringStream();
        }

        [Test]
        public void TestFlexStatementResponse()
        {
            var str = @"<FlexStatementResponse timestamp=""17 October, 2018 02:32 PM EDT"">
<Status>Success</Status>
<ReferenceCode>1735268776</ReferenceCode>
<Url>
https://gdcdyn.interactivebrokers.com/Universal/servlet/FlexStatementService.GetStatement
</Url>
</FlexStatementResponse>
";

            var obj = Deserializer.Deserialize<XmlFlexStatementResponse, FlexStatementResponse>(sb.GenerateStream(str), out var msg);
            obj.Status.Should().Be("Success");
            obj.ReferenceCode.Should().Be(1735268776);
        }

        [Test]
        public void TestFlexStatementsEmpty()
        {
            var str = StringFactory.XmlStart + StringFactory.XmlEnd;

            var obj = Deserializer.Deserialize<FlexQueryResponse, Contracts.FlexQueryResponse>(sb.GenerateStream(str), out var msg);
            obj.FlexStatements.FlexStatement.FromDate.Should().Be(new DateTime(2018, 09, 17));
            obj.FlexStatements.FlexStatement.WhenGenerated.Should().Be(new DateTime(2018, 10, 17, 14, 32, 11));
            obj.FlexStatements.FlexStatement.ToDate.Should().Be(new DateTime(2018, 10, 16));
            obj.FlexStatements.Count.Should().Be(1);
        }

        [Test]
        public void TestAccountInformation()
        {
            var str = StringFactory.XmlStart +
                @"<AccountInformation accountId=""xxxxxx"" acctAlias=""xxxxxx"" model="""" currency=""EUR"" name=""xxxxxx"" accountType=""Broker Client"" customerType=""Individual"" accountCapabilities=""Margin"" tradingPermissions=""Stocks,Options,Warrants,Forex,Futures,Futures Options,Fully Paid Stock Loan"" registeredRepName="""" registeredRepPhone="""" dateOpened=""20150421"" dateFunded=""20170901"" dateClosed="""" street=""xxxxxx"" street2="""" city=""xxxxxx"" state=""DE-BY"" country=""Germany"" postalCode=""00000"" streetResidentialAddress=""xxxxxx"" street2ResidentialAddress="""" cityResidentialAddress=""xxxxxx"" stateResidentialAddress=""DE-BY"" countryResidentialAddress=""Germany"" postalCodeResidentialAddress=""00000"" masterName=""FXFlat Wertpapierhandelsbank GmbH"" ibEntity=""IB-UK"" primaryEmail=""xxxx@example.com"" />"
                + StringFactory.XmlEnd;

            var obj = Deserializer.Deserialize<FlexQueryResponse, Contracts.FlexQueryResponse>(sb.GenerateStream(str), out var msg);
            var accInfo = obj.FlexStatements.FlexStatement.AccountInformation;
            accInfo.AccountId.Should().Be("xxxxxx");
            accInfo.Currency.Should().Be(Currencies.EUR);
            accInfo.DateOpened.Should().Be(new DateTime(2015, 4, 21));
            accInfo.DateFunded.Should().Be(new DateTime(2017, 09, 01));
        }

        [Test]
        public void TestEquitySummaryInBase()
        {
            var str = StringFactory.XmlStart + @"<EquitySummaryInBase>
<EquitySummaryByReportDateInBase accountId=""xxx"" acctAlias=""xxx  Max Mustermann"" model="""" reportDate=""20180914"" cash=""-13262.920231441"" cashLong=""18748.131125"" cashShort=""-32011.051356441"" slbCashCollateral=""0"" slbCashCollateralLong=""0"" slbCashCollateralShort=""0"" stock=""43004.90989"" stockLong=""43004.90989"" stockShort=""0"" slbDirectSecuritiesBorrowed=""0"" slbDirectSecuritiesBorrowedLong=""0"" slbDirectSecuritiesBorrowedShort=""0"" slbDirectSecuritiesLent=""0"" slbDirectSecuritiesLentLong=""0"" slbDirectSecuritiesLentShort=""0"" options=""-4578.2657522"" optionsLong=""412.9047884"" optionsShort=""-4991.1705406"" commodities=""0"" commoditiesLong=""0"" commoditiesShort=""0"" bonds=""0"" bondsLong=""0"" bondsShort=""0"" notes=""0"" notesLong=""0"" notesShort=""0"" funds=""0"" fundsLong=""0"" fundsShort=""0"" interestAccruals=""-48.0988139"" interestAccrualsLong=""0"" interestAccrualsShort=""-48.0988139"" softDollars=""0"" softDollarsLong=""0"" softDollarsShort=""0"" forexCfdUnrealizedPl=""0"" forexCfdUnrealizedPlLong=""0"" forexCfdUnrealizedPlShort=""0"" cfdUnrealizedPl=""0"" cfdUnrealizedPlLong=""0"" cfdUnrealizedPlShort=""0"" dividendAccruals=""0"" dividendAccrualsLong=""0"" dividendAccrualsShort=""0"" fdicInsuredBankSweepAccountCashComponent=""0"" fdicInsuredBankSweepAccountCashComponentLong=""0"" fdicInsuredBankSweepAccountCashComponentShort=""0"" fdicInsuredAccountInterestAccrualsComponent=""0"" fdicInsuredAccountInterestAccrualsComponentLong=""0"" fdicInsuredAccountInterestAccrualsComponentShort=""0"" total=""25115.625092459"" totalLong=""62165.9458034"" totalShort=""-37050.320710941"" />
<EquitySummaryByReportDateInBase accountId=""xxx"" acctAlias=""xxx  Max Mustermann"" model="""" reportDate=""20180917"" cash=""-17586.197864108"" cashLong=""18748.131125"" cashShort=""-36334.328989108"" slbCashCollateral=""0"" slbCashCollateralLong=""0"" slbCashCollateralShort=""0"" stock=""46148.1537"" stockLong=""46148.1537"" stockShort=""0"" slbDirectSecuritiesBorrowed=""0"" slbDirectSecuritiesBorrowedLong=""0"" slbDirectSecuritiesBorrowedShort=""0"" slbDirectSecuritiesLent=""0"" slbDirectSecuritiesLentLong=""0"" slbDirectSecuritiesLentShort=""0"" options=""-3609.971252"" optionsLong=""432.161028"" optionsShort=""-4042.13228"" commodities=""0"" commoditiesLong=""0"" commoditiesShort=""0"" bonds=""0"" bondsLong=""0"" bondsShort=""0"" notes=""0"" notesLong=""0"" notesShort=""0"" funds=""0"" fundsLong=""0"" fundsShort=""0"" interestAccruals=""-58.637709"" interestAccrualsLong=""0"" interestAccrualsShort=""-58.637709"" softDollars=""0"" softDollarsLong=""0"" softDollarsShort=""0"" forexCfdUnrealizedPl=""0"" forexCfdUnrealizedPlLong=""0"" forexCfdUnrealizedPlShort=""0"" cfdUnrealizedPl=""0"" cfdUnrealizedPlLong=""0"" cfdUnrealizedPlShort=""0"" dividendAccruals=""0"" dividendAccrualsLong=""0"" dividendAccrualsShort=""0"" fdicInsuredBankSweepAccountCashComponent=""0"" fdicInsuredBankSweepAccountCashComponentLong=""0"" fdicInsuredBankSweepAccountCashComponentShort=""0"" fdicInsuredAccountInterestAccrualsComponent=""0"" fdicInsuredAccountInterestAccrualsComponentLong=""0"" fdicInsuredAccountInterestAccrualsComponentShort=""0"" total=""24893.346874892"" totalLong=""65328.445853"" totalShort=""-40435.098978108"" />
</EquitySummaryInBase>" + StringFactory.XmlEnd;

            var obj = Deserializer.Deserialize<FlexQueryResponse, Contracts.FlexQueryResponse>(sb.GenerateStream(str), out var msg);
            var summaryInBase = obj.FlexStatements.FlexStatement.EquitySummaryInBase;
            summaryInBase.EquitySummaryByReportDateInBase.Count.Should().Be(2);
            var entry = summaryInBase.EquitySummaryByReportDateInBase[0];
            entry.Cash.Should().BeApproximately(-13262.92, 0.01);
        }

        [Test]
        public void TestOpenPositions()
        {
            var str = StringFactory.XmlStart + @"<OpenPositions>
<OpenPosition accountId=""xxxx"" acctAlias=""xxxx  xxxx xxxx"" model="""" currency=""EUR"" fxRateToBase=""1"" assetCategory=""STK"" symbol=""PSMd"" description=""PROSIEBENSAT.1 MEDIA SE"" conid=""132721011"" securityID=""DE000PSM7770"" securityIDType=""ISIN"" cusip="""" isin=""DE000PSM7770"" listingExchange=""IBIS"" underlyingConid="""" underlyingSymbol="""" underlyingSecurityID="""" underlyingListingExchange="""" issuer="""" multiplier=""1"" strike="""" expiry="""" putCall="""" principalAdjustFactor="""" reportDate=""20181016"" position=""100"" markPrice=""21.38"" positionValue=""2138"" openPrice=""23.42"" costBasisPrice=""23.42"" costBasisMoney=""2342"" percentOfNAV="""" fifoPnlUnrealized=""-204"" side=""Long"" levelOfDetail=""LOT"" openDateTime=""20180719;150000"" holdingPeriodDateTime=""20180719;150000"" code="""" originatingOrderID="""" originatingTransactionID=""9290307278"" accruedInt="""" />
<OpenPosition accountId=""xxxx"" acctAlias=""xxxx  xxxx xxxx"" model="""" currency=""EUR"" fxRateToBase=""1"" assetCategory=""STK"" symbol=""SNH"" description=""STEINHOFF INTERNATIONAL H NV"" conid=""214727589"" securityID=""NL0011375019"" securityIDType=""ISIN"" cusip="""" isin=""NL0011375019"" listingExchange=""IBIS2"" underlyingConid="""" underlyingSymbol="""" underlyingSecurityID="""" underlyingListingExchange="""" issuer="""" multiplier=""1"" strike="""" expiry="""" putCall="""" principalAdjustFactor="""" reportDate=""20181016"" position=""200"" markPrice=""0.1265"" positionValue=""25.3"" openPrice=""0.2422"" costBasisPrice=""0.2422"" costBasisMoney=""48.44"" percentOfNAV="""" fifoPnlUnrealized=""-23.14"" side=""Long"" levelOfDetail=""LOT"" openDateTime=""20180321;101315"" holdingPeriodDateTime=""20180321;101315"" code="""" originatingOrderID=""1015934799"" originatingTransactionID=""8789843416"" accruedInt="""" />
<OpenPosition accountId=""xxxx"" acctAlias=""xxxx  xxxx xxxx"" model="""" currency=""USD"" fxRateToBase=""0.86395"" assetCategory=""OPT"" symbol=""INTC  181026P00046000"" description=""INTC 26OCT18 46.0 P"" conid=""332532980"" securityID="""" securityIDType="""" cusip="""" isin="""" listingExchange="""" underlyingConid=""270639"" underlyingSymbol=""INTC"" underlyingSecurityID="""" underlyingListingExchange=""NASDAQ"" issuer="""" multiplier=""100"" strike=""46"" expiry=""20181026"" putCall=""P"" principalAdjustFactor="""" reportDate=""20181016"" position=""-1"" markPrice=""1.3375"" positionValue=""-133.75"" openPrice=""1.24"" costBasisPrice=""1.24"" costBasisMoney=""-124"" percentOfNAV="""" fifoPnlUnrealized=""-9.75"" side=""Short"" levelOfDetail=""LOT"" openDateTime=""20181001;155509"" holdingPeriodDateTime=""20181001;155509"" code="""" originatingOrderID=""1094835050"" originatingTransactionID=""9610469328"" accruedInt="""" />
<OpenPosition accountId=""xxxx"" acctAlias=""xxxx  xxxx xxxx"" model="""" currency=""USD"" fxRateToBase=""0.86395"" assetCategory=""OPT"" symbol=""INTC  181026C00047000"" description=""INTC 26OCT18 47.0 C"" conid=""332532927"" securityID="""" securityIDType="""" cusip="""" isin="""" listingExchange="""" underlyingConid=""270639"" underlyingSymbol=""INTC"" underlyingSecurityID="""" underlyingListingExchange=""NASDAQ"" issuer="""" multiplier=""100"" strike=""47"" expiry=""20181026"" putCall=""C"" principalAdjustFactor="""" reportDate=""20181016"" position=""-1"" markPrice=""0.8374"" positionValue=""-83.74"" openPrice=""1.24"" costBasisPrice=""1.24"" costBasisMoney=""-124"" percentOfNAV="""" fifoPnlUnrealized=""40.26"" side=""Short"" levelOfDetail=""LOT"" openDateTime=""20181001;155509"" holdingPeriodDateTime=""20181001;155509"" code="""" originatingOrderID=""1094834574"" originatingTransactionID=""9610469194"" accruedInt="""" />
</OpenPositions>" + StringFactory.XmlEnd;

            var obj = Deserializer.Deserialize<FlexQueryResponse, Contracts.FlexQueryResponse>(sb.GenerateStream(str), out var msg);
            var openPositions = obj.FlexStatements.FlexStatement.OpenPositions;
            openPositions.OpenPosition.Count.Should().Be(4);
            var first = openPositions.OpenPosition[0];
            first.AssetCategory.Should().Be(AssetCategory.STK);
            first.Symbol.Should().Be("PSMd");
            first.Currency.Should().Be(Currencies.EUR);
            first.PutCall.Should().Be(null);
        }

        [Test]
        public void TestTrades()
        {
            var str = StringFactory.XmlStart + @"<Trades>
<Trade currency=""EUR"" assetCategory=""STK"" symbol=""SNH"" underlyingSymbol="""" multiplier=""1"" putCall="""" dateTime=""20171214;041923"" quantity=""200"" tradePrice=""0.593"" openCloseIndicator=""O"" ibCommission=""-4"" ibCommissionCurrency=""EUR"" notes=""A"" orderType=""LMT"" strike="""" />
<Trade currency=""USD"" assetCategory=""OPT"" symbol=""AAPL  171020C00162500"" underlyingSymbol=""AAPL"" multiplier=""100"" putCall=""C"" dateTime=""20170921;132105"" quantity=""-1"" tradePrice=""0.9"" openCloseIndicator=""O"" ibCommission=""-3.5"" ibCommissionCurrency=""USD"" notes="""" orderType=""LMT"" strike=""162.5"" />
<Trade currency=""USD"" assetCategory=""OPT"" symbol=""AAPL  171020C00162500"" underlyingSymbol=""AAPL"" multiplier=""100"" putCall=""C"" dateTime=""20170929;094647"" quantity=""1"" tradePrice=""0.4"" openCloseIndicator=""C"" ibCommission=""-3.5"" ibCommissionCurrency=""USD"" notes="""" orderType=""LMT"" strike=""162.5"" />
<Trade currency=""USD"" assetCategory=""FOP"" symbol=""ADUG8 P0740"" underlyingSymbol=""ADH8"" multiplier=""100000"" putCall=""P"" dateTime=""20171214;113319"" quantity=""1"" tradePrice=""0.0013"" openCloseIndicator=""C"" ibCommission=""-3.5"" ibCommissionCurrency=""USD"" notes="""" orderType=""LMT"" strike=""0.74"" />
</Trades>" + StringFactory.XmlEnd;

            var obj = Deserializer.Deserialize<FlexQueryResponse, Contracts.FlexQueryResponse>(sb.GenerateStream(str), out var msg);
            var trades = obj.FlexStatements.FlexStatement.Trades.Trade;
            trades.Count.Should().Be(4);
            trades[0].Notes.Value.Should().Be(Notes.Assigned);
        }

        [Test]
        public void TestCashTransactions()
        {
            var str = StringFactory.XmlStart + @"<CashTransactions>
<CashTransaction accountId=""xxxx"" acctAlias=""xxxx"" model="""" currency=""USD"" fxRateToBase=""0.86553"" assetCategory=""STK"" symbol=""LB"" description=""LB(US5017971046) CASH DIVIDEND 0.60000000 USD PER SHARE - US TAX"" conid=""125005718"" securityID="""" securityIDType="""" cusip="""" isin="""" listingExchange=""NYSE"" underlyingConid="""" underlyingSymbol="""" underlyingSecurityID="""" underlyingListingExchange="""" issuer="""" multiplier=""1"" strike="""" expiry="""" putCall="""" principalAdjustFactor="""" dateTime=""20180907"" amount=""-37.53"" type=""Withholding Tax"" tradeID="""" code="""" transactionID=""9507921240"" reportDate=""20180907"" clientReference="""" />
<CashTransaction accountId=""xxxx"" acctAlias=""xxxx"" model="""" currency=""USD"" fxRateToBase=""0.86553"" assetCategory=""STK"" symbol=""LB"" description=""LB(US5017971046) PAYMENT IN LIEU OF DIVIDEND - US TAX"" conid=""125005718"" securityID="""" securityIDType="""" cusip="""" isin="""" listingExchange=""NYSE"" underlyingConid="""" underlyingSymbol="""" underlyingSecurityID="""" underlyingListingExchange="""" issuer="""" multiplier=""1"" strike="""" expiry="""" putCall="""" principalAdjustFactor="""" dateTime=""20180907"" amount=""-7.47"" type=""Withholding Tax"" tradeID="""" code="""" transactionID=""9507921248"" reportDate=""20180907"" clientReference="""" />
<CashTransaction accountId=""xxxx"" acctAlias=""xxxx"" model="""" currency=""USD"" fxRateToBase=""0.86553"" assetCategory=""STK"" symbol=""LB"" description=""LB(US5017971046) CASH DIVIDEND 0.60000000 USD PER SHARE (Ordinary Dividend)"" conid=""125005718"" securityID="""" securityIDType="""" cusip="""" isin="""" listingExchange=""NYSE"" underlyingConid="""" underlyingSymbol="""" underlyingSecurityID="""" underlyingListingExchange="""" issuer="""" multiplier=""1"" strike="""" expiry="""" putCall="""" principalAdjustFactor="""" dateTime=""20180907"" amount=""250.2"" type=""Dividends"" tradeID="""" code="""" transactionID=""9507921233"" reportDate=""20180907"" clientReference="""" />
<CashTransaction accountId=""xxxx"" acctAlias=""xxxx"" model="""" currency=""USD"" fxRateToBase=""0.86553"" assetCategory=""STK"" symbol=""LB"" description=""LB(US5017971046) PAYMENT IN LIEU OF DIVIDEND (Ordinary Dividend)"" conid=""125005718"" securityID="""" securityIDType="""" cusip="""" isin="""" listingExchange=""NYSE"" underlyingConid="""" underlyingSymbol="""" underlyingSecurityID="""" underlyingListingExchange="""" issuer="""" multiplier=""1"" strike="""" expiry="""" putCall="""" principalAdjustFactor="""" dateTime=""20180907"" amount=""49.8"" type=""Payment In Lieu Of Dividends"" tradeID="""" code="""" transactionID=""9507921241"" reportDate=""20180907"" clientReference="""" />
<CashTransaction accountId=""xxxx"" acctAlias=""xxxx"" model="""" currency=""EUR"" fxRateToBase=""1"" assetCategory="""" symbol="""" description=""ABCOPRANP FOR SEP 2018"" conid="""" securityID="""" securityIDType="""" cusip="""" isin="""" listingExchange="""" underlyingConid="""" underlyingSymbol="""" underlyingSecurityID="""" underlyingListingExchange="""" issuer="""" multiplier=""0"" strike="""" expiry="""" putCall="""" principalAdjustFactor="""" dateTime=""20180904"" amount=""-3.88"" type=""Other Fees"" tradeID="""" code="""" transactionID=""9488686219"" reportDate=""20180904"" clientReference="""" />
<CashTransaction accountId=""xxxx"" acctAlias=""xxxx"" model="""" currency=""EUR"" fxRateToBase=""1"" assetCategory="""" symbol="""" description=""SNAPSHOTVALUENONPRO FOR SEP 2018"" conid="""" securityID="""" securityIDType="""" cusip="""" isin="""" listingExchange="""" underlyingConid="""" underlyingSymbol="""" underlyingSecurityID="""" underlyingListingExchange="""" issuer="""" multiplier=""0"" strike="""" expiry="""" putCall="""" principalAdjustFactor="""" dateTime=""20180904"" amount=""-8.62"" type=""Other Fees"" tradeID="""" code="""" transactionID=""9488686214"" reportDate=""20180904"" clientReference="""" />
<CashTransaction accountId=""xxxx"" acctAlias=""xxxx"" model="""" currency=""EUR"" fxRateToBase=""1"" assetCategory="""" symbol="""" description=""SNAPSHOTVALUENONPRO FOR AUG 2018"" conid="""" securityID="""" securityIDType="""" cusip="""" isin="""" listingExchange="""" underlyingConid="""" underlyingSymbol="""" underlyingSecurityID="""" underlyingListingExchange="""" issuer="""" multiplier=""0"" strike="""" expiry="""" putCall="""" principalAdjustFactor="""" dateTime=""20180905"" amount=""8.58"" type=""Other Fees"" tradeID="""" code="""" transactionID=""9496151388"" reportDate=""20180905"" clientReference="""" />
<CashTransaction accountId=""xxxx"" acctAlias=""xxxx"" model="""" currency=""USD"" fxRateToBase=""0.8603"" assetCategory="""" symbol="""" description=""USD DEBIT INT FOR AUG-2018"" conid="""" securityID="""" securityIDType="""" cusip="""" isin="""" listingExchange="""" underlyingConid="""" underlyingSymbol="""" underlyingSecurityID="""" underlyingListingExchange="""" issuer="""" multiplier=""0"" strike="""" expiry="""" putCall="""" principalAdjustFactor="""" dateTime=""20180906"" amount=""-129.89"" type=""Broker Interest Paid"" tradeID="""" code="""" transactionID=""9500569975"" reportDate=""20180906"" clientReference="""" />
</CashTransactions>
" + StringFactory.XmlEnd;
            var obj = Deserializer.Deserialize<FlexQueryResponse, Contracts.FlexQueryResponse>(sb.GenerateStream(str), out var msg);
            var transactions = obj.FlexStatements.FlexStatement.CashTransactions.CashTransaction;
            transactions.Count.Should().Be(8);
        }

        [Test]
        public void TestTrades_CombinedDateTime()
        {
            var str = StringFactory.XmlStart + @"<Trades><Trade accountId=""xxxxx"" acctAlias=""xxxxx"" model="""" currency=""USD"" fxRateToBase=""0.85902"" assetCategory=""STK"" symbol=""BP"" description=""BP PLC-SPONS ADR"" conid=""5171"" securityID="""" securityIDType="""" cusip="""" isin="""" listingExchange=""NYSE"" underlyingConid="""" underlyingSymbol="""" underlyingSecurityID="""" underlyingListingExchange="""" issuer="""" multiplier=""1"" strike="""" expiry="""" tradeID=""2222253181"" putCall="""" reportDate=""20180927"" principalAdjustFactor="""" dateTime=""20180927;145131"" settleDateTarget=""20181001"" transactionType=""ExchTrade"" exchange=""NYSENAT"" quantity=""-100"" tradePrice=""46.96"" tradeMoney=""-4696"" proceeds=""4696"" taxes=""0"" ibCommission=""-2"" ibCommissionCurrency=""USD"" netCash=""4694"" closePrice=""46.87"" openCloseIndicator=""O"" notes="""" cost=""-4694"" fifoPnlRealized=""0"" fxPnl=""0"" mtmPnl=""9"" origTradePrice=""0"" origTradeDate="""" origTradeID="""" origOrderID=""0"" clearingFirmID="""" transactionID=""9596216645"" buySell=""SELL"" ibOrderID=""1093485502"" ibExecID=""0000fda5.5bacd19b.01.01"" brokerageOrderID=""000fcf6e.000174c4.5bac6200.0001"" orderReference="""" volatilityOrderLink="""" exchOrderId=""N/A"" extExecID=""0d.a055.08.4a.0000f1:28319"" orderTime=""20180927;145131"" openDateTime="""" holdingPeriodDateTime="""" whenRealized="""" whenReopened="""" levelOfDetail=""EXECUTION"" changeInPrice=""0"" changeInQuantity=""0"" orderType=""LMT"" traderID="""" isAPIOrder=""N"" />
<Trade accountId=""xxxxx"" acctAlias=""xxxxx"" model="""" currency=""USD"" fxRateToBase=""0.86156"" assetCategory=""STK"" symbol=""BP"" description=""BP PLC-SPONS ADR"" conid=""5171"" securityID="""" securityIDType="""" cusip="""" isin="""" listingExchange=""NYSE"" underlyingConid="""" underlyingSymbol="""" underlyingSecurityID="""" underlyingListingExchange="""" issuer="""" multiplier=""1"" strike="""" expiry="""" tradeID=""2223171268"" putCall="""" reportDate=""20180928"" principalAdjustFactor="""" dateTime=""20180928;121440"" settleDateTarget=""20181002"" transactionType=""ExchTrade"" exchange=""ISLAND"" quantity=""100"" tradePrice=""46.43"" tradeMoney=""4643"" proceeds=""-4643"" taxes=""0"" ibCommission=""-2"" ibCommissionCurrency=""USD"" netCash=""-4645"" closePrice=""46.1"" openCloseIndicator=""C"" notes="""" cost=""4694"" fifoPnlRealized=""49"" fxPnl=""0"" mtmPnl=""-33"" origTradePrice=""0"" origTradeDate="""" origTradeID="""" origOrderID=""0"" clearingFirmID="""" transactionID=""9601735128"" buySell=""BUY"" ibOrderID=""1093940321"" ibExecID=""00011e50.5badf9c3.01.01"" brokerageOrderID=""000fcf6e.000174c4.5badc949.0001"" orderReference="""" volatilityOrderLink="""" exchOrderId=""N/A"" extExecID=""0327610381"" orderTime=""20180928;121440"" openDateTime="""" holdingPeriodDateTime="""" whenRealized="""" whenReopened="""" levelOfDetail=""EXECUTION"" changeInPrice=""0"" changeInQuantity=""0"" orderType=""LMT"" traderID="""" isAPIOrder=""N"" />
</Trades>" + StringFactory.XmlEnd;
            var obj = Deserializer.Deserialize<FlexQueryResponse, Contracts.FlexQueryResponse>(sb.GenerateStream(str), out var msg);
            var trades = obj.FlexStatements.FlexStatement.Trades.Trade;
            trades[0].TradeDateTime.Should().Be(new DateTime(2018, 09, 27, 14, 51, 31));
        }

        [Test]
        // currency of first trade will be unknown
        public void ThrowNoExceptionOnParseError()
        {
            var str = StringFactory.XmlStart + @"<Trades>
<Trade accountId=""xxxxx"" acctAlias=""xxxxx"" model="""" currency=""UNKNOWN"" fxRateToBase=""0.85902"" assetCategory=""STK"" symbol=""BP"" description=""BP PLC-SPONS ADR"" conid=""5171"" securityID="""" securityIDType="""" cusip="""" isin="""" listingExchange=""NYSE"" underlyingConid="""" underlyingSymbol="""" underlyingSecurityID="""" underlyingListingExchange="""" issuer="""" multiplier=""1"" strike="""" expiry="""" tradeID=""2222253181"" putCall="""" reportDate=""20180927"" principalAdjustFactor="""" dateTime=""20180927;145131"" settleDateTarget=""20181001"" transactionType=""ExchTrade"" exchange=""NYSENAT"" quantity=""-100"" tradePrice=""46.96"" tradeMoney=""-4696"" proceeds=""4696"" taxes=""0"" ibCommission=""-2"" ibCommissionCurrency=""USD"" netCash=""4694"" closePrice=""46.87"" openCloseIndicator=""O"" notes="""" cost=""-4694"" fifoPnlRealized=""0"" fxPnl=""0"" mtmPnl=""9"" origTradePrice=""0"" origTradeDate="""" origTradeID="""" origOrderID=""0"" clearingFirmID="""" transactionID=""9596216645"" buySell=""SELL"" ibOrderID=""1093485502"" ibExecID=""0000fda5.5bacd19b.01.01"" brokerageOrderID=""000fcf6e.000174c4.5bac6200.0001"" orderReference="""" volatilityOrderLink="""" exchOrderId=""N/A"" extExecID=""0d.a055.08.4a.0000f1:28319"" orderTime=""20180927;145131"" openDateTime="""" holdingPeriodDateTime="""" whenRealized="""" whenReopened="""" levelOfDetail=""EXECUTION"" changeInPrice=""0"" changeInQuantity=""0"" orderType=""LMT"" traderID="""" isAPIOrder=""N"" />
<Trade accountId=""xxxxx"" acctAlias=""xxxxx"" model="""" currency=""USD"" fxRateToBase=""0.86156"" assetCategory=""STK"" symbol=""BP"" description=""BP PLC-SPONS ADR"" conid=""5171"" securityID="""" securityIDType="""" cusip="""" isin="""" listingExchange=""NYSE"" underlyingConid="""" underlyingSymbol="""" underlyingSecurityID="""" underlyingListingExchange="""" issuer="""" multiplier=""1"" strike="""" expiry="""" tradeID=""2223171268"" putCall="""" reportDate=""20180928"" principalAdjustFactor="""" dateTime=""20180928;121440"" settleDateTarget=""20181002"" transactionType=""ExchTrade"" exchange=""ISLAND"" quantity=""100"" tradePrice=""46.43"" tradeMoney=""4643"" proceeds=""-4643"" taxes=""0"" ibCommission=""-2"" ibCommissionCurrency=""USD"" netCash=""-4645"" closePrice=""46.1"" openCloseIndicator=""C"" notes="""" cost=""4694"" fifoPnlRealized=""49"" fxPnl=""0"" mtmPnl=""-33"" origTradePrice=""0"" origTradeDate="""" origTradeID="""" origOrderID=""0"" clearingFirmID="""" transactionID=""9601735128"" buySell=""BUY"" ibOrderID=""1093940321"" ibExecID=""00011e50.5badf9c3.01.01"" brokerageOrderID=""000fcf6e.000174c4.5badc949.0001"" orderReference="""" volatilityOrderLink="""" exchOrderId=""N/A"" extExecID=""0327610381"" orderTime=""20180928;121440"" openDateTime="""" holdingPeriodDateTime="""" whenRealized="""" whenReopened="""" levelOfDetail=""EXECUTION"" changeInPrice=""0"" changeInQuantity=""0"" orderType=""LMT"" traderID="""" isAPIOrder=""N"" />
</Trades>" + StringFactory.XmlEnd;
            var obj = Deserializer.Deserialize<FlexQueryResponse, Contracts.FlexQueryResponse>(sb.GenerateStream(str), out var msg);
            var trades = obj.FlexStatements.FlexStatement.Trades.Trade;
            trades[0].Currency.Should().Be(Currencies.USD);
            msg.Count.Should().Be(1);
            msg[0].Message.Should().Contain("Currency");
        }
               
        [Test]
        public void CashTrade()
        {
            var str = StringFactory.XmlStart + @"<Trades>
<Trade accountId=""xxxx"" acctAlias=""xxxx  xxxx"" model="""" currency=""USD"" fxRateToBase=""0.8313"" assetCategory=""CASH"" symbol=""EUR.USD"" description=""EUR.USD"" conid=""12087792"" securityID="""" securityIDType="""" cusip="""" isin="""" listingExchange="""" underlyingConid="""" underlyingSymbol="""" underlyingSecurityID="""" underlyingListingExchange="""" issuer="""" multiplier=""1"" strike="""" expiry="""" tradeID=""1993428808"" putCall="""" reportDate=""20180105"" principalAdjustFactor="""" dateTime=""20180105;113035"" settleDateTarget=""20180109"" transactionType=""ExchTrade"" exchange=""IDEALFX"" quantity=""-20000"" tradePrice=""1.20302"" tradeMoney=""-24060.4"" proceeds=""24060.4"" taxes=""0"" ibCommission=""-3.1074"" ibCommissionCurrency=""EUR"" netCash=""0"" closePrice=""0"" openCloseIndicator="""" notes="""" cost=""0"" fifoPnlRealized=""0"" fxPnl=""0"" mtmPnl=""1.41052"" origTradePrice=""0"" origTradeDate="""" origTradeID="""" origOrderID=""0"" clearingFirmID="""" transactionID=""8465497950"" buySell=""SELL"" ibOrderID=""982171925"" ibExecID=""0000e9c6.5a4ea7d4.01.01"" brokerageOrderID="""" orderReference="""" volatilityOrderLink="""" exchOrderId=""N/A"" extExecID=""30704215"" orderTime=""20180105;113035"" openDateTime="""" holdingPeriodDateTime="""" whenRealized="""" whenReopened="""" levelOfDetail=""EXECUTION"" changeInPrice=""0"" changeInQuantity=""0"" orderType=""LMT"" traderID="""" isAPIOrder=""N"" />
<Trade accountId=""xxxx"" acctAlias=""xxxx  xxxx"" model="""" currency=""USD"" fxRateToBase=""0.80595"" assetCategory=""CASH"" symbol=""EUR.USD"" description=""EUR.USD"" conid=""12087792"" securityID="""" securityIDType="""" cusip="""" isin="""" listingExchange="""" underlyingConid="""" underlyingSymbol="""" underlyingSecurityID="""" underlyingListingExchange="""" issuer="""" multiplier=""1"" strike="""" expiry="""" tradeID=""2009714866"" putCall="""" reportDate=""20180124"" principalAdjustFactor="""" dateTime=""20180124;111047"" settleDateTarget=""20180126"" transactionType=""ExchTrade"" exchange=""IDEALFX"" quantity=""24118"" tradePrice=""1.23819"" tradeMoney=""29862.66642"" proceeds=""-29862.66642"" taxes=""0"" ibCommission=""-3.0491625"" ibCommissionCurrency=""EUR"" netCash=""0"" closePrice=""0"" openCloseIndicator="""" notes="""" cost=""0"" fifoPnlRealized=""0"" fxPnl=""0"" mtmPnl=""50.183999"" origTradePrice=""0"" origTradeDate="""" origTradeID="""" origOrderID=""0"" clearingFirmID="""" transactionID=""8541910865"" buySell=""BUY"" ibOrderID=""990018418"" ibExecID=""00011770.5a6521f9.01.01"" brokerageOrderID="""" orderReference="""" volatilityOrderLink="""" exchOrderId=""N/A"" extExecID=""E20180124L1000081072"" orderTime=""20180124;111047"" openDateTime="""" holdingPeriodDateTime="""" whenRealized="""" whenReopened="""" levelOfDetail=""EXECUTION"" changeInPrice=""0"" changeInQuantity=""0"" orderType=""LMT"" traderID="""" isAPIOrder=""N"" />
<Trade accountId=""xxxx"" acctAlias=""xxxx  xxxx"" model="""" currency=""USD"" fxRateToBase=""0.80664"" assetCategory=""CASH"" symbol=""EUR.USD"" description=""EUR.USD"" conid=""12087792"" securityID="""" securityIDType="""" cusip="""" isin="""" listingExchange="""" underlyingConid="""" underlyingSymbol="""" underlyingSecurityID="""" underlyingListingExchange="""" issuer="""" multiplier=""1"" strike="""" expiry="""" tradeID=""2010611102"" putCall="""" reportDate=""20180125"" principalAdjustFactor="""" dateTime=""20180125;053530"" settleDateTarget=""20180129"" transactionType=""ExchTrade"" exchange=""IDEALFX"" quantity=""-10000"" tradePrice=""1.24201"" tradeMoney=""-12420.1"" proceeds=""12420.1"" taxes=""0"" ibCommission=""-3.0223125"" ibCommissionCurrency=""EUR"" netCash=""0"" closePrice=""0"" openCloseIndicator="""" notes="""" cost=""0"" fifoPnlRealized=""0"" fxPnl=""0"" mtmPnl=""18.549464"" origTradePrice=""0"" origTradeDate="""" origTradeID="""" origOrderID=""0"" clearingFirmID="""" transactionID=""8547236949"" buySell=""SELL"" ibOrderID=""990453235"" ibExecID=""000106d2.5a6543f1.01.01"" brokerageOrderID="""" orderReference="""" volatilityOrderLink="""" exchOrderId=""N/A"" extExecID=""R.USD-1516588203-AdxQLaAG7Eeh2Awq5KS5dxw"" orderTime=""20180125;053530"" openDateTime="""" holdingPeriodDateTime="""" whenRealized="""" whenReopened="""" levelOfDetail=""EXECUTION"" changeInPrice=""0"" changeInQuantity=""0"" orderType=""LMT"" traderID="""" isAPIOrder=""N"" />
</Trades>" + StringFactory.XmlEnd;

            var obj = Deserializer.Deserialize<FlexQueryResponse, Contracts.FlexQueryResponse>(sb.GenerateStream(str), out var msg);
            var trades = obj.FlexStatements.FlexStatement.Trades.Trade;
            trades[0].Currency.Should().Be(Currencies.USD);
            trades[0].Quantity.Should().Be(-20000);
            trades.Count.Should().Be(3);
        }
    }
}
