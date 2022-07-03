using System;

namespace Intro.Services
{
    public class FirstDateTime : IDateTimeSeparated
    {
        string IDateTimeSeparated.Date()
        {
            var date =  DateTime.Now.Date.ToString();
            var splitedDate = date.Split(" ");
            return splitedDate[0];
        }

        string IDateTimeSeparated.Time()
        {
            return DateTime.Now.TimeOfDay.ToString();
        }
    }
}
