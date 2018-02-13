using System;

namespace StructsAndEnums
{
    class Program
    {
        static void DoWork()
        {
            var weddingAnniversary = new Date(2013, Month.April, 4);
            Console.WriteLine(weddingAnniversary);

            var weddingAnniversaryCopy = weddingAnniversary;
            Console.WriteLine("Value of copy is {0}", weddingAnniversaryCopy);
            
            weddingAnniversary.AdvanceMonth();
            Console.WriteLine("New value of weddingAnniversary is {0}", weddingAnniversary);
            Console.WriteLine("Value of copy is still {0}", weddingAnniversaryCopy); 
        }

        static void Main()
        {
            try
            {
                DoWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
