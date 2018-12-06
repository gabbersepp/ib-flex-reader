using FluentAssertions;
using IbFlexReader.Contracts;
using IbFlexReader.Xml;
using NUnit.Framework;
using System;
using System.Text;
using IbFlexReader.Contracts.Enums;
using static IbFlexReader.Tests.StringFactory;

namespace IbFlexReader.Test
{
    public class XmlTradeConfirmsTest
    {
        private IStreamBuilder _streamBuilder;


        [SetUp]
        public void InitTests()
        {
            _streamBuilder = new StreamBuilder();
        }

        #region TradeConfirms

        [Test]
        public void TestTradeConfirms()
        {

            StringBuilder sb = new StringBuilder();
            sb.Append(XmlStart + @"<TradeConfirms>");
            sb.Append("<TradeConfirm accountId='AccID4711' acctAlias='' model='' currency='USD' assetCategory='OPT' symbol='HIIQ  190118P00040000' description='HIIQ 18JAN19 40.0 P' conid='307182456' securityID='' securityIDType='' cusip='' isin='' listingExchange='' underlyingConid='122012356' underlyingSymbol='HIIQ' underlyingSecurityID='' underlyingListingExchange='NASDAQ' issuer='' multiplier='100' strike='40' expiry='20190118' putCall='P' principalAdjustFactor='' transactionType='ExchTrade' tradeID='2271282877' orderID='1116965776' execID='x.01' brokerageOrderID='22222.123434.111.0001' orderReference='' volatilityOrderLink='' clearingFirmID='' origTradePrice='0' origTradeDate='' origTradeID='' orderTime='20181113;103523' dateTime='20181113;103523' reportDate='20181113' settleDate='20181114' tradeDate='20181113' exchange='NASDAQBX' buySell='SELL' quantity='-1' price='4' amount='-400' proceeds='400' commission='-1.65' brokerExecutionCommission='-1.65' brokerClearingCommission='0' thirdPartyExecutionCommission='0' thirdPartyClearingCommission='0' thirdPartyRegulatoryCommission='0' otherCommission='0' commissionCurrency='USD' tax='0' code='O' orderType='LMT' levelOfDetail='EXECUTION' traderID='C1' isAPIOrder='N' allocatedTo=''/>");
            sb.Append("<TradeConfirm accountId='AccID4711' acctAlias='' model='' currency='USD' assetCategory='OPT' symbol='HIIQ  190118P00040000' description='HIIQ 18JAN19 40.0 P' conid='307182456' securityID='' securityIDType='' cusip='' isin='' listingExchange='' underlyingConid='122012356' underlyingSymbol='HIIQ' underlyingSecurityID='' underlyingListingExchange='NASDAQ' issuer='' multiplier='100' strike='40' expiry='20190118' putCall='P' principalAdjustFactor='' transactionType='ExchTrade' tradeID='2271282877' orderID='1116965777' execID='y.01' brokerageOrderID='443355.5555555.5bea6558.0001' orderReference='' volatilityOrderLink='' clearingFirmID='' origTradePrice='0' origTradeDate='' origTradeID='' orderTime='20181113;103523' dateTime='20181113;103523' reportDate='20181113' settleDate='20181114' tradeDate='20181113' exchange='NASDAQBX' buySell='SELL' quantity='-1' price='4' amount='-400' proceeds='400' commission='-1.65' brokerExecutionCommission='-1.65' brokerClearingCommission='0' thirdPartyExecutionCommission='0' thirdPartyClearingCommission='0' thirdPartyRegulatoryCommission='0' otherCommission='0' commissionCurrency='USD' tax='0' code='O' orderType='LMT' levelOfDetail='EXECUTION' traderID='C1' isAPIOrder='N' allocatedTo=''/>");
            sb.Append("<TradeConfirm accountId='AccID4711' acctAlias='' model='' currency='USD' assetCategory='OPT' symbol='HIIQ  190118P00040000' description='HIIQ 18JAN19 40.0 P' conid='307182456' securityID='' securityIDType='' cusip='' isin='' listingExchange='' underlyingConid='122012356' underlyingSymbol='HIIQ' underlyingSecurityID='' underlyingListingExchange='NASDAQ' issuer='' multiplier='100' strike='40' expiry='20190118' putCall='P' principalAdjustFactor='' transactionType='ExchTrade' tradeID='2271282877' orderID='1116965778' execID='z.a.b.01' brokerageOrderID='233232323.77777.5bea6558.0001' orderReference='' volatilityOrderLink='' clearingFirmID='' origTradePrice='0' origTradeDate='' origTradeID='' orderTime='20181113;103523' dateTime='20181113;103523' reportDate='20181113' settleDate='20181114' tradeDate='20181113' exchange='NASDAQBX' buySell='SELL' quantity='-1' price='4' amount='-400' proceeds='400' commission='-1.65' brokerExecutionCommission='-1.65' brokerClearingCommission='0' thirdPartyExecutionCommission='0' thirdPartyClearingCommission='0' thirdPartyRegulatoryCommission='0' otherCommission='0' commissionCurrency='USD' tax='0' code='O' orderType='LMT' levelOfDetail='EXECUTION' traderID='C1' isAPIOrder='N' allocatedTo=''/>");
            sb.Append("<TradeConfirm accountId='AccID4711' acctAlias='' model='' currency='USD' assetCategory='OPT' symbol='HIIQ  190118P00040000' description='HIIQ 18JAN19 40.0 P' conid='307182456' securityID='' securityIDType='' cusip='' isin='' listingExchange='' underlyingConid='122012356' underlyingSymbol='HIIQ' underlyingSecurityID='' underlyingListingExchange='NASDAQ' issuer='' multiplier='100' strike='40' expiry='20190118' putCall='P' principalAdjustFactor='' transactionType='ExchTrade' tradeID='2271282877' orderID='1116965779' execID='i.j.k.01' brokerageOrderID='878787.00010474.45454.0001' orderReference='' volatilityOrderLink='' clearingFirmID='' origTradePrice='0' origTradeDate='' origTradeID='' orderTime='20181113;103523' dateTime='20181113;103523' reportDate='20181113' settleDate='20181114' tradeDate='20181113' exchange='NASDAQBX' buySell='SELL' quantity='-1' price='4' amount='-400' proceeds='400' commission='-1.65' brokerExecutionCommission='-1.65' brokerClearingCommission='0' thirdPartyExecutionCommission='0' thirdPartyClearingCommission='0' thirdPartyRegulatoryCommission='0' otherCommission='0' commissionCurrency='USD' tax='0' code='O' orderType='LMT' levelOfDetail='EXECUTION' traderID='C1' isAPIOrder='N' allocatedTo=''/>");
            sb.Append("</TradeConfirms>" + XmlEnd);

            string str = sb.ToString();

            var obj = Deserializer.Deserialize<Xml.Contracts.FlexQueryResponse, FlexQueryResponse>(this._streamBuilder.GenerateStreamFromString(str), out var msg);
            var tradeConfirms = obj.FlexStatements.FlexStatement.TradeConfirms.TradeConfirm;
            tradeConfirms.Count.Should().Be(4);
        }

