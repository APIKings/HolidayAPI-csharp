using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace APIKings.Holiday.Responses
{
    public class ResponseGet : IAPIResponse
    {
        public bool Success { get; set; }
        public List<DateTime> Dates { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
