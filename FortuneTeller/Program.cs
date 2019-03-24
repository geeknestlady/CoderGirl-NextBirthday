using System;

namespace NextBirthday
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("When is your birthday?");
            string userBirthdayInput = Console.ReadLine();                     
            DateTime userBirthday = DateTime.Parse(userBirthdayInput);
            string nextBirthday = NextBirthdayDay(userBirthday);
            Console.WriteLine(nextBirthday);          
                               
                             
            Console.ReadLine();
        }
        public static string NextBirthdayDay (DateTime userBirthday)
        {

            DateTime currentDate = DateTime.Now;
            //int currentDateInt = Convert.ToInt32(currentDate);
            //int currentYear = currentDate.Year;
            //int birthdayMonth = userBirthday.Month;
            //int birthdayDay = userBirthday.Day;

            DateTime nextBirthday = userBirthday;
            if (currentDate > userBirthday)
            {
                nextBirthday = userBirthday.AddYears(1);
            } 
            else if (currentDate == userBirthday)
            {
                nextBirthday = userBirthday.AddDays(-1);
            }
            else
            {
                nextBirthday = userBirthday.AddYears(0);
            }
              
            return nextBirthday.DayOfWeek.ToString();
        }
        // TODO: Create a method that takes the date someone was born and returns the name of the day on their next birthday.
    }
}