        [Test]
        public void TestTradeConfirms_AccountId()
        {
            var str = XmlStart + @"<TradeConfirms>
            <TradeConfirm accountId='abcdefg' />
            </TradeConfirms>" + XmlEnd;
            var obj = Deserializer.Deserialize<Xml.Contracts.FlexQueryResponse, Contracts.FlexQueryResponse>(this._streamBuilder.GenerateStreamFromString(str), out var msg);
            var tradeConfirms = obj.FlexStatements.FlexStatement.TradeConfirms.TradeConfirm;
            tradeConfirms.Count.Should().Be(1);
            tradeConfirms[0].AccountId.Should().Be("abcdefg");
        }

        [Test]
        public void TestTradeConfirms_AcctAlias()
        {
            var str = XmlStart + @"<TradeConfirms>
            <TradeConfirm acctAlias='alias' />
            </TradeConfirms>" + XmlEnd;
            var obj = Deserializer.Deserialize<Xml.Contracts.FlexQueryResponse, Contracts.FlexQueryResponse>(this._streamBuilder.GenerateStreamFromString(str), out var msg);
            var tradeConfirms = obj.FlexStatements.FlexStatement.TradeConfirms.TradeConfirm;
            tradeConfirms.Count.Should().Be(1);
            tradeConfirms[0].AcctAlias.Should().Be("alias");
        }

        [Test]
        public void TestTradeConfirms_Model()
        {
            var str = XmlStart + @"<TradeConfirms>
            <TradeConfirm model='aModel' />
            </TradeConfirms>" + XmlEnd;
            var obj = Deserializer.Deserialize<Xml.Contracts.FlexQueryResponse, Contracts.FlexQueryResponse>(this._streamBuilder.GenerateStreamFromString(str), out var msg);
            var tradeConfirms = obj.FlexStatements.FlexStatement.TradeConfirms.TradeConfirm;
            tradeConfirms.Count.Should().Be(1);
            tradeConfirms[0].Model.Should().Be("aModel");
        }

        [Test]
        public void TestTradeConfirms_Currency1()
        {
            var str = XmlStart + @"<TradeConfirms>
            <TradeConfirm currency='USD' />
            </TradeConfirms>" + XmlEnd;
            var obj = Deserializer.Deserialize<Xml.Contracts.FlexQueryResponse, Contracts.FlexQueryResponse>(this._streamBuilder.GenerateStreamFromString(str), out var msg);
            var tradeConfirms = obj.FlexStatements.FlexStatement.TradeConfirms.TradeConfirm;
            tradeConfirms.Count.Should().Be(1);
            tradeConfirms[0].Currency.HasValue.Should().Be(true);
            tradeConfirms[0].Currency.Should().Be(Currencies.USD);
        }

        [Test]
        public void TestTradeConfirms_Currency2()
        {
            var str = XmlStart + @"<TradeConfirms>
            <TradeConfirm currency='EUR' />
            </TradeConfirms>" + XmlEnd;
            var obj = Deserializer.Deserialize<Xml.Contracts.FlexQueryResponse, Contracts.FlexQueryResponse>(this._streamBuilder.GenerateStreamFromString(str), out var msg);
            var tradeConfirms = obj.FlexStatements.FlexStatement.TradeConfirms.TradeConfirm;
            tradeConfirms.Count.Should().Be(1);
            tradeConfirms[0].Currency.HasValue.Should().Be(true);
            tradeConfirms[0].Currency.Should().Be(Currencies.EUR);
        }

        [Test]
        public void TestTradeConfirms_Currency3()
        {
            // unknown currency -> error message
            var str = XmlStart + @"<TradeConfirms>
            <TradeConfirm currency='XYZ' />
            </TradeConfirms>" + XmlEnd;
            var obj = Deserializer.Deserialize<Xml.Contracts.FlexQueryResponse, Contracts.FlexQueryResponse>(this._streamBuilder.GenerateStreamFromString(str), out var msg);
            var tradeConfirms = obj.FlexStatements.FlexStatement.TradeConfirms.TradeConfirm;
            tradeConfirms.Count.Should().Be(0);
            msg.Should().NotBeNull();
        }

        [Test]
        public void TestTradeConfirms_AssetCategory1()
        {
            var str = XmlStart + @"<TradeConfirms>
            <TradeConfirm assetCategory='STK' />
            </TradeConfirms>" + XmlEnd;
            var obj = Deserializer.Deserialize<Xml.Contracts.FlexQueryResponse, Contracts.FlexQueryResponse>(this._streamBuilder.GenerateStreamFromString(str), out var msg);
            var tradeConfirms = obj.FlexStatements.FlexStatement.TradeConfirms.TradeConfirm;
            tradeConfirms.Count.Should().Be(1);
            tradeConfirms[0].AssetCategory.Should().Be(AssetCategory.STK);
        }

        [Test]
        public void TestTradeConfirms_AssetCategory2()
        {
            var str = XmlStart + @"<TradeConfirms>
            <TradeConfirm assetCategory='OPT' />
            </TradeConfirms>" + XmlEnd;
            var obj = Deserializer.Deserialize<Xml.Contracts.FlexQueryResponse, Contracts.FlexQueryResponse>(this._streamBuilder.GenerateStreamFromString(str), out var msg);
            var tradeConfirms = obj.FlexStatements.FlexStatement.TradeConfirms.TradeConfirm;
            tradeConfirms.Count.Should().Be(1);
            tradeConfirms[0].AssetCategory.Should().Be(AssetCategory.OPT);
        }

        [Test]
        public void TestTradeConfirms_AssetCategory3()
        {
            var str = XmlStart + @"<TradeConfirms>
            <TradeConfirm assetCategory='unknown' />
            </TradeConfirms>" + XmlEnd;
            var obj = Deserializer.Deserialize<Xml.Contracts.FlexQueryResponse, Contracts.FlexQueryResponse>(this._streamBuilder.GenerateStreamFromString(str), out var msg);
            var tradeConfirms = obj.FlexStatements.FlexStatement.TradeConfirms.TradeConfirm;
            tradeConfirms.Count.Should().Be(0);
            msg.Should().NotBeNull();
        }

        [Test]
        public void TestTradeConfirms_Symbol()
        {
            var str = XmlStart + @"<TradeConfirms>
            <TradeConfirm symbol='KO' />
            </TradeConfirms>" + XmlEnd;
            var obj = Deserializer.Deserialize<Xml.Contracts.FlexQueryResponse, Contracts.FlexQueryResponse>(this._streamBuilder.GenerateStreamFromString(str), out var msg);
            var tradeConfirms = obj.FlexStatements.FlexStatement.TradeConfirms.TradeConfirm;
            tradeConfirms.Count.Should().Be(1);
            tradeConfirms[0].Symbol.Should().Be("KO");
        }

        [Test]
        public void TestTradeConfirms_Description()
        {
            var str = XmlStart + @"<TradeConfirms>
            <TradeConfirm description='COCA-COLA CO/THE' />
            </TradeConfirms>" + XmlEnd;
            var obj = Deserializer.Deserialize<Xml.Contracts.FlexQueryResponse, Contracts.FlexQueryResponse>(this._streamBuilder.GenerateStreamFromString(str), out var msg);
            var tradeConfirms = obj.FlexStatements.FlexStatement.TradeConfirms.TradeConfirm;
            tradeConfirms.Count.Should().Be(1);
            tradeConfirms[0].Description.Should().Be("COCA-COLA CO/THE");
        }

