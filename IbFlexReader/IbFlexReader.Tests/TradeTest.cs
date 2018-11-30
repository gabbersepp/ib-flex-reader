using FluentAssertions;
using IbFlexReader.Contracts;
using IbFlexReader.Xml;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static IbFlexReader.Test.Helper;

namespace IbFlexReader.Test
{
	[TestClass]
	public class TradeTest
	{
		[TestMethod]
		public void CombinedOpenCloseResolve()
		{
			var str = XmlStart + @"<Trades>
<Trade accountId=""xxxxx"" acctAlias="""" model="""" currency=""USD"" fxRateToBase=""0.87522"" assetCategory=""FUT"" symbol=""CLZ8"" description=""CL DEC18"" conid=""70407716"" securityID="""" securityIDType="""" cusip="""" isin="""" listingExchange="""" underlyingConid=""17340715"" underlyingSymbol=""CL"" underlyingSecurityID="""" underlyingListingExchange="""" issuer="""" multiplier=""1000"" strike="""" expiry=""20181119"" tradeID=""205781538"" putCall="""" reportDate=""20181107"" principalAdjustFactor="""" tradeDate=""20181107"" tradeTime=""013942"" settleDateTarget=""20181108"" transactionType=""ExchTrade"" exchange=""NYMEX"" quantity=""1"" tradePrice=""61.73"" tradeMoney=""61730"" proceeds=""-61730"" taxes=""0"" ibCommission=""-2.37"" ibCommissionCurrency=""USD"" netCash=""-62.37"" closePrice=""61.67"" openCloseIndicator=""O"" notes="""" cost=""61732.37"" fifoPnlRealized=""0"" fxPnl=""0"" mtmPnl=""-60"" origTradePrice=""0"" origTradeDate="""" origTradeID="""" origOrderID=""0"" clearingFirmID="""" transactionID=""695256601"" buySell=""BUY"" ibOrderID=""161900611"" ibExecID=""0001f4e5.5be236f3.01.01"" brokerageOrderID=""002039a1.000107e7.5be283eb.0001"" orderReference="""" volatilityOrderLink="""" exchOrderId=""002039a1.0001f4e0.5be242b4[2]"" extExecID=""150643675B"" orderTime=""20181107;013942"" openDateTime="""" holdingPeriodDateTime="""" whenRealized="""" whenReopened="""" levelOfDetail=""EXECUTION"" changeInPrice=""0"" changeInQuantity=""0"" orderType=""LMT"" traderID="""" isAPIOrder=""N"" />
<Trade accountId=""xxxxx"" acctAlias="""" model="""" currency=""USD"" fxRateToBase=""0.87522"" assetCategory=""FUT"" symbol=""CLZ8"" description=""CL DEC18"" conid=""70407716"" securityID="""" securityIDType="""" cusip="""" isin="""" listingExchange="""" underlyingConid=""17340715"" underlyingSymbol=""CL"" underlyingSecurityID="""" underlyingListingExchange="""" issuer="""" multiplier=""1000"" strike="""" expiry=""20181119"" tradeID=""205781547"" putCall="""" reportDate=""20181107"" principalAdjustFactor="""" tradeDate=""20181107"" tradeTime=""014012"" settleDateTarget=""20181108"" transactionType=""ExchTrade"" exchange=""NYMEX"" quantity=""-2"" tradePrice=""61.7"" tradeMoney=""-123400"" proceeds=""123400"" taxes=""0"" ibCommission=""-4.74"" ibCommissionCurrency=""USD"" netCash=""55.26"" closePrice=""61.67"" openCloseIndicator=""C;O"" notes="""" cost=""-61732.37"" fifoPnlRealized=""-34.74"" fxPnl=""0"" mtmPnl=""60"" origTradePrice=""0"" origTradeDate="""" origTradeID="""" origOrderID=""0"" clearingFirmID="""" transactionID=""695256610"" buySell=""SELL"" ibOrderID=""161900620"" ibExecID=""0001f4e5.5be236f9.01.01"" brokerageOrderID=""002039a1.000107e7.5be283ef.0001"" orderReference="""" volatilityOrderLink="""" exchOrderId=""002039a1.0001f4e0.5be242ca[2]"" extExecID=""150643723S"" orderTime=""20181107;014012"" openDateTime="""" holdingPeriodDateTime="""" whenRealized="""" whenReopened="""" levelOfDetail=""EXECUTION"" changeInPrice=""0"" changeInQuantity=""0"" orderType=""LMT"" traderID="""" isAPIOrder=""N"" />
<Lot accountId=""xxxxx"" acctAlias="""" model="""" currency=""USD"" fxRateToBase=""0.87522"" assetCategory=""FUT"" symbol=""CLZ8"" description=""CL DEC18"" conid=""70407716"" securityID="""" securityIDType="""" cusip="""" isin="""" listingExchange="""" underlyingConid=""17340715"" underlyingSymbol=""CL"" underlyingSecurityID="""" underlyingListingExchange="""" issuer="""" multiplier=""1000"" strike="""" expiry=""20181119"" tradeID="""" putCall="""" reportDate=""20181107"" principalAdjustFactor="""" tradeDate=""20181107"" tradeTime=""014012"" settleDateTarget="""" transactionType="""" exchange=""NYMEX"" quantity=""1"" tradePrice=""61.73237"" tradeMoney="""" proceeds="""" taxes="""" ibCommission="""" ibCommissionCurrency="""" netCash="""" closePrice="""" openCloseIndicator=""C;O"" notes=""ST"" cost=""61732.37"" fifoPnlRealized=""-34.74"" fxPnl=""0"" mtmPnl="""" origTradePrice="""" origTradeDate="""" origTradeID="""" origOrderID="""" clearingFirmID="""" transactionID=""695256601"" buySell=""SELL"" ibOrderID="""" ibExecID="""" brokerageOrderID="""" orderReference="""" volatilityOrderLink="""" exchOrderId="""" extExecID="""" orderTime="""" openDateTime=""20181107;013942"" holdingPeriodDateTime=""20181107;013942"" whenRealized="""" whenReopened="""" levelOfDetail=""CLOSED_LOT"" changeInPrice="""" changeInQuantity="""" orderType="""" traderID="""" isAPIOrder="""" />
</Trades>" + XmlEnd;
			var obj = new Reader().GetByString(str, new Options { SplitUpOpenCloseTrades = true });
			obj.Errors.Count.Should().Be(0);
			obj.FlexStatements.FlexStatement.Trades.Trade.Count.Should().Be(3);

			var trade1 = obj.FlexStatements.FlexStatement.Trades.Trade[1];
			var trade2 = obj.FlexStatements.FlexStatement.Trades.Trade[2];

			trade1.OpenCloseIndicator.Value.Should().HaveFlag(OpenClose.C);
			trade2.OpenCloseIndicator.Value.Should().HaveFlag(OpenClose.O);

			trade1.Quantity.Should().Be(-1);
			trade1.FifoPnlRealized.Should().Be(-34.74);
			trade1.TradeMoney.Should().Be(-61700);
			trade1.Proceeds.Should().Be(61700);
			trade1.IbCommission.Should().Be(-2.37);

			trade2.Quantity.Should().Be(-1);
			trade2.FifoPnlRealized.Should().Be(0);
			trade2.TradeMoney.Should().Be(-61700);
			trade2.Proceeds.Should().Be(61700);
			trade2.IbCommission.Should().Be(-2.37);
		}
	}
}
