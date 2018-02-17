using System;

namespace HW4
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Please enter your birthday in format DD/MM/YYYY");
      DateTime date = new DateTime();
      var birthDay = Console.ReadLine();
      
      // date = Convert.ToDateTime(birthDay);
      date = DateTime.ParseExact(birthDay, "dd/MM/yyyy",  System.Globalization.CultureInfo.CurrentCulture);
      switch(date.Month)
      {
        case 1:
            if(date.Day <= 19)
            {
              PrintZodiac("Capricorn");
            }
            else
            {
              PrintZodiac("Aquarius");
            }
            break;
        case 2:
            if(date.Day <= 18)
            {
              PrintZodiac("Aquarius");
            }
            else
            {
              PrintZodiac("Pisces");
            }
            break;
        case 3:
            if(date.Day <= 20)
            {
              PrintZodiac("Pisces");
            }
            else
            {
              PrintZodiac("Aries");
            }
            break;
        case 4:
            if(date.Day <= 19)
            {
              PrintZodiac("Aries");
            }
            else
            {
              PrintZodiac("Taurus");
            }
            break;
        case 5:
            if(date.Day <= 20)
            {
              PrintZodiac("Taurus");
            }
            else
            {
              PrintZodiac("Gemini");
            }
            break;
        case 6:
            if(date.Day <= 20)
            {
              PrintZodiac("Gemini");
            }
            else
            {
              PrintZodiac("Cancer");
            }
            break;
        case 7:
            if(date.Day <= 22)
            {
              PrintZodiac("Cancer");
            }
            else
            {
              PrintZodiac("Leo");
            }
            break;
        case 8:
            if(date.Day <= 22)
            {
              PrintZodiac("Leo");
            }
            else
            {
              PrintZodiac("Virgo");
            }
            break;
        case 9:
            if(date.Day <= 22)
            {
              PrintZodiac("Virgo");
            }
            else
            {
              PrintZodiac("Libra");
            }
            break;
        case 10:
            if(date.Day <= 22)
            {
              PrintZodiac("Libra");
            }
            else
            {
              PrintZodiac("Scorpio");
            }
            break;
        case 11:
            if(date.Day <= 21)
            {
              PrintZodiac("Scorpio");
            }
            else
            {
              PrintZodiac("Sagittarius");
            }
            break;
        case 12:
            if(date.Day <= 21)
            {
              PrintZodiac("Sagittarius");
            }
            else
            {
              PrintZodiac("Capricorn");
            }
            break;
        default:
          break;
      }
    }

    static void PrintZodiac(string zodiac)
    {
        Console.WriteLine("Your zodiac is {0}", zodiac);
    }
  }
}
