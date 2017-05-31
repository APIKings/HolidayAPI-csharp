using System;
using System.Collections.Generic;

namespace APIKings.Holiday.Responses
{
    public class ResponseFuturePast : IAPIResponse
    {
        public bool Success { get; set; }
        public List<DateTime> Dates { get; set; }
    }
}
