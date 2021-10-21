namespace IbFlexReader.Contracts.Ib
{
    using System;
    using IbFlexReader.Contracts.Attributes;
    using IbFlexReader.Contracts.Enums;

    public class AccountInformation
    {
        public string AccountId { get; set; }

        public string AcctAlias { get; set; }

        public string Model { get; set; }

        public Currencies? Currency { get; set; }

        public string Name { get; set; }

        public string AccountType { get; set; }

        public string CustomerType { get; set; }

        public string AccountCapabilities { get; set; }

        public string TradingPermissions { get; set; }

        public string RegisteredRepName { get; set; }

        public string RegisteredRepPhone { get; set; }

        [Format(Constants.DateFormat)]
        public DateTime? DateOpened { get; set; }

        [Format(Constants.DateFormat)]
        public DateTime? DateFunded { get; set; }

        [Format(Constants.DateFormat)]
        public DateTime? DateClosed { get; set; }

        public string Street { get; set; }

        public string Street2 { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Country { get; set; }

        public string PostalCode { get; set; }

        public string StreetResidentialAddress { get; set; }

        public string Street2ResidentialAddress { get; set; }

        public string CityResidentialAddress { get; set; }

        public string StateResidentialAddress { get; set; }

        public string CountryResidentialAddress { get; set; }

        public string PostalCodeResidentialAddress { get; set; }

        public string MasterName { get; set; }

        public string IbEntity { get; set; }

        public string PrimaryEmail { get; set; }

        public string AccountRepName  { get; set; }

        public string AccountRepPhone { get; set; }
    }
}
