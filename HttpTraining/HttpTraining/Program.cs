using HttpTraining.Clients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HttpTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            BeerApiClient beerApiClient = new BeerApiClient();
            List<Beer> allBeers = beerApiClient.GetAllBeers();
            if (allBeers != null)
            {
                var corona = from beer in allBeers
                              where beer.Name.Contains("Corona")
                              select beer;
                corona.ToList().ForEach(Console.WriteLine);
            }
            else
            {
                Console.WriteLine("No beers found.");
            }
            beerApiClient.AddNewBeer(new Beer()
            {
                Name = "Svyturys",
                Price = 2,
                Country = "Lietuva",
                OnSale = true,
                Size = "Didelis"
            });
        }
    }
}
