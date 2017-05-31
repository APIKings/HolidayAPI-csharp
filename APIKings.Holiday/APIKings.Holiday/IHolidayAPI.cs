using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIKings.Holiday
{
    public interface IHolidayAPI
    {
        IAPIResponse Get(string country, int year);
        IAPIResponse IsHoliday(string country, DateTime date);
        IAPIResponse Future(string country);
        IAPIResponse Past(string country);
        IAPIResponse Previous(string country);
        IAPIResponse Next(string country);
    }
}
