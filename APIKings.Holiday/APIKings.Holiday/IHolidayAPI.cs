using APIKings.Holiday.Responses;
using System;

namespace APIKings.Holiday
{
    public interface IHolidayAPI
    {
        ResponseGet Get(string country, int year);
        ResponseIsHoliday IsHoliday(string country, DateTime date);
        ResponseFuturePast Future(string country);
        ResponseFuturePast Past(string country);
        ResponseNextPrevious Previous(string country);
        ResponseNextPrevious Next(string country);
    }
}
