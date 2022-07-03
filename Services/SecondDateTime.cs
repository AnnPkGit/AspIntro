using System;

namespace Intro.Services
{
    public class SecondDateTime : IDateTimeSeparated
    {
        string IDateTimeSeparated.Date()
        {
            return DateTime.Now.Date.ToString("dddd, dd MMMM yyyy");
        }

        string IDateTimeSeparated.Time()
        {
            return DateTime.Now.TimeOfDay.ToString();
        }
    }
}
