namespace IbFlexReader
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using IbFlexReader.Contracts.Enums;
    using IbFlexReader.Contracts.Ib;
    using IbFlexReader.Utils;

    internal class Logic
    {
        public static void ProcessStatement(FlexStatement statement, Options options)
        {
            if (statement != null && options != null && options.SplitUpOpenCloseTrades)
            {
                statement.Trades.Trade = SplitUpOpenCloseTrades(statement.Trades.Trade, statement.Trades.Lot);
            }
        }

        private static List<Trade> SplitUpOpenCloseTrades(List<Trade> trades, List<Lot> lots)
        {
            var ocTrades = trades
                .Where(t => t.OpenCloseIndicator.HasValue && t.OpenCloseIndicator.Value.Matches(x => x.HasFlag(OpenClose.C) && x.HasFlag(OpenClose.O)));
            var remainingTrades = trades.Where(x => !ocTrades.Contains(x)).ToList();

            foreach (var ocTrade in ocTrades)
            {
                var lot = lots.First(x => x.TradeDateTime == ocTrade.TradeDateTime && x.BuySell == ocTrade.BuySell && x.Description == ocTrade.Description);
                var copy = ocTrade.Clone();

                // ocTrade must be the "close" and the copy the "open"

                var newQ = Math.Sign(ocTrade.Quantity.Value) * Math.Abs(lot.Quantity.Value);
                ocTrade.OpenCloseIndicator = OpenClose.C;
                ocTrade.TradeMoney = (ocTrade.TradeMoney / Math.Abs(ocTrade.Quantity.Value)) * Math.Abs(newQ);
                ocTrade.Proceeds = (ocTrade.Proceeds / Math.Abs(ocTrade.Quantity.Value)) * Math.Abs(newQ);
                ocTrade.IbCommission = (ocTrade.IbCommission / Math.Abs(ocTrade.Quantity.Value)) * Math.Abs(newQ);
                ocTrade.Quantity = newQ;

                copy.OpenCloseIndicator = OpenClose.O;
                copy.FifoPnlRealized = 0;
                copy.Quantity = Math.Sign(copy.Quantity.Value) * (Math.Abs(copy.Quantity.Value) - Math.Abs(ocTrade.Quantity.Value));
                copy.TradeMoney = copy.TradeMoney - ocTrade.TradeMoney;
                copy.Proceeds = copy.Proceeds - ocTrade.Proceeds;
                copy.IbCommission = copy.IbCommission - ocTrade.IbCommission;

                remainingTrades.Add(ocTrade);
                remainingTrades.Add(copy);
            }

            return remainingTrades;
        }
    }
}
