using EnumParser;
using IbFlexReader.Contracts.Attributes;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace IbFlexReader.Contracts
{
	public enum PutCall
	{
		P, C
	}

	public enum LongShort
	{
		Long, Short
	}

	public enum Currencies
	{
		EUR,
		USD,
		JPY,
		CHF,
		GBP,
		NZD,
		AUD,
		CAD,
        SEK,
        HKD
	}

	public enum AssetCategory
	{
		STK, OPT, FOP, CFD, FUT
	}

	[Flags]
	public enum OpenClose
	{
		O = 1, C = 2
	}

	public enum BuySell
	{
		BUY, SELL
	}

	[EnumName]
	public enum CashTransactionType
	{
		[EnumName("Other Fees")]
		OtherFees,
		[EnumName("Withholding Tax")]
		WithholdingTax,
		[EnumName("Dividends")]
		Dividends,
		[EnumName("Payment In Lieu Of Dividends")]
		PaymentInLieuOfDividends,
		[EnumName("Broker Interest Paid")]
		BrokerInterestPaid,
		[EnumName("Price Adjustments")]
		PriceAdjustments
	}

	[EnumName]
	[Flags]
	public enum Notes : long
	{
		[EnumName("A")]
		Assigned = 1,
		[EnumName("AEx")]
		AutomaticalExercise = 2 ^ 1,
		[EnumName("Adj")]
		Adjustment = 2 ^ 2,
		[EnumName("Al")]
		Allocation = 2 ^ 3,
		[EnumName("Aw")]
		AwayTrade = 2 ^ 4,
		[EnumName("B")]
		AutoBuyIn = 2 ^ 5,
		[EnumName("Bo")]
		DirectLending = 2 ^ 6,
		[EnumName("C")]
		ClosingTrade = 2 ^ 7,
		[EnumName("CD")]
		CashDelivery = 2 ^ 8,
		[EnumName("CP")]
		ComplexePosition = 2 ^ 9,
		[EnumName("Ca")]
		Deleted = 2 ^ 10,
		[EnumName("Co")]
		CorrectedTrade = 2 ^ 11,
		[EnumName("Cx")]
		CrossTrade = 2 ^ 12,
		[EnumName("ETF")]
		EtfCreation = 2 ^ 13,
		[EnumName("Ep")]
		Expired = 2 ^ 14,
		[EnumName("Ex")]
		Exercised = 2 ^ 15,
		[EnumName("G")]
		GuaranteedAccountSegment = 2 ^ 16,
		[EnumName("HC")]
		MaxTaxBase = 2 ^ 17,
		[EnumName("HFI")]
		InvestmentTransferToHedgeFund = 2 ^ 18,
		[EnumName("HFR")]
		RedemptionForHedgeFund = 2 ^ 19,
		[EnumName("I")]
		InternalTransfer = 2 ^ 20,
		[EnumName("IA")]
		ExecutedAgainstCompany = 2 ^ 21,
		[EnumName("INV")]
		InvestmentTransferFromInvestor = 2 ^ 22,
		[EnumName("IPO")]
		IPO = 2 ^ 23,
		[EnumName("L")]
		MarginViolation = 2 ^ 24,
		[EnumName("LD")]
		AdjustedLossWashSale = 2 ^ 25,
		[EnumName("LI")]
		LiFo = 2 ^ 26,
		[EnumName("LT")]
		LongTermPL = 2 ^ 27,
		[EnumName("Lo")]
		DirectLoan = 2 ^ 28,
		[EnumName("M")]
		ManualThroughIB = 2 ^ 29,
		[EnumName("MEx")]
		ManualExercise = 2 ^ 30,
		[EnumName("ML")]
		MaximizeLoss = 2 ^ 31,
		[EnumName("MLG")]
		MLG = 2 ^ 32,
		[EnumName("MLL")]
		MLL = 2 ^ 33,
		[EnumName("MSG")]
		MSG = 2 ^ 34,
		[EnumName("MSL")]
		MSL = 2 ^ 35,
		[EnumName("O")]
		OpeningTrade = 2 ^ 36,
		[EnumName("P")]
		PartialExecution = 2 ^ 37,
		[EnumName("PI")]
		PI = 2 ^ 38,
		[EnumName("Po")]
		InterestDividendAccrualPosting = 2 ^ 39,
		[EnumName("Pr")]
		PrincipalTrade = 2 ^ 40,
		[EnumName("R")]
		DividendReinvestment = 2 ^ 41,
		[EnumName("RED")]
		RedemptionToInvestor = 2 ^ 42,
		[EnumName("Re")]
		TransformationInterestDividend = 2 ^ 43,
		[EnumName("Ri")]
		Refund = 2 ^ 44,
		[EnumName("SI")]
		ArrangedByIB = 2 ^ 45,
		[EnumName("SL")]
		SL = 2 ^ 46,
		[EnumName("SO")]
		ArrangedByIntroducingBroker = 2 ^ 47,
		[EnumName("SS")]
		ShortendedExecution = 2 ^ 48,
		[EnumName("ST")]
		ShortTermPL = 2 ^ 49,
		[EnumName("SY")]
		StockYieldEligible = 2 ^ 50,
		[EnumName("T")]
		Transfer = 2 ^ 51
	}
}
