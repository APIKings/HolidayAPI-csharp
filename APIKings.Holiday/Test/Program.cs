using APIKings.Holiday;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            var res = api.Next("uk");

            var test = "test";
        }
    }
}
