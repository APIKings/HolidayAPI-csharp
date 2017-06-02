using Newtonsoft.Json;
using System.Collections.Generic;

namespace APIKings.Holiday.Responses
{
    public class ResponseGet : IAPIResponse
    {
        public bool Success { get; set; }
        public int ResultCount { get; set; }
        public List<Holiday> Holidays { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
