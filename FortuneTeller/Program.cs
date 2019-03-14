using System;

namespace NextBirthday
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("When is your birthday?");
            string userBirthdayInput = Console.ReadLine();
            //userBirthdayInput = String.Format("{0:MM/dd}", userBirthdayInput);
            //Console.WriteLine("Has your birthday already passed this year?");
            //string userQuestion = Console.ReadLine();
            
            
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
            if (currentDate >= userBirthday)
            {
                nextBirthday = userBirthday.AddYears(1);
            }            
              
            return nextBirthday.DayOfWeek.ToString();
        }
        // TODO: Create a method that takes the date someone was born and returns the name of the day on their next birthday.
    }
}
