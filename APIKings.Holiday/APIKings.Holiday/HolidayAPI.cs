using APIKings.Holiday.Responses;
using Newtonsoft.Json;
using System;
using System.Net.Http;

namespace APIKings.Holiday
{
    public class HolidayAPI : IHolidayAPI
    {
        private readonly Guid APIKey;
        private readonly Uri BaseURL;

        public HolidayAPI(string apiKey, string baseURL = null)
        {
            try
            {
                APIKey = Guid.Parse(apiKey);
            }
            catch (Exception ex)
            {

            }
            if (baseURL != null)
            {
                BaseURL = new Uri(baseURL);
            }
            else
            {
                BaseURL = new Uri("http://holiday.apikings.com");
            }
        }

        public IAPIResponse Next(string country)
        {
            country = country.ToUpperInvariant();
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = BaseURL;
                var request = client.GetAsync(String.Format("/next/{0}?country={1}", APIKey.ToString(), country));
                var result = request.Result.Content.ReadAsStringAsync().Result;
                var json = JsonConvert.DeserializeObject<ResponseNextPrevious>(result);
                return json;
            }
        }

        public IAPIResponse Previous(string country)
        {
            country = country.ToUpperInvariant();
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = BaseURL;
                var request = client.GetAsync(String.Format("/previous/{0}?country={1}", APIKey.ToString(), country));
                var result = request.Result.Content.ReadAsStringAsync().Result;
                var json = JsonConvert.DeserializeObject<ResponseNextPrevious>(result);
                return json;
            }
        }

        public IAPIResponse Past(string country)
        {
            country = country.ToUpperInvariant();
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = BaseURL;
                var request = client.GetAsync(String.Format("/past/{0}?country={1}", APIKey.ToString(), country));
                var result = request.Result.Content.ReadAsStringAsync().Result;
                var json = JsonConvert.DeserializeObject<ResponseFuturePast>(result);
                return json;
            }
        }

        public IAPIResponse Future(string country)
        {
            country = country.ToUpperInvariant();
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = BaseURL;
                var request = client.GetAsync(String.Format("/future/{0}?country={1}", APIKey.ToString(), country));
                var result = request.Result.Content.ReadAsStringAsync().Result;
                var json = JsonConvert.DeserializeObject<ResponseFuturePast>(result);
                return json;
            }
        }

        public IAPIResponse IsHoliday(string country, DateTime date)
        {
            country = country.ToUpperInvariant();
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = BaseURL;
                var request = client.GetAsync(String.Format("/future/{0}?country={1}&date={2}", APIKey.ToString(), country, date.ToString("dd-mm-yyyy")));
                var result = request.Result.Content.ReadAsStringAsync().Result;
                var json = JsonConvert.DeserializeObject<ResponseIsHoliday>(result);
                return json;
            }
        }

        public IAPIResponse Get(string country, int year)
        {
            country = country.ToUpperInvariant();
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = BaseURL;
                var request = client.GetAsync(String.Format("/future/{0}?country={1}&year={2}", APIKey.ToString(), country, year));
                var result = request.Result.Content.ReadAsStringAsync().Result;
                var json = JsonConvert.DeserializeObject<ResponseGet>(result);
                return json;
            }
        }
    }
}
