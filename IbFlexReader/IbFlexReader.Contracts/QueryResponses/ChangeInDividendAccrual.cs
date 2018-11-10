﻿/* 
 Licensed under the Apache License, Version 2.0

 http://www.apache.org/licenses/LICENSE-2.0

 https://xmltocsharp.azurewebsites.net/
 */

namespace IbFlexReader.Contracts
{
    public class ChangeInDividendAccrual
    {

        public string AccountId { get; set; }

        public string AcctAlias { get; set; }

        public string Model { get; set; }

        public string Currency { get; set; }

        public string FxRateToBase { get; set; }

        public string AssetCategory { get; set; }

        public string Symbol { get; set; }

        public string Description { get; set; }

        public string Conid { get; set; }

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

        public string Multiplier { get; set; }

        public string Strike { get; set; }

        public string Expiry { get; set; }

        public string PutCall { get; set; }

        public string PrincipalAdjustFactor { get; set; }

        public string ReportDate { get; set; }

        public string Date { get; set; }

        public string ExDate { get; set; }

        public string PayDate { get; set; }

        public string Quantity { get; set; }

        public string Tax { get; set; }

        public string Fee { get; set; }

        public string GrossRate { get; set; }

        public string GrossAmount { get; set; }

        public string NetAmount { get; set; }

        public string Code { get; set; }

        public string FromAcct { get; set; }

        public string ToAcct { get; set; }
    }

}
