using System;

namespace APIKings.Holiday.Responses
{
    public class ResponseNextPrevious : IAPIResponse
    {
        public bool Success { get; set; }
        public DateTime Date { get; set; }
    }
}
