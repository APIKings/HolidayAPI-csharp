using Newtonsoft.Json;
using System.Collections.Generic;

namespace APIKings.Holiday.Responses
{
    public class ResponseIsHoliday : IAPIResponse
    {
        public bool Success { get; set; }
        public bool IsHoliday { get; set; }
        public Holiday Holiday { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
