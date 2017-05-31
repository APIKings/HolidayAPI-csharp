namespace APIKings.Holiday.Responses
{
    public class ResponseIsHoliday : IAPIResponse
    {
        public bool Success { get; set; }
        public bool Holiday { get; set; }
    }
}
