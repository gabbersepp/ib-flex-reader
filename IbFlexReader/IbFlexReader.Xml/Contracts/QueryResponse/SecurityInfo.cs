﻿using System.Xml.Serialization;

namespace IbFlexReader.Xml.Contracts
{
    [XmlRoot(ElementName = "SecurityInfo")]
    public class SecurityInfo
    {
        [XmlAttribute(AttributeName = "assetCategory")]
        public string AssetCategory { get; set; }

        [XmlAttribute(AttributeName = "symbol")]
        public string Symbol { get; set; }

        [XmlAttribute(AttributeName = "description")]
        public string Description { get; set; }

        [XmlAttribute(AttributeName = "conid")]
        public string Conid { get; set; }

        [XmlAttribute(AttributeName = "securityID")]
        public string SecurityID { get; set; }

        [XmlAttribute(AttributeName = "securityIDType")]
        public string SecurityIDType { get; set; }

        [XmlAttribute(AttributeName = "cusip")]
        public string Cusip { get; set; }

        [XmlAttribute(AttributeName = "isin")] public string Isin { get; set; }

        [XmlAttribute(AttributeName = "listingExchange")]
        public string ListingExchange { get; set; }

        [XmlAttribute(AttributeName = "underlyingConid")]
        public string UnderlyingConid { get; set; }

        [XmlAttribute(AttributeName = "underlyingSymbol")]
        public string UnderlyingSymbol { get; set; }

        [XmlAttribute(AttributeName = "underlyingSecurityID")]
        public string UnderlyingSecurityID { get; set; }

        [XmlAttribute(AttributeName = "underlyingListingExchange")]
        public string UnderlyingListingExchange { get; set; }

        [XmlAttribute(AttributeName = "issuer")]
        public string Issuer { get; set; }

        [XmlAttribute(AttributeName = "multiplier")]
        public string Multiplier { get; set; }

        [XmlAttribute(AttributeName = "strike")]
        public string Strike { get; set; }

        [XmlAttribute(AttributeName = "expiry")]
        public string Expiry { get; set; }

        [XmlAttribute(AttributeName = "putCall")]
        public string PutCall { get; set; }

        [XmlAttribute(AttributeName = "principalAdjustFactor")]
        public string PrincipalAdjustFactor { get; set; }

        [XmlAttribute(AttributeName = "maturity")]
        public string Maturity { get; set; }

        [XmlAttribute(AttributeName = "issueDate")]
        public string IssueDate { get; set; }

        [XmlAttribute(AttributeName = "underlyingCategory")]
        public string UnderlyingCategory { get; set; }

        [XmlAttribute(AttributeName = "subCategory")]
        public string SubCategory { get; set; }

        [XmlAttribute(AttributeName = "code")] public string Code { get; set; }
    }
}