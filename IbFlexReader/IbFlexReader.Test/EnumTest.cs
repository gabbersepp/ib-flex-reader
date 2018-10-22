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
            var enumValue = EnumParser.ParseWithMapping(typeof(TradeType), "Other Fees");

            enumValue.Should().Be(TradeType.OtherFees);
        }
    }
}
