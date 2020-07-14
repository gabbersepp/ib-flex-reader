namespace IbFlexReader.Contracts.Ib
{
    using System;
    using IbFlexReader.Contracts.Attributes;
    using IbFlexReader.Contracts.Enums;

    public class UnbundledCommissionDetail
    {
        public string AccountId { get; set; }

        public string AcctAlias { get; set; }

        public double? Quantity { get; set; }

        public string PrincipalAdjustFactor { get; set; }

        public PutCall? PutCall { get; set; }

        public string Issuer { get; set; }

        public int? Multiplier { get; set; }

        public double? Strike { get; set; }

        [Format(Constants.DateFormat)]
        public DateTime? Expiry { get; set; }

        public AssetCategory? AssetCategory { get; set; }

        public string Symbol { get; set; }

        public string Description { get; set; }

        public long? Conid { get; set; }

        public string SecurityID { get; set; }

        public string SecurityIDType { get; set; }

        public string Cusip { get; set; }

        public string Isin { get; set; }

        public string ListingExchange { get; set; }

        public long? UnderlyingConid { get; set; }

        public string UnderlyingSymbol { get; set; }

        public string UnderlyingSecurityID { get; set; }

        public string UnderlyingListingExchange { get; set; }

        public string OrderReference { get; set; }

        public BuySell? BuySell { get; set; }

        public string Exchange { get; set; }

        public string DateTime { get; set; }

        public string TradeID { get; set; }

        public string Model { get; set; }

        public Currencies? Currency { get; set; }

        public double? FxRateToBase { get; set; }

        public string Other { get; set; }

        public string RegOther { get; set; }

        public double? RegSection31TransactionFee { get; set; }

        public double? RegFINRATradingActivityFee { get; set; }

        public double? ThirdPartyRegulatoryCharge { get; set; }

        public double? ThirdPartyClearingCharge { get; set; }

        public double? ThirdPartyExecutionCharge { get; set; }

        public double? BrokerClearingCharge { get; set; }

        public double? BrokerExecutionCharge { get; set; }

        public double? TotalCommission { get; set; }

        public double? Price { get; set; }
    }
}
