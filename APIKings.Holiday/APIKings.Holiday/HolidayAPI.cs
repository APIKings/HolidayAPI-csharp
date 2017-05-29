using System;
using System.Collections.Generic;
using System.Net.Http;

namespace APIKings.Holiday
{
    public class HolidayAPI
    {
        private readonly Guid APIKey;
        private readonly Uri BaseURL;
        private readonly Uri BaseURLWithKey;

        public HolidayAPI(string apiKey)
        {
            try
            {
                APIKey = Guid.Parse(apiKey);
            }
            catch (Exception ex)
            {

            }

            BaseURL = new Uri("http://holiday.apikings.com");
            BaseURLWithKey = new Uri(BaseURL + "/" + APIKey);
        }

        public string Next(string country)
        {
            country = country.ToUpperInvariant();
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = BaseURLWithKey;
                var request = client.GetStringAsync(String.Format("/get?country={0}", country));

                return new DateTime(request.Result);
            }


            return;
        }

        public DateTime Previous(string country)
        {
            return new DateTime();
        }

        public List<DateTime> Past(string country)
        {
            return new List<DateTime>();
        }

        public List<DateTime> Future(string country)
        {
            return new List<DateTime>();
        }

        public bool IsHoliday(string country)
        {
            return true;
        }

        public DateTime Get(string country)
        {
            return new DateTime();
        }
    }
}
