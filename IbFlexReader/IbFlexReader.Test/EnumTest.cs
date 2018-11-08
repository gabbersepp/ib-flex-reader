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

        [Test]
        public void TestParseFlags()
        {
            var enumValue = EnumParser.Parse(typeof(OpenClose), "O;C");

            enumValue.Should().HaveFlag(OpenClose.C).And.HaveFlag(OpenClose.O);
        }

        [Test]
        public void TestNotesMoreThan32Flags()
        {
            var enumValue = EnumParser.Parse(typeof(Notes), "Ex;A");

            enumValue.Should().HaveFlag(Notes.Assigned).And.HaveFlag(Notes.Exercised);
        }
    }
}
