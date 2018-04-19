using System;
namespace TipCalculator
{
    public class TipCalculator
    {
        public string TaxPercentToDecimal(string taxP)
        {
            decimal? taxPercent = Convert.ToDecimal(taxP)/100;
            return taxPercent.ToString();
        }
        public string TipPercentToDecimal(string tipP)
        {
            decimal? tipPercent = Convert.ToDecimal(tipP) / 100;
            return tipPercent.ToString();
        }
    }
}
