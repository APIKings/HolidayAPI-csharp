using APIKings.Holiday;
using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var prog = new Program();
            prog.Start();
        }


        public void Start()
        {
            var api = new HolidayAPI("161206dd-46ea-498a-b302-3963b1105b06");

            var next = api.Next("uk");
            Console.WriteLine("Next: " + next.Success);
            Console.WriteLine(next.ToString());


            var previous = api.Previous("uk");
            Console.WriteLine("Previous: " + previous.Success);
            Console.WriteLine(previous.ToString());

            var future = api.Future("uk");
            Console.WriteLine("Future: " + future.Success);
            Console.WriteLine(future.ToString());

            var past = api.Past("uk");
            Console.WriteLine("Past: " + past.Success);
            Console.WriteLine(past.ToString());

            var isholiday = api.IsHoliday("uk", DateTime.Now);
            Console.WriteLine("IsHoliday: " + isholiday.Success);
            Console.WriteLine(isholiday.ToString());

            var get = api.Get("uk", 2017);
            Console.WriteLine("Get: " + get.Success);
            Console.WriteLine(get.ToString());



            Console.ReadKey();
        }
    }
}
