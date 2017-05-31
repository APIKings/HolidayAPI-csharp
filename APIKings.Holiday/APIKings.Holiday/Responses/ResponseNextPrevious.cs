using Newtonsoft.Json;
using System;

namespace APIKings.Holiday.Responses
{
    public class ResponseNextPrevious : IAPIResponse
    {
        public bool Success { get; set; }
        public Holiday Holiday { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }

    public class Holiday
    {
        public DateTime Date { get; set; }
        public string Name { get; set; }
        public Country Country { get; set; }
    }

    public class Country
    {
        public string Name { get; set; }
        public string Code { get; set; }
    }
}
