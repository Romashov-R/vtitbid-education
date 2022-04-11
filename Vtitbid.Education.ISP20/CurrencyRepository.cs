namespace Vtitbid.Education.ISP20
{
    public class CurrencyRepository
    {
        public DateTime Date { get; set; }
        public Dictionary<string, Currency> Currencies { get; set; }

        public CurrencyRepository(DateTime date)
        {
            Date = date;

            Currencies = new Dictionary<string, Currency>();

            Currencies.Add("USD", new Currency("840", "USD", 1, "Доллар США", 74.8501m, date));
            Currencies.Add("EUR", new Currency("978", "EUR", 1, "Евро", 81.7064m, date));
            Currencies.Add("PLN", new Currency("985", "PLN", 1, "Польский злотый", 17.5195m, date));
            Currencies.Add("CNY", new Currency("156", "CNY", 1, "Китайский юань", 11.7611m, date));
        }
    }
}
