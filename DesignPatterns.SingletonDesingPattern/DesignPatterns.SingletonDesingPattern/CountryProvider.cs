using System;
using System.Runtime.CompilerServices;

namespace DesignPatterns.SingletonDesingPattern
{
    public class CountryProvider
    {
        private static CountryProvider instance = null;

        public static CountryProvider Instance => instance = instance ?? new CountryProvider();

        private new List<Country> Countries { get; set; }


        private CountryProvider()
        {
            Task.Delay(2000).GetAwaiter().GetResult();

            Countries = new List<Country>()
                {
                new Country(){ Name ="TURKEY"},

                new Country(){ Name ="GERMANY"},

                new Country(){ Name ="FRANCE"}
                };

        }

        public int CountryCount => Countries.Count();
        public async Task<List<Country>> GetCountries() => Countries;



    }
}

