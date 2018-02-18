using System;

namespace figure
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isEscape = true;
            while(isEscape) {

                Console.WriteLine("Select figure Triangle, Square, Romb");
                var figure = Console.ReadLine();
                Console.WriteLine("How many lines do you want to pain?");
                var lines = int.Parse(Console.ReadLine());

                switch (figure)
                {
                    case ("Triangle"):
                        drawTriangle(lines);
                        break;
                    case ("Square"):
                        drawSquare(lines);
                        break;
                    case ("Romb"):
                        drawRomb(lines);
                        break;
                    default:
                        break;
                }

                Console.WriteLine("Do you want to continue... Y / N");
                if(Console.ReadLine() == "N")
                {
                    isEscape = false;
                }
            }
        }

        static void drawTriangle(int lines)
        {
            for(int i = 0; i < lines; i++)
            {
                for(int j = 0; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
        static void drawSquare(int lines)
        {
             for(int i = 0; i < lines; i++)
            {
                for(int j = 0; j < lines; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
        static void drawRomb(int lines)
        {
             int i, j, k;
            for(i = 0; i <= lines; i++)
            {   
                for(k = 0; k < lines-i; k++)
                {
                    Console.Write("  ");
                }
                
                for(j = 0; j <  2 * i - 1; j++)
                {
                    Console.Write("* ");
                }
                Console.Write("\n");           
            }
            for(i = lines - 1; i > 0; i--)
            {   
                for(k = 0; k < lines - i; k++)
                {
                    Console.Write("  ");
                }
                
                for(j = 0; j < i * 2 - 1; j++)
                {
                    Console.Write("* ");
                }
                Console.Write("\n");           
            }
        }
    }
}
