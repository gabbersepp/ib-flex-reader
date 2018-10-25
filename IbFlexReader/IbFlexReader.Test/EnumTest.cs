using FluentAssertions;
using IbFlexReader.Contracts;
using NUnit.Framework;

namespace IbFlexReader.Test
{
    public class EnumTest
    {
        [Test]
        public void TestParseWithMapping()
        {
            var enumValue = EnumParser.ParseWithMapping(typeof(CashTransactionType), "Other Fees");

            enumValue.Should().Be(CashTransactionType.OtherFees);
        }
    }
}
