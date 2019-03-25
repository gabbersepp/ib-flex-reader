namespace IbFlexReader.Tests.Xml
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using FluentAssertions;
    using IbFlexReader.Contracts.Enums;
    using IbFlexReader.Tests.TestXml;
    using NUnit.Framework;

    public class StatementOfFundsTest
    {
        [Test]
        public void StatementOfFunds()
        {
            var file = new TestFileHelper().ReadXmlFiles("StatementOfFunds").Single();
            var response = new Reader().GetByString(file);
            var anyEntry = response.FlexStatements.FlexStatement.StatementOfFunds.StatementOfFundsLine.First(x => x.TradeID == "554955532");
            anyEntry.ActivityDescription.Should().Be("Buy 1 XSP 05DEC18 270.0 C ");
            anyEntry.BuySell.Should().Be(BuySell.BUY);
            anyEntry.TradePrice.Should().Be(14.2);
        }
    }
}
