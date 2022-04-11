using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtitbid.Education.ISP20
{
    public static class CurrencyConverter
    {
        public static Currency? CurrencySelection(CurrencyRepository repository)
        {
            Console.WriteLine("Выберите необходимую валюту:");            
            foreach(var item in repository.Currencies)
            {
                Console.WriteLine($"{item.Value.LetterCode} {item.Value.Name}");
            }

            var currencyCode = Console.ReadLine();

            if(!repository.Currencies.TryGetValue(currencyCode, out var currency))
            {
                return null;
            }

            return currency; 
        }
    }
}
