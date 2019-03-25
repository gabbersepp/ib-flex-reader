/* 
 Licensed under the Apache License, Version 2.0

 http://www.apache.org/licenses/LICENSE-2.0

 https://xmltocsharp.azurewebsites.net/
 */

namespace IbFlexReader.Xml.Contracts.QueryResponse
{
    using System.Xml.Serialization;

    [XmlRoot(ElementName = "AccountInformation")]
    public class AccountInformation
    {
        [XmlAttribute(AttributeName = "accountId")]
        public string AccountId { get; set; }

        [XmlAttribute(AttributeName = "acctAlias")]
        public string AcctAlias { get; set; }

        [XmlAttribute(AttributeName = "model")]
        public string Model { get; set; }

        [XmlAttribute(AttributeName = "currency")]
        public string Currency { get; set; }

        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }

        [XmlAttribute(AttributeName = "accountType")]
        public string AccountType { get; set; }

        [XmlAttribute(AttributeName = "customerType")]
        public string CustomerType { get; set; }

        [XmlAttribute(AttributeName = "accountCapabilities")]
        public string AccountCapabilities { get; set; }

        [XmlAttribute(AttributeName = "tradingPermissions")]
        public string TradingPermissions { get; set; }

        [XmlAttribute(AttributeName = "registeredRepName")]
        public string RegisteredRepName { get; set; }

        [XmlAttribute(AttributeName = "registeredRepPhone")]
        public string RegisteredRepPhone { get; set; }

        [XmlAttribute(AttributeName = "dateOpened")]
        public string DateOpened { get; set; }

        [XmlAttribute(AttributeName = "dateFunded")]
        public string DateFunded { get; set; }

        [XmlAttribute(AttributeName = "dateClosed")]
        public string DateClosed { get; set; }

        [XmlAttribute(AttributeName = "street")]
        public string Street { get; set; }

        [XmlAttribute(AttributeName = "street2")]
        public string Street2 { get; set; }

        [XmlAttribute(AttributeName = "city")]
        public string City { get; set; }

        [XmlAttribute(AttributeName = "state")]
        public string State { get; set; }

        [XmlAttribute(AttributeName = "country")]
        public string Country { get; set; }

        [XmlAttribute(AttributeName = "postalCode")]
        public string PostalCode { get; set; }

        [XmlAttribute(AttributeName = "streetResidentialAddress")]
        public string StreetResidentialAddress { get; set; }

        [XmlAttribute(AttributeName = "street2ResidentialAddress")]
        public string Street2ResidentialAddress { get; set; }

        [XmlAttribute(AttributeName = "cityResidentialAddress")]
        public string CityResidentialAddress { get; set; }

        [XmlAttribute(AttributeName = "stateResidentialAddress")]
        public string StateResidentialAddress { get; set; }

        [XmlAttribute(AttributeName = "countryResidentialAddress")]
        public string CountryResidentialAddress { get; set; }

        [XmlAttribute(AttributeName = "postalCodeResidentialAddress")]
        public string PostalCodeResidentialAddress { get; set; }

        [XmlAttribute(AttributeName = "masterName")]
        public string MasterName { get; set; }

        [XmlAttribute(AttributeName = "ibEntity")]
        public string IbEntity { get; set; }

        [XmlAttribute(AttributeName = "primaryEmail")]
        public string PrimaryEmail { get; set; }
    }
}