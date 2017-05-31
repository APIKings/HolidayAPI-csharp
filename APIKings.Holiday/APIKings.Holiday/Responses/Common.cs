using System;

namespace APIKings.Holiday.Responses
{
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
