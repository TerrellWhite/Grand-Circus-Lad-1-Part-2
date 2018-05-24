using System;

namespace Grand_Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write two dates two see the time between them in year, months, and days.");
            DateTime dt = DateTime.Parse(Console.ReadLine());
            DateTime dt2 = DateTime.Parse(Console.ReadLine());
            TimeSpan ts = (dt2 - dt);
            var Text = String.Format("{0}:{1}:{2}:{3}",ts.Days, ts.Hours, ts.Minutes, ts.Seconds); Console.WriteLine(Text);
            var year = 0.0;
            var day = 0.0;
            var week = 0.0;
            var month = 0.0;
          
            if (ts.Days % 365 >= 0)
            {
                day = ts.Days % 365;
                year = (ts.Days - (ts.Days % 365)) / 365;
            }
            if(ts.Days % 30 >= 0)
            {
                day = day % 30;
                month =  (ts.Days - (year * 365)) / 30;
            }
            if (ts.Days % 7 >= 0)
            {
                day = day % 7;
                week = (ts.Days - ((year * 365)+ (month * 30))) / 7;
            }
            Console.WriteLine("it's been "+ year + " year(s) " + month + " month(s) " + week+ " week(s) and " + day + " day(s)");
            /*Console.WriteLine("Give me two dates and I'll tell you the span of time between them");
            DateTime myValue = DateTime.Parse(Console.ReadLine());
            DateTime mySecondValue = DateTime.Parse(Console.ReadLine());
            TimeSpan timeBetween = myValue.Subtract(mySecondValue);
            var years = 0.0;
            var days = 0.0;
            var months = 0.0;
            var weeks = 0.0;
            timeBetweenText = 
            Console.WriteLine(timeBetween);
            /*if (timeBetween.TotalDays % 364 >= 0)
            {
                days = timeBetween.TotalDays % 364;
                years = Convert.ToDouble((timeBetween.TotalDays - days) / 364);
            }
            if (timeBetween.TotalDays % 364 > 0)
            {

            }
            if (days % 7 > 0)
            {
                days = days % 7;
                weeks = days / 7;
            }*/

        }
    }
}
