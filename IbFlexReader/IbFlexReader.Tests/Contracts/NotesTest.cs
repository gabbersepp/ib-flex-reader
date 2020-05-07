namespace IbFlexReader.Tests.Contracts
{
    using System;
    using System.Linq;
    using FluentAssertions;
    using IbFlexReader.Contracts.Enums;
    using NUnit.Framework;

    public class NotesTest
    {
        [Test]
        public void TestDifferentCombinations()
        {
            var notes = Notes.AdjustedLossWashSale | Notes.Adjustment | Notes.ArrangedByIB | Notes.CrossTrade | Notes.RedemptionToInvestor;
            EnsureEverythingIsEmpty(notes, Notes.AdjustedLossWashSale, Notes.Adjustment, Notes.ArrangedByIB, Notes.CrossTrade, Notes.RedemptionToInvestor);
            notes.HasFlag(Notes.AdjustedLossWashSale).Should().BeTrue();
            notes.HasFlag(Notes.Adjustment).Should().BeTrue();
            notes.HasFlag(Notes.ArrangedByIB).Should().BeTrue();
            notes.HasFlag(Notes.CrossTrade).Should().BeTrue();
            notes.HasFlag(Notes.RedemptionToInvestor).Should().BeTrue();
        }

        private void EnsureEverythingIsEmpty(Notes combined, params Notes[] except)
        {
            Enum.GetValues(typeof(Notes)).Cast<Notes>()
                .Where(x => except.All(ex => ex != x)).ToList()
                .ForEach(note => { combined.HasFlag(note).Should().BeFalse($"{combined} should not have flag {note}"); });
        }
    }
}