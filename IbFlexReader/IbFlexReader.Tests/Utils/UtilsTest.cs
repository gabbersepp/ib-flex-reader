namespace IbFlexReader.Tests.Utils
{
    using System.Collections.Generic;
    using FluentAssertions;
    using IbFlexReader.Contracts;
    using IbFlexReader.Utils;
    using NUnit.Framework;

    public class UtilsTest
    {
        [Test]
        public void PopulateFrom_AllowDateTimeWithTime()
        {
            var cashTransactionXml = new IbFlexReader.Xml.Contracts.QueryResponse.CashTransaction();
            cashTransactionXml.DateTime = "20180305;202000";
            var dto = new Contracts.Ib.CashTransaction();
            var mesg = new List<ErrorMessage>();
            dto.PopulateFrom(cashTransactionXml, mesg);
            mesg.Should().BeEmpty();
            dto.DateTime.Should().NotBeNull();
        }

        [Test]
        public void PopulateFrom_AllowDateTimeWothoutTime()
        {
            var cashTransactionXml = new IbFlexReader.Xml.Contracts.QueryResponse.CashTransaction();
            cashTransactionXml.DateTime = "20180305";
            var dto = new Contracts.Ib.CashTransaction();
            var mesg = new List<ErrorMessage>();
            dto.PopulateFrom(cashTransactionXml, mesg);
            mesg.Should().BeEmpty();
            dto.DateTime.Should().NotBeNull();
        }
    }
}
