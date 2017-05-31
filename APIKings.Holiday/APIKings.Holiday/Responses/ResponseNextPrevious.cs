using Newtonsoft.Json;

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
}
