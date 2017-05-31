using Newtonsoft.Json;

namespace APIKings.Holiday.Responses
{
    public class ResponseIsHoliday : IAPIResponse
    {
        public bool Success { get; set; }
        public bool Holiday { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
