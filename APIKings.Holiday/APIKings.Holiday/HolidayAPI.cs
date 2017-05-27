using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIKings.Holiday
{
    public class HolidayAPI
    {
        private readonly string APIKey;
        private readonly string BaseURL;
        private readonly string BaseURLWithKey;

        public HolidayAPI(string apiKey)
        {
            APIKey = apiKey;
            BaseURL = "http://holiday.apikings.com/";
            BaseURLWithKey = BaseURL + "/" + APIKey;
        }

        public DateTime Next(HolidayAPICountries country)
        {



            return new DateTime();
        }

        public DateTime Previous(HolidayAPICountries country)
        {
            return new DateTime();
        }

        public DateTime Past(HolidayAPICountries country)
        {
            return new DateTime();
        }

        public DateTime Future(HolidayAPICountries country)
        {
            return new DateTime();
        }

        public DateTime IsHoliday(HolidayAPICountries country)
        {
            return new DateTime();
        }

        public DateTime Get(HolidayAPICountries country)
        {
            return new DateTime();
        }
    }
}
