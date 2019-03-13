using System;

namespace NextBirthday
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("When is your birthday?");
            string userBirthdayInput = Console.ReadLine();
            userBirthdayInput = String.Format("{0:MM/dd}", userBirthdayInput);
            //Console.WriteLine("Has your birthday already passed this year?");
            string userQuestion = Console.ReadLine();
            
            
            DateTime userBirthday = DateTime.Parse(userBirthdayInput);
            string nextBirthday = NextBirthdayDay(userBirthday);
            Console.WriteLine(nextBirthday);           
                               
                             
            Console.ReadLine();
        }
        public static string NextBirthdayDay (DateTime userBirthday)
        {

            DateTime currentDate = DateTime.Now;
            TimeSpan yearsBetween = currentDate.Subtract(userBirthday);
            string daysBetween = yearsBetween.TotalDays.ToString();
            //int daysBetweenInt = int.Parse(daysBetween);
            //int yearsTotalBetween = daysBetweenInt / 365;
            DateTime nextBirthday = userBirthday.AddYears(1);
            
            
            
            //string daysBetween = countdown.TotalDays.ToString();
            //int daysBetweenint = Convert.ToInt32(daysBetween);

            return nextBirthday.DayOfWeek.ToString();
        }
        // TODO: Create a method that takes the date someone was born and returns the name of the day on their next birthday.
    }
}
