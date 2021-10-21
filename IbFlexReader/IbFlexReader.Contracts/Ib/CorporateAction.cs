namespace IbFlexReader.Contracts.Ib
{
    using System.Collections.Generic;

    public class CorporateAction
    {
        public string AccountId                 { get; set; }
        public string AcctAlias                 { get; set; }
        public string Model                     { get; set; }
        public string Currency                  { get; set; }
        public string FxRateToBase              { get; set; }
        public string AssetCategory             { get; set; }
        public string Symbol                    { get; set; }
        public string Description               { get; set; }
        public string Conid                     { get; set; }
        public string SecurityID                { get; set; }
        public string SecurityIDType            { get; set; }
        public string Cusip                     { get; set; }
        public string Isin                      { get; set; }
        public string ListingExchange           { get; set; }
        public string UnderlyingConid           { get; set; }
        public string UnderlyingSymbol          { get; set; }
        public string UnderlyingSecurityID      { get; set; }
        public string UnderlyingListingExchange { get; set; }
        public string Issuer                    { get; set; }
        public string Multiplier                { get; set; }
        public string Strike                    { get; set; }
        public string Expiry                    { get; set; }
        public string PutCall                   { get; set; }
        public string PrincipalAdjustFactor     { get; set; }
        public string SerialNumber              { get; set; }
        public string DeliveryType              { get; set; }
        public string CommodityType             { get; set; }
        public string Fineness                  { get; set; }
        public string Weight                    { get; set; }
        public string ReportDate                { get; set; }
        public string DateTime                  { get; set; }
        public string ActionDescription         { get; set; }
        public string Amount                    { get; set; }
        public string Proceeds                  { get; set; }
        public string Value                     { get; set; }
        public string Quantity                  { get; set; }
        public string FifoPnlRealized           { get; set; }
        public string MtmPnl                    { get; set; }
        public string Type                      { get; set; }
        public string TransactionID             { get; set; }
        public string LevelOfDetail             { get; set; }
    }
}
