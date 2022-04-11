using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtitbid.Education.ISP20
{
    public readonly struct Currency
    {
        public string DigitalCode { get; init; }
        public string LetterCode { get; init; }
        public int Unit { get; init; }
        public string Name { get; init; }
        public decimal Rate { get; init; }
        public DateTime Date { get; init; }

        public Currency(string digitalCode, string letterCode, int unit, string name, decimal rate, DateTime date)
        {
            DigitalCode = digitalCode;
            LetterCode = letterCode;
            Unit = unit;
            Name = name;
            Rate = rate;
            Date = date;
        }

        public decimal RateRatio(Currency currency)
        {
            return Rate / currency.Rate;
        }
    }
}