        [Test]
        public void TestTradeConfirms_Conid()
        {
            var str = XmlStart + @"<TradeConfirms>
            <TradeConfirm conid='8894' />
            </TradeConfirms>" + XmlEnd;
            var obj = Deserializer.Deserialize<Xml.Contracts.FlexQueryResponse, Contracts.FlexQueryResponse>(this._streamBuilder.GenerateStreamFromString(str), out var msg);
            var tradeConfirms = obj.FlexStatements.FlexStatement.TradeConfirms.TradeConfirm;
            tradeConfirms.Count.Should().Be(1);
            tradeConfirms[0].Conid.Should().Be(8894);
        }

        [Test]
        public void TestTradeConfirms_SecurityID()
        {
            var str = XmlStart + @"<TradeConfirms>
            <TradeConfirm securityID='secID' />
            </TradeConfirms>" + XmlEnd;
            var obj = Deserializer.Deserialize<Xml.Contracts.FlexQueryResponse, Contracts.FlexQueryResponse>(this._streamBuilder.GenerateStreamFromString(str), out var msg);
            var tradeConfirms = obj.FlexStatements.FlexStatement.TradeConfirms.TradeConfirm;
            tradeConfirms.Count.Should().Be(1);
            tradeConfirms[0].SecurityID.Should().Be("secID");
        }

        [Test]
        public void TestTradeConfirms_SecurityIDType()
        {
            var str = XmlStart + @"<TradeConfirms>
            <TradeConfirm securityIDType='secIDType' />
            </TradeConfirms>" + XmlEnd;
            var obj = Deserializer.Deserialize<Xml.Contracts.FlexQueryResponse, Contracts.FlexQueryResponse>(this._streamBuilder.GenerateStreamFromString(str), out var msg);
            var tradeConfirms = obj.FlexStatements.FlexStatement.TradeConfirms.TradeConfirm;
            tradeConfirms.Count.Should().Be(1);
            tradeConfirms[0].SecurityIDType.Should().Be("secIDType");
        }

        [Test]
        public void TestTradeConfirms_Cusip()
        {
            var str = XmlStart + @"<TradeConfirms>
            <TradeConfirm cusip='cusipStr' />
            </TradeConfirms>" + XmlEnd;
            var obj = Deserializer.Deserialize<Xml.Contracts.FlexQueryResponse, Contracts.FlexQueryResponse>(this._streamBuilder.GenerateStreamFromString(str), out var msg);
            var tradeConfirms = obj.FlexStatements.FlexStatement.TradeConfirms.TradeConfirm;
            tradeConfirms.Count.Should().Be(1);
            tradeConfirms[0].Cusip.Should().Be("cusipStr");
        }

        [Test]
        public void TestTradeConfirms_Isin()
        {
            var str = XmlStart + @"<TradeConfirms>
            <TradeConfirm isin='ii' />
            </TradeConfirms>" + XmlEnd;
            var obj = Deserializer.Deserialize<Xml.Contracts.FlexQueryResponse, Contracts.FlexQueryResponse>(this._streamBuilder.GenerateStreamFromString(str), out var msg);
            var tradeConfirms = obj.FlexStatements.FlexStatement.TradeConfirms.TradeConfirm;
            tradeConfirms.Count.Should().Be(1);
            tradeConfirms[0].Isin.Should().Be("ii");
        }

        [Test]
        public void TestTradeConfirms_ListingExchange()
        {
            var str = XmlStart + @"<TradeConfirms>
            <TradeConfirm listingExchange='ex' />
            </TradeConfirms>" + XmlEnd;
            var obj = Deserializer.Deserialize<Xml.Contracts.FlexQueryResponse, Contracts.FlexQueryResponse>(this._streamBuilder.GenerateStreamFromString(str), out var msg);
            var tradeConfirms = obj.FlexStatements.FlexStatement.TradeConfirms.TradeConfirm;
            tradeConfirms.Count.Should().Be(1);
            tradeConfirms[0].ListingExchange.Should().Be("ex");
        }

        [Test]
        public void TestTradeConfirms_UnderlyingConid()
        {
            var str = XmlStart + @"<TradeConfirms>
            <TradeConfirm underlyingConid='1234' />
            </TradeConfirms>" + XmlEnd;
            var obj = Deserializer.Deserialize<Xml.Contracts.FlexQueryResponse, Contracts.FlexQueryResponse>(this._streamBuilder.GenerateStreamFromString(str), out var msg);
            var tradeConfirms = obj.FlexStatements.FlexStatement.TradeConfirms.TradeConfirm;
            tradeConfirms.Count.Should().Be(1);
            tradeConfirms[0].UnderlyingConid.Should().Be(1234);
        }

        [Test]
        public void TestTradeConfirms_UnderlyingSymbol()
        {
            var str = XmlStart + @"<TradeConfirms>
            <TradeConfirm underlyingSymbol='uSym' />
            </TradeConfirms>" + XmlEnd;
            var obj = Deserializer.Deserialize<Xml.Contracts.FlexQueryResponse, Contracts.FlexQueryResponse>(this._streamBuilder.GenerateStreamFromString(str), out var msg);
            var tradeConfirms = obj.FlexStatements.FlexStatement.TradeConfirms.TradeConfirm;
            tradeConfirms.Count.Should().Be(1);
            tradeConfirms[0].UnderlyingSymbol.Should().Be("uSym");
        }

        [Test]
        public void TestTradeConfirms_UnderlyingSecurityID()
        {
            var str = XmlStart + @"<TradeConfirms>
            <TradeConfirm underlyingSecurityID='usecID' />
            </TradeConfirms>" + XmlEnd;
            var obj = Deserializer.Deserialize<Xml.Contracts.FlexQueryResponse, Contracts.FlexQueryResponse>(this._streamBuilder.GenerateStreamFromString(str), out var msg);
            var tradeConfirms = obj.FlexStatements.FlexStatement.TradeConfirms.TradeConfirm;
            tradeConfirms.Count.Should().Be(1);
            tradeConfirms[0].UnderlyingSecurityID.Should().Be("usecID");
        }

        [Test]
        public void TestTradeConfirms_UnderlyingListingExchange()
        {
            var str = XmlStart + @"<TradeConfirms>
            <TradeConfirm underlyingListingExchange='ulEx' />
            </TradeConfirms>" + XmlEnd;
            var obj = Deserializer.Deserialize<Xml.Contracts.FlexQueryResponse, Contracts.FlexQueryResponse>(this._streamBuilder.GenerateStreamFromString(str), out var msg);
            var tradeConfirms = obj.FlexStatements.FlexStatement.TradeConfirms.TradeConfirm;
            tradeConfirms.Count.Should().Be(1);
            tradeConfirms[0].UnderlyingListingExchange.Should().Be("ulEx");
        }

        [Test]
        public void TestTradeConfirms_Issuer()
        {
            var str = XmlStart + @"<TradeConfirms>
            <TradeConfirm issuer='issuerTxt' />
            </TradeConfirms>" + XmlEnd;
            var obj = Deserializer.Deserialize<Xml.Contracts.FlexQueryResponse, Contracts.FlexQueryResponse>(this._streamBuilder.GenerateStreamFromString(str), out var msg);
            var tradeConfirms = obj.FlexStatements.FlexStatement.TradeConfirms.TradeConfirm;
            tradeConfirms.Count.Should().Be(1);
            tradeConfirms[0].Issuer.Should().Be("issuerTxt");
        }

