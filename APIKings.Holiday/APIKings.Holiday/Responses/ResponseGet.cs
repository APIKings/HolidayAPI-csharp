using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIKings.Holiday.Responses
{
    public class ResponseGet : IAPIResponse
    {
        public bool Success { get; set; }
        public List<DateTime> Dates { get; set; }
    }
}
