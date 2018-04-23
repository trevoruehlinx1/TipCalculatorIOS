using System;
namespace TipCalculator
{
    public class TipCalculator
    {
        public decimal? GetTaxAmount(decimal? taxPercent, decimal? checkAmount)
        {
            decimal? taxAmount = 0;
            taxAmount = taxPercent * checkAmount;
            return taxAmount;
        }
        public decimal? GetTipAmount(decimal? tipPercent, decimal?checkAmount)
        {
            decimal? tipAmount = 0;
            tipAmount = tipPercent * checkAmount;
            return tipAmount;
        }
        public decimal? GetTotalCheckAmount(decimal? tipAmount, decimal? taxAmount,decimal? checkAmount)
        {
            decimal? totalCheckAmount = 0;
            totalCheckAmount = tipAmount + taxAmount + checkAmount;
            return totalCheckAmount;
        }
    }
}