        [Test]
        public void TestTradeConfirms_Multiplier1()
        {
            var str = XmlStart + @"<TradeConfirms>
            <TradeConfirm multiplier='101' />
            </TradeConfirms>" + XmlEnd;
            var obj = Deserializer.Deserialize<Xml.Contracts.FlexQueryResponse, Contracts.FlexQueryResponse>(this._streamBuilder.GenerateStreamFromString(str), out var msg);
            var tradeConfirms = obj.FlexStatements.FlexStatement.TradeConfirms.TradeConfirm;
            tradeConfirms.Count.Should().Be(1);
            tradeConfirms[0].Multiplier.Should().Be(101);
        }

        [Test]
        public void TestTradeConfirms_Multiplier2()
        {
            var str = XmlStart + @"<TradeConfirms>
            <TradeConfirm multiplier='' />
            </TradeConfirms>" + XmlEnd;
            var obj = Deserializer.Deserialize<Xml.Contracts.FlexQueryResponse, Contracts.FlexQueryResponse>(this._streamBuilder.GenerateStreamFromString(str), out var msg);
            var tradeConfirms = obj.FlexStatements.FlexStatement.TradeConfirms.TradeConfirm;
            tradeConfirms.Count.Should().Be(1);
            tradeConfirms[0].Multiplier.Should().BeNull();
        }

        [Test]
        public void TestTradeConfirms_Multiplier3()
        {
            var str = XmlStart + @"<TradeConfirms>
            <TradeConfirm multiplier='abc' />
            </TradeConfirms>" + XmlEnd;
            var obj = Deserializer.Deserialize<Xml.Contracts.FlexQueryResponse, Contracts.FlexQueryResponse>(this._streamBuilder.GenerateStreamFromString(str), out var msg);
            var tradeConfirms = obj.FlexStatements.FlexStatement.TradeConfirms.TradeConfirm;
            tradeConfirms.Count.Should().Be(0);
            msg.Should().NotBeNull();
        }

        [Test]
        public void TestTradeConfirms_Strike1()
        {
            var str = XmlStart + @"<TradeConfirms>
            <TradeConfirm strike='10.1' />
            </TradeConfirms>" + XmlEnd;
            var obj = Deserializer.Deserialize<Xml.Contracts.FlexQueryResponse, Contracts.FlexQueryResponse>(this._streamBuilder.GenerateStreamFromString(str), out var msg);
            var tradeConfirms = obj.FlexStatements.FlexStatement.TradeConfirms.TradeConfirm;
            tradeConfirms.Count.Should().Be(1);
            tradeConfirms[0].Strike.Should().Be(10.1);
        }

        [Test]
        public void TestTradeConfirms_Strike2()
        {
            var str = XmlStart + @"<TradeConfirms>
            <TradeConfirm strike='' />
            </TradeConfirms>" + XmlEnd;
            var obj = Deserializer.Deserialize<Xml.Contracts.FlexQueryResponse, Contracts.FlexQueryResponse>(this._streamBuilder.GenerateStreamFromString(str), out var msg);
            var tradeConfirms = obj.FlexStatements.FlexStatement.TradeConfirms.TradeConfirm;
            tradeConfirms.Count.Should().Be(1);
            tradeConfirms[0].Strike.Should().BeNull();
        }

        [Test]
        public void TestTradeConfirms_Strike3()
        {
            var str = XmlStart + @"<TradeConfirms>
            <TradeConfirm strike='abc' />
            </TradeConfirms>" + XmlEnd;
            var obj = Deserializer.Deserialize<Xml.Contracts.FlexQueryResponse, Contracts.FlexQueryResponse>(this._streamBuilder.GenerateStreamFromString(str), out var msg);
            var tradeConfirms = obj.FlexStatements.FlexStatement.TradeConfirms.TradeConfirm;
            tradeConfirms.Count.Should().Be(0);
            msg.Should().NotBeNull();
        }

        [Test]
        public void TestTradeConfirms_Expiry1()
        {
            var str = XmlStart + @"<TradeConfirms>
            <TradeConfirm expiry='20181116' />
            </TradeConfirms>" + XmlEnd;
            var obj = Deserializer.Deserialize<Xml.Contracts.FlexQueryResponse, Contracts.FlexQueryResponse>(this._streamBuilder.GenerateStreamFromString(str), out var msg);
            var tradeConfirms = obj.FlexStatements.FlexStatement.TradeConfirms.TradeConfirm;
            tradeConfirms.Count.Should().Be(1);
            tradeConfirms[0].Expiry.Should().Be(new DateTime(2018, 11, 16));
        }

        [Test]
        public void TestTradeConfirms_Expiry2()
        {
            var str = XmlStart + @"<TradeConfirms>
            <TradeConfirm expiry='' />
            </TradeConfirms>" + XmlEnd;
            var obj = Deserializer.Deserialize<Xml.Contracts.FlexQueryResponse, Contracts.FlexQueryResponse>(this._streamBuilder.GenerateStreamFromString(str), out var msg);
            var tradeConfirms = obj.FlexStatements.FlexStatement.TradeConfirms.TradeConfirm;
            tradeConfirms.Count.Should().Be(1);
            tradeConfirms[0].Expiry.Should().BeNull();
        }

        [Test]
        public void TestTradeConfirms_Expiry3()
        {
            var str = XmlStart + @"<TradeConfirms>
            <TradeConfirm expiry='dasda' />
            </TradeConfirms>" + XmlEnd;
            var obj = Deserializer.Deserialize<Xml.Contracts.FlexQueryResponse, Contracts.FlexQueryResponse>(this._streamBuilder.GenerateStreamFromString(str), out var msg);
            var tradeConfirms = obj.FlexStatements.FlexStatement.TradeConfirms.TradeConfirm;
            tradeConfirms.Count.Should().Be(0);
            msg.Should().NotBeNull();
        }

        [Test]
        public void TestTradeConfirms_PutCall1()
        {
            var str = XmlStart + @"<TradeConfirms>
            <TradeConfirm putCall='P' />
            </TradeConfirms>" + XmlEnd;
            var obj = Deserializer.Deserialize<Xml.Contracts.FlexQueryResponse, Contracts.FlexQueryResponse>(this._streamBuilder.GenerateStreamFromString(str), out var msg);
            var tradeConfirms = obj.FlexStatements.FlexStatement.TradeConfirms.TradeConfirm;
            tradeConfirms.Count.Should().Be(1);
            tradeConfirms[0].PutCall.Should().Be(PutCall.P);
        }

        [Test]
        public void TestTradeConfirms_PutCall2()
        {
            var str = XmlStart + @"<TradeConfirms>
            <TradeConfirm putCall='C' />
            </TradeConfirms>" + XmlEnd;
            var obj = Deserializer.Deserialize<Xml.Contracts.FlexQueryResponse, Contracts.FlexQueryResponse>(this._streamBuilder.GenerateStreamFromString(str), out var msg);
            var tradeConfirms = obj.FlexStatements.FlexStatement.TradeConfirms.TradeConfirm;
            tradeConfirms.Count.Should().Be(1);
            tradeConfirms[0].PutCall.Should().Be(PutCall.C);
        }

