﻿/* 
 Licensed under the Apache License, Version 2.0

 http://www.apache.org/licenses/LICENSE-2.0

 https://xmltocsharp.azurewebsites.net/
 */
using IbFlexReader.Contracts.Attributes;
using System;

namespace IbFlexReader.Contracts
{
    public class CashTransaction
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

        public string UnderlyingConid { get; set; }

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
        public DateTime? DateTime { get; set; }

        public double? Amount { get; set; }
        
        public CashTransactionType? Type { get; set; }

        public long? TradeID { get; set; }

        public string Code { get; set; }

        public long? TransactionID { get; set; }

        [Format(Constants.DateFormat)]
        public DateTime? ReportDate { get; set; }

        public string ClientReference { get; set; }
    }

}
