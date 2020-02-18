using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HttpTraining.Clients
{
    class BeerApiClient
    {
        private const string beerApiUrl = @"http://ontariobeerapi.ca";

        public List<Beer> GetAllBeers()
        {
            using HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(beerApiUrl);

            using HttpResponseMessage response = client.GetAsync("products/").Result;
            if (response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<List<Beer>>(data);
            }
            else
            {
                Console.WriteLine("Something wronh happened: " + response.StatusCode);
                return null;
            }
        }

        internal void AddNewBeer(Beer beer) 
        {
            Console.WriteLine(JsonConvert.SerializeObject(beer));
        }
    }
}