        [Test]
        public void TestTradeConfirms_PutCall3()
        {
            var str = XmlStart + @"<TradeConfirms>
            <TradeConfirm putCall='' />
            </TradeConfirms>" + XmlEnd;
            var obj = Deserializer.Deserialize<Xml.Contracts.FlexQueryResponse, Contracts.FlexQueryResponse>(this._streamBuilder.GenerateStreamFromString(str), out var msg);
            var tradeConfirms = obj.FlexStatements.FlexStatement.TradeConfirms.TradeConfirm;
            tradeConfirms.Count.Should().Be(1);
            tradeConfirms[0].PutCall.Should().BeNull();
        }

        [Test]
        public void TestTradeConfirms_PutCall4()
        {
            var str = XmlStart + @"<TradeConfirms>
            <TradeConfirm putCall='sfdf' />
            </TradeConfirms>" + XmlEnd;
            var obj = Deserializer.Deserialize<Xml.Contracts.FlexQueryResponse, Contracts.FlexQueryResponse>(this._streamBuilder.GenerateStreamFromString(str), out var msg);
            var tradeConfirms = obj.FlexStatements.FlexStatement.TradeConfirms.TradeConfirm;
            tradeConfirms.Count.Should().Be(0);
            msg.Should().NotBeNull();
        }

        [Test]
        public void TestTradeConfirms_PrincipalAdjustFactor()
        {
            var str = XmlStart + @"<TradeConfirms>
            <TradeConfirm principalAdjustFactor='paf' />
            </TradeConfirms>" + XmlEnd;
            var obj = Deserializer.Deserialize<Xml.Contracts.FlexQueryResponse, Contracts.FlexQueryResponse>(this._streamBuilder.GenerateStreamFromString(str), out var msg);
            var tradeConfirms = obj.FlexStatements.FlexStatement.TradeConfirms.TradeConfirm;
            tradeConfirms.Count.Should().Be(1);
            tradeConfirms[0].PrincipalAdjustFactor.Should().Be("paf");
        }

        [Test]
        public void TestTradeConfirms_TransactionType()
        {
            var str = XmlStart + @"<TradeConfirms>
            <TradeConfirm transactionType='BookTrade' />
            </TradeConfirms>" + XmlEnd;
            var obj = Deserializer.Deserialize<Xml.Contracts.FlexQueryResponse, Contracts.FlexQueryResponse>(this._streamBuilder.GenerateStreamFromString(str), out var msg);
            var tradeConfirms = obj.FlexStatements.FlexStatement.TradeConfirms.TradeConfirm;
            tradeConfirms.Count.Should().Be(1);
            tradeConfirms[0].TransactionType.Should().Be("BookTrade");
        }

        [Test]
        public void TestTradeConfirms_TradeID()
        {
            var str = XmlStart + @"<TradeConfirms>
            <TradeConfirm tradeID='2276360777' />
            </TradeConfirms>" + XmlEnd;
            var obj = Deserializer.Deserialize<Xml.Contracts.FlexQueryResponse, Contracts.FlexQueryResponse>(this._streamBuilder.GenerateStreamFromString(str), out var msg);
            var tradeConfirms = obj.FlexStatements.FlexStatement.TradeConfirms.TradeConfirm;
            tradeConfirms.Count.Should().Be(1);
            tradeConfirms[0].TradeID.Should().Be(2276360777);
        }

        [Test]
        public void TestTradeConfirms_OrderID()
        {
            var str = XmlStart + @"<TradeConfirms>
            <TradeConfirm orderID='9857779816' />
            </TradeConfirms>" + XmlEnd;
            var obj = Deserializer.Deserialize<Xml.Contracts.FlexQueryResponse, Contracts.FlexQueryResponse>(this._streamBuilder.GenerateStreamFromString(str), out var msg);
            var tradeConfirms = obj.FlexStatements.FlexStatement.TradeConfirms.TradeConfirm;
            tradeConfirms.Count.Should().Be(1);
            tradeConfirms[0].OrderID.Should().Be(9857779816);
        }

        [Test]
        public void TestTradeConfirms_ExecID()
        {
            var str = XmlStart + @"<TradeConfirms>
            <TradeConfirm execID='exec' />
            </TradeConfirms>" + XmlEnd;
            var obj = Deserializer.Deserialize<Xml.Contracts.FlexQueryResponse, Contracts.FlexQueryResponse>(this._streamBuilder.GenerateStreamFromString(str), out var msg);
            var tradeConfirms = obj.FlexStatements.FlexStatement.TradeConfirms.TradeConfirm;
            tradeConfirms.Count.Should().Be(1);
            tradeConfirms[0].ExecID.Should().Be("exec");
        }

        [Test]
        public void TestTradeConfirms_BrokerageOrderID()
        {
            var str = XmlStart + @"<TradeConfirms>
            <TradeConfirm brokerageOrderID='boID' />
            </TradeConfirms>" + XmlEnd;
            var obj = Deserializer.Deserialize<Xml.Contracts.FlexQueryResponse, Contracts.FlexQueryResponse>(this._streamBuilder.GenerateStreamFromString(str), out var msg);
            var tradeConfirms = obj.FlexStatements.FlexStatement.TradeConfirms.TradeConfirm;
            tradeConfirms.Count.Should().Be(1);
            tradeConfirms[0].BrokerageOrderID.Should().Be("boID");
        }

        [Test]
        public void TestTradeConfirms_OrderReference()
        {
            var str = XmlStart + @"<TradeConfirms>
            <TradeConfirm orderReference='oRef' />
            </TradeConfirms>" + XmlEnd;
            var obj = Deserializer.Deserialize<Xml.Contracts.FlexQueryResponse, Contracts.FlexQueryResponse>(this._streamBuilder.GenerateStreamFromString(str), out var msg);
            var tradeConfirms = obj.FlexStatements.FlexStatement.TradeConfirms.TradeConfirm;
            tradeConfirms.Count.Should().Be(1);
            tradeConfirms[0].OrderReference.Should().Be("oRef");
        }

        [Test]
        public void TestTradeConfirms_VolatilityOrderLink()
        {
            var str = XmlStart + @"<TradeConfirms>
            <TradeConfirm volatilityOrderLink='voLink' />
            </TradeConfirms>" + XmlEnd;
            var obj = Deserializer.Deserialize<Xml.Contracts.FlexQueryResponse, Contracts.FlexQueryResponse>(this._streamBuilder.GenerateStreamFromString(str), out var msg);
            var tradeConfirms = obj.FlexStatements.FlexStatement.TradeConfirms.TradeConfirm;
            tradeConfirms.Count.Should().Be(1);
            tradeConfirms[0].VolatilityOrderLink.Should().Be("voLink");
        }

        [Test]
        public void TestTradeConfirms_ClearingFirmID()
        {
            var str = XmlStart + @"<TradeConfirms>
            <TradeConfirm clearingFirmID='cfID' />
            </TradeConfirms>" + XmlEnd;
            var obj = Deserializer.Deserialize<Xml.Contracts.FlexQueryResponse, Contracts.FlexQueryResponse>(this._streamBuilder.GenerateStreamFromString(str), out var msg);
            var tradeConfirms = obj.FlexStatements.FlexStatement.TradeConfirms.TradeConfirm;
            tradeConfirms.Count.Should().Be(1);
            tradeConfirms[0].ClearingFirmID.Should().Be("cfID");
        }

