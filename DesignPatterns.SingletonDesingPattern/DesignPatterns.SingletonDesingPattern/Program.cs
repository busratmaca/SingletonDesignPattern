// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Metrics;
using DesignPatterns.SingletonDesingPattern;


Console.WriteLine(DateTime.Now.ToLongTimeString());
var countries = await CountryProvider.Instance.GetCountries();

foreach (var country in countries)
{
    Console.WriteLine("Country -> " + country.Name);

}



Console.WriteLine(DateTime.Now.ToLongTimeString());

var countries2 = await CountryProvider.Instance.GetCountries();

foreach (var country in countries2)
{
    Console.WriteLine("Country 2 -> " + country.Name);
}

Console.WriteLine("Country Count-> " + CountryProvider.Instance.CountryCount);

