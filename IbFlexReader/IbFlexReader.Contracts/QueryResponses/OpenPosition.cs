﻿/* 
 Licensed under the Apache License, Version 2.0

 http://www.apache.org/licenses/LICENSE-2.0

 https://xmltocsharp.azurewebsites.net/
 */
using IbFlexReader.Contracts.Attributes;
using System;

namespace IbFlexReader.Contracts
{
    public class OpenPosition
    {

        public string AccountId { get; set; }

        public string AcctAlias { get; set; }

        public string Model { get; set; }

        public Currencies? Currency { get; set; }

        public double? FxRateToBase { get; set; }

        public AssetCategory? AssetCategory { get; set; }

        public string Symbol { get; set; }

        public string Description { get; set; }

        public long? Conid { get; set; }

        public string SecurityID { get; set; }

        public string SecurityIDType { get; set; }

        public string Cusip { get; set; }

        public string Isin { get; set; }

        public string ListingExchange { get; set; }

        public int? UnderlyingConid { get; set; }

        public string UnderlyingSymbol { get; set; }

        public string UnderlyingSecurityID { get; set; }

        public string UnderlyingListingExchange { get; set; }

        public string Issuer { get; set; }

        public int? Multiplier { get; set; }

        public double? Strike { get; set; }

        [Format(Constants.DateFormat)]
        public DateTime? Expiry { get; set; }

        public PutCall? PutCall { get; set; }

        public string PrincipalAdjustFactor { get; set; }

        [Format(Constants.DateFormat)]
        public DateTime? ReportDate { get; set; }

        public int? Position { get; set; }

        public double? MarkPrice { get; set; }

        public double? PositionValue { get; set; }

        public double? OpenPrice { get; set; }

        public double? CostBasisPrice { get; set; }

        public double? CostBasisMoney { get; set; }

        public string PercentOfNAV { get; set; }

        public double? FifoPnlUnrealized { get; set; }

        public LongShort? Side { get; set; }

        public string LevelOfDetail { get; set; }

        [Format(Constants.DateTimeFormat)]
        public DateTime? OpenDateTime { get; set; }

        [Format(Constants.DateTimeFormat)]
        public DateTime? HoldingPeriodDateTime { get; set; }

        public string Code { get; set; }

        public long? OriginatingOrderID { get; set; }

        public long? OriginatingTransactionID { get; set; }

        public string AccruedInt { get; set; }
    }

}