        [Test]
        public void TestTradeConfirms_OrigTradePrice()
        {
            var str = XmlStart + @"<TradeConfirms>
            <TradeConfirm origTradePrice='1.23' />
            </TradeConfirms>" + XmlEnd;
            var obj = Deserializer.Deserialize<Xml.Contracts.FlexQueryResponse, Contracts.FlexQueryResponse>(this._streamBuilder.GenerateStreamFromString(str), out var msg);
            var tradeConfirms = obj.FlexStatements.FlexStatement.TradeConfirms.TradeConfirm;
            tradeConfirms.Count.Should().Be(1);
            tradeConfirms[0].OrigTradePrice.Should().Be(1.23);
        }

        [Test]
        public void TestTradeConfirms_OrigTradeDate()
        {
            var str = XmlStart + @"<TradeConfirms>
            <TradeConfirm origTradeDate='20181231' />
            </TradeConfirms>" + XmlEnd;
            var obj = Deserializer.Deserialize<Xml.Contracts.FlexQueryResponse, Contracts.FlexQueryResponse>(this._streamBuilder.GenerateStreamFromString(str), out var msg);
            var tradeConfirms = obj.FlexStatements.FlexStatement.TradeConfirms.TradeConfirm;
            tradeConfirms.Count.Should().Be(1);
            tradeConfirms[0].OrigTradeDate.Should().Be(new DateTime(2018, 12, 31));
        }

        [Test]
        public void TestTradeConfirms_OrigTradeID()
        {
            var str = XmlStart + @"<TradeConfirms>
            <TradeConfirm origTradeID='12345678' />
            </TradeConfirms>" + XmlEnd;
            var obj = Deserializer.Deserialize<Xml.Contracts.FlexQueryResponse, Contracts.FlexQueryResponse>(this._streamBuilder.GenerateStreamFromString(str), out var msg);
            var tradeConfirms = obj.FlexStatements.FlexStatement.TradeConfirms.TradeConfirm;
            tradeConfirms.Count.Should().Be(1);
            tradeConfirms[0].OrigTradeID.Should().Be(12345678);
        }

        [Test]
        public void TestTradeConfirms_OrderTime()
        {
            var str = XmlStart + @"<TradeConfirms>
            <TradeConfirm orderTime='20181231;162001' />
            </TradeConfirms>" + XmlEnd;
            var obj = Deserializer.Deserialize<Xml.Contracts.FlexQueryResponse, Contracts.FlexQueryResponse>(this._streamBuilder.GenerateStreamFromString(str), out var msg);
            var tradeConfirms = obj.FlexStatements.FlexStatement.TradeConfirms.TradeConfirm;
            tradeConfirms.Count.Should().Be(1);
            tradeConfirms[0].OrderTime.Should().Be(new DateTime(2018, 12, 31, 16, 20, 01));
        }

        [Test]
        public void TestTradeConfirms_DateTime()
        {
            var str = XmlStart + @"<TradeConfirms>
            <TradeConfirm dateTime='20181230;172001' />
            </TradeConfirms>" + XmlEnd;
            var obj = Deserializer.Deserialize<Xml.Contracts.FlexQueryResponse, Contracts.FlexQueryResponse>(this._streamBuilder.GenerateStreamFromString(str), out var msg);
            var tradeConfirms = obj.FlexStatements.FlexStatement.TradeConfirms.TradeConfirm;
            tradeConfirms.Count.Should().Be(1);
            tradeConfirms[0].DateTime.Should().Be(new DateTime(2018, 12, 30, 17, 20, 01));
        }

        [Test]
        public void TestTradeConfirms_ReportDate()
        {
            var str = XmlStart + @"<TradeConfirms>
            <TradeConfirm reportDate='20181230' />
            </TradeConfirms>" + XmlEnd;
            var obj = Deserializer.Deserialize<Xml.Contracts.FlexQueryResponse, Contracts.FlexQueryResponse>(this._streamBuilder.GenerateStreamFromString(str), out var msg);
            var tradeConfirms = obj.FlexStatements.FlexStatement.TradeConfirms.TradeConfirm;
            tradeConfirms.Count.Should().Be(1);
            tradeConfirms[0].ReportDate.Should().Be(new DateTime(2018, 12, 30));
        }

        [Test]
        public void TestTradeConfirms_SettleDate()
        {
            var str = XmlStart + @"<TradeConfirms>
            <TradeConfirm settleDate='20181120' />
            </TradeConfirms>" + XmlEnd;
            var obj = Deserializer.Deserialize<Xml.Contracts.FlexQueryResponse, Contracts.FlexQueryResponse>(this._streamBuilder.GenerateStreamFromString(str), out var msg);
            var tradeConfirms = obj.FlexStatements.FlexStatement.TradeConfirms.TradeConfirm;
            tradeConfirms.Count.Should().Be(1);
            tradeConfirms[0].SettleDate.Should().Be(new DateTime(2018, 11, 20));
        }

        [Test]
        public void TestTradeConfirms_TradeDate()
        {
            var str = XmlStart + @"<TradeConfirms>
            <TradeConfirm tradeDate='20181223' />
            </TradeConfirms>" + XmlEnd;
            var obj = Deserializer.Deserialize<Xml.Contracts.FlexQueryResponse, Contracts.FlexQueryResponse>(this._streamBuilder.GenerateStreamFromString(str), out var msg);
            var tradeConfirms = obj.FlexStatements.FlexStatement.TradeConfirms.TradeConfirm;
            tradeConfirms.Count.Should().Be(1);
            tradeConfirms[0].TradeDate.Should().Be(new DateTime(2018, 12, 23));
        }

        [Test]
        public void TestTradeConfirms_Exchange()
        {
            var str = XmlStart + @"<TradeConfirms>
            <TradeConfirm exchange='--' />
            </TradeConfirms>" + XmlEnd;
            var obj = Deserializer.Deserialize<Xml.Contracts.FlexQueryResponse, Contracts.FlexQueryResponse>(this._streamBuilder.GenerateStreamFromString(str), out var msg);
            var tradeConfirms = obj.FlexStatements.FlexStatement.TradeConfirms.TradeConfirm;
            tradeConfirms.Count.Should().Be(1);
            tradeConfirms[0].Exchange.Should().Be("--");
        }

        [Test]
        public void TestTradeConfirms_BuySell()
        {
            var str = XmlStart + @"<TradeConfirms>
            <TradeConfirm buySell='SELL' />
            </TradeConfirms>" + XmlEnd;
            var obj = Deserializer.Deserialize<Xml.Contracts.FlexQueryResponse, Contracts.FlexQueryResponse>(this._streamBuilder.GenerateStreamFromString(str), out var msg);
            var tradeConfirms = obj.FlexStatements.FlexStatement.TradeConfirms.TradeConfirm;
            tradeConfirms.Count.Should().Be(1);
            tradeConfirms[0].BuySell.Should().Be(BuySell.SELL);
        }

        [Test]
        public void TestTradeConfirms_Quantity()
        {
            var str = XmlStart + @"<TradeConfirms>
            <TradeConfirm quantity='-100' />
            </TradeConfirms>" + XmlEnd;
            var obj = Deserializer.Deserialize<Xml.Contracts.FlexQueryResponse, Contracts.FlexQueryResponse>(this._streamBuilder.GenerateStreamFromString(str), out var msg);
            var tradeConfirms = obj.FlexStatements.FlexStatement.TradeConfirms.TradeConfirm;
            tradeConfirms.Count.Should().Be(1);
            tradeConfirms[0].Quantity.Should().Be(-100);
        }

