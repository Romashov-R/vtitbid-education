using Vtitbid.Education.ISP20;

var repo = new CurrencyRepository(DateTime.Now);

var selectedCurrency = CurrencyConverter.CurrencySelection(repo);

Console.WriteLine($"Выбранная валюта: {selectedCurrency.Value.Name}");