        [Test]
        public void TestTradeConfirms_Price()
        {
            var str = XmlStart + @"<TradeConfirms>
            <TradeConfirm price='46.123' />
            </TradeConfirms>" + XmlEnd;
            var obj = Deserializer.Deserialize<Xml.Contracts.FlexQueryResponse, Contracts.FlexQueryResponse>(this._streamBuilder.GenerateStreamFromString(str), out var msg);
            var tradeConfirms = obj.FlexStatements.FlexStatement.TradeConfirms.TradeConfirm;
            tradeConfirms.Count.Should().Be(1);
            tradeConfirms[0].Price.Should().Be(46.123);
        }

        [Test]
        public void TestTradeConfirms_Amount()
        {
            var str = XmlStart + @"<TradeConfirms>
            <TradeConfirm amount='-123.456' />
            </TradeConfirms>" + XmlEnd;
            var obj = Deserializer.Deserialize<Xml.Contracts.FlexQueryResponse, Contracts.FlexQueryResponse>(this._streamBuilder.GenerateStreamFromString(str), out var msg);
            var tradeConfirms = obj.FlexStatements.FlexStatement.TradeConfirms.TradeConfirm;
            tradeConfirms.Count.Should().Be(1);
            tradeConfirms[0].Amount.Should().Be(-123.456);
        }

        [Test]
        public void TestTradeConfirms_Proceeds()
        {
            var str = XmlStart + @"<TradeConfirms>
            <TradeConfirm proceeds='-123.654' />
            </TradeConfirms>" + XmlEnd;
            var obj = Deserializer.Deserialize<Xml.Contracts.FlexQueryResponse, Contracts.FlexQueryResponse>(this._streamBuilder.GenerateStreamFromString(str), out var msg);
            var tradeConfirms = obj.FlexStatements.FlexStatement.TradeConfirms.TradeConfirm;
            tradeConfirms.Count.Should().Be(1);
            tradeConfirms[0].Proceeds.Should().Be(-123.654);
        }

        [Test]
        public void TestTradeConfirms_Commission()
        {
            var str = XmlStart + @"<TradeConfirms>
            <TradeConfirm commission='-0.0717' />
            </TradeConfirms>" + XmlEnd;
            var obj = Deserializer.Deserialize<Xml.Contracts.FlexQueryResponse, Contracts.FlexQueryResponse>(this._streamBuilder.GenerateStreamFromString(str), out var msg);
            var tradeConfirms = obj.FlexStatements.FlexStatement.TradeConfirms.TradeConfirm;
            tradeConfirms.Count.Should().Be(1);
            tradeConfirms[0].Commission.Should().Be(-0.0717);
        }

        [Test]
        public void TestTradeConfirms_BrokerExecutionCommission()
        {
            var str = XmlStart + @"<TradeConfirms>
            <TradeConfirm brokerExecutionCommission='0.0717' />
            </TradeConfirms>" + XmlEnd;
            var obj = Deserializer.Deserialize<Xml.Contracts.FlexQueryResponse, Contracts.FlexQueryResponse>(this._streamBuilder.GenerateStreamFromString(str), out var msg);
            var tradeConfirms = obj.FlexStatements.FlexStatement.TradeConfirms.TradeConfirm;
            tradeConfirms.Count.Should().Be(1);
            tradeConfirms[0].BrokerExecutionCommission.Should().Be(0.0717);
        }

        [Test]
        public void TestTradeConfirms_BrokerClearingCommission()
        {
            var str = XmlStart + @"<TradeConfirms>
            <TradeConfirm brokerClearingCommission='1.0717' />
            </TradeConfirms>" + XmlEnd;
            var obj = Deserializer.Deserialize<Xml.Contracts.FlexQueryResponse, Contracts.FlexQueryResponse>(this._streamBuilder.GenerateStreamFromString(str), out var msg);
            var tradeConfirms = obj.FlexStatements.FlexStatement.TradeConfirms.TradeConfirm;
            tradeConfirms.Count.Should().Be(1);
            tradeConfirms[0].BrokerClearingCommission.Should().Be(1.0717);
        }

        [Test]
        public void TestTradeConfirms_ThirdPartyExecutionCommission()
        {
            var str = XmlStart + @"<TradeConfirms>
            <TradeConfirm thirdPartyExecutionCommission='-1.0717' />
            </TradeConfirms>" + XmlEnd;
            var obj = Deserializer.Deserialize<Xml.Contracts.FlexQueryResponse, Contracts.FlexQueryResponse>(this._streamBuilder.GenerateStreamFromString(str), out var msg);
            var tradeConfirms = obj.FlexStatements.FlexStatement.TradeConfirms.TradeConfirm;
            tradeConfirms.Count.Should().Be(1);
            tradeConfirms[0].ThirdPartyExecutionCommission.Should().Be(-1.0717);
        }

        [Test]
        public void TestTradeConfirms_ThirdPartyClearingCommission()
        {
            var str = XmlStart + @"<TradeConfirms>
            <TradeConfirm thirdPartyClearingCommission='-33.456' />
            </TradeConfirms>" + XmlEnd;
            var obj = Deserializer.Deserialize<Xml.Contracts.FlexQueryResponse, Contracts.FlexQueryResponse>(this._streamBuilder.GenerateStreamFromString(str), out var msg);
            var tradeConfirms = obj.FlexStatements.FlexStatement.TradeConfirms.TradeConfirm;
            tradeConfirms.Count.Should().Be(1);
            tradeConfirms[0].ThirdPartyClearingCommission.Should().Be(-33.456);
        }

        [Test]
        public void TestTradeConfirms_ThirdPartyRegulatoryCommission()
        {
            var str = XmlStart + @"<TradeConfirms>
            <TradeConfirm thirdPartyRegulatoryCommission='33.456' />
            </TradeConfirms>" + XmlEnd;
            var obj = Deserializer.Deserialize<Xml.Contracts.FlexQueryResponse, Contracts.FlexQueryResponse>(this._streamBuilder.GenerateStreamFromString(str), out var msg);
            var tradeConfirms = obj.FlexStatements.FlexStatement.TradeConfirms.TradeConfirm;
            tradeConfirms.Count.Should().Be(1);
            tradeConfirms[0].ThirdPartyRegulatoryCommission.Should().Be(33.456);
        }

        [Test]
        public void TestTradeConfirms_OtherCommission()
        {
            var str = XmlStart + @"<TradeConfirms>
            <TradeConfirm otherCommission='12.456' />
            </TradeConfirms>" + XmlEnd;
            var obj = Deserializer.Deserialize<Xml.Contracts.FlexQueryResponse, Contracts.FlexQueryResponse>(this._streamBuilder.GenerateStreamFromString(str), out var msg);
            var tradeConfirms = obj.FlexStatements.FlexStatement.TradeConfirms.TradeConfirm;
            tradeConfirms.Count.Should().Be(1);
            tradeConfirms[0].OtherCommission.Should().Be(12.456);
        }

        [Test]
        public void TestTradeConfirms_CommissionCurrency()
        {
            var str = XmlStart + @"<TradeConfirms>
            <TradeConfirm commissionCurrency='EUR' />
            </TradeConfirms>" + XmlEnd;
            var obj = Deserializer.Deserialize<Xml.Contracts.FlexQueryResponse, Contracts.FlexQueryResponse>(this._streamBuilder.GenerateStreamFromString(str), out var msg);
            var tradeConfirms = obj.FlexStatements.FlexStatement.TradeConfirms.TradeConfirm;
            tradeConfirms.Count.Should().Be(1);
            tradeConfirms[0].CommissionCurrency.Should().Be(Currencies.EUR);
        }

        [Test]
        public void TestTradeConfirms_Tax()
        {
            var str = XmlStart + @"<TradeConfirms>
            <TradeConfirm tax='432.765' />
            </TradeConfirms>" + XmlEnd;
            var obj = Deserializer.Deserialize<Xml.Contracts.FlexQueryResponse, Contracts.FlexQueryResponse>(this._streamBuilder.GenerateStreamFromString(str), out var msg);
            var tradeConfirms = obj.FlexStatements.FlexStatement.TradeConfirms.TradeConfirm;
            tradeConfirms.Count.Should().Be(1);
            tradeConfirms[0].Tax.Should().Be(432.765);
        }

        [Test]
        public void TestTradeConfirms_Code1()
        {
            var str = XmlStart + @"<TradeConfirms>
            <TradeConfirm code='A' />
            </TradeConfirms>" + XmlEnd;
            var obj = Deserializer.Deserialize<Xml.Contracts.FlexQueryResponse, Contracts.FlexQueryResponse>(this._streamBuilder.GenerateStreamFromString(str), out var msg);
            var tradeConfirms = obj.FlexStatements.FlexStatement.TradeConfirms.TradeConfirm;
            tradeConfirms.Count.Should().Be(1);
            tradeConfirms[0].Code.Should().Be(Notes.Assigned);
            tradeConfirms[0].Code.Should().HaveFlag(Notes.Assigned);
        }

        [Test]
        public void TestTradeConfirms_Code2()
        {
            var str = XmlStart + @"<TradeConfirms>
            <TradeConfirm code='O' />
            </TradeConfirms>" + XmlEnd;
            var obj = Deserializer.Deserialize<Xml.Contracts.FlexQueryResponse, Contracts.FlexQueryResponse>(this._streamBuilder.GenerateStreamFromString(str), out var msg);
            var tradeConfirms = obj.FlexStatements.FlexStatement.TradeConfirms.TradeConfirm;
            tradeConfirms.Count.Should().Be(1);
            tradeConfirms[0].Code.Should().Be(Notes.OpeningTrade);
            tradeConfirms[0].Code.Should().HaveFlag(Notes.OpeningTrade);
        }

        [Test]
        public void TestTradeConfirms_Code3()
        {
            var str = XmlStart + @"<TradeConfirms>
            <TradeConfirm code='unknown' />
            </TradeConfirms>" + XmlEnd;
            var obj = Deserializer.Deserialize<Xml.Contracts.FlexQueryResponse, Contracts.FlexQueryResponse>(this._streamBuilder.GenerateStreamFromString(str), out var msg);
            var tradeConfirms = obj.FlexStatements.FlexStatement.TradeConfirms.TradeConfirm;
            tradeConfirms.Count.Should().Be(0);
            msg.Should().NotBeNull();
        }

        [Test]
        public void TestTradeConfirms_Code5()
        {
            var str = XmlStart + @"<TradeConfirms>
            <TradeConfirm code='C;AEx;T' />
            </TradeConfirms>" + XmlEnd;
            var obj = Deserializer.Deserialize<Xml.Contracts.FlexQueryResponse, Contracts.FlexQueryResponse>(this._streamBuilder.GenerateStreamFromString(str), out var msg);
            var tradeConfirms = obj.FlexStatements.FlexStatement.TradeConfirms.TradeConfirm;
            tradeConfirms.Count.Should().Be(1);
            tradeConfirms[0].Code.Should().HaveFlag(Notes.ClosingTrade);
            tradeConfirms[0].Code.Should().HaveFlag(Notes.AutomaticalExercise);
            tradeConfirms[0].Code.Should().HaveFlag(Notes.Transfer);
        }

        [Test]
        public void TestTradeConfirms_OrderType()
        {
            var str = XmlStart + @"<TradeConfirms>
            <TradeConfirm orderType='oTyp' />
            </TradeConfirms>" + XmlEnd;
            var obj = Deserializer.Deserialize<Xml.Contracts.FlexQueryResponse, Contracts.FlexQueryResponse>(this._streamBuilder.GenerateStreamFromString(str), out var msg);
            var tradeConfirms = obj.FlexStatements.FlexStatement.TradeConfirms.TradeConfirm;
            tradeConfirms.Count.Should().Be(1);
            tradeConfirms[0].OrderType.Should().Be("oTyp");
        }

        [Test]
        public void TestTradeConfirms_LevelOfDetail()
        {
            var str = XmlStart + @"<TradeConfirms>
            <TradeConfirm levelOfDetail='EXECUTION' />
            </TradeConfirms>" + XmlEnd;
            var obj = Deserializer.Deserialize<Xml.Contracts.FlexQueryResponse, Contracts.FlexQueryResponse>(this._streamBuilder.GenerateStreamFromString(str), out var msg);
            var tradeConfirms = obj.FlexStatements.FlexStatement.TradeConfirms.TradeConfirm;
            tradeConfirms.Count.Should().Be(1);
            tradeConfirms[0].LevelOfDetail.Should().Be("EXECUTION");
        }

        [Test]
        public void TestTradeConfirms_TraderID()
        {
            var str = XmlStart + @"<TradeConfirms>
            <TradeConfirm traderID='trID' />
            </TradeConfirms>" + XmlEnd;
            var obj = Deserializer.Deserialize<Xml.Contracts.FlexQueryResponse, Contracts.FlexQueryResponse>(this._streamBuilder.GenerateStreamFromString(str), out var msg);
            var tradeConfirms = obj.FlexStatements.FlexStatement.TradeConfirms.TradeConfirm;
            tradeConfirms.Count.Should().Be(1);
            tradeConfirms[0].TraderID.Should().Be("trID");
        }

        [Test]
        public void TestTradeConfirms_IsAPIOrder()
        {
            var str = XmlStart + @"<TradeConfirms>
            <TradeConfirm isAPIOrder='N' />
            </TradeConfirms>" + XmlEnd;
            var obj = Deserializer.Deserialize<Xml.Contracts.FlexQueryResponse, Contracts.FlexQueryResponse>(this._streamBuilder.GenerateStreamFromString(str), out var msg);
            var tradeConfirms = obj.FlexStatements.FlexStatement.TradeConfirms.TradeConfirm;
            tradeConfirms.Count.Should().Be(1);
            tradeConfirms[0].IsAPIOrder.Should().Be("N");
        }

        [Test]
        public void TestTradeConfirms_AllocatedTo()
        {
            var str = XmlStart + @"<TradeConfirms>
            <TradeConfirm allocatedTo='allocTo' />
            </TradeConfirms>" + XmlEnd;
            var obj = Deserializer.Deserialize<Xml.Contracts.FlexQueryResponse, Contracts.FlexQueryResponse>(this._streamBuilder.GenerateStreamFromString(str), out var msg);
            var tradeConfirms = obj.FlexStatements.FlexStatement.TradeConfirms.TradeConfirm;
            tradeConfirms.Count.Should().Be(1);
            tradeConfirms[0].AllocatedTo.Should().Be("allocTo");
        }

        #endregion
    }
}
