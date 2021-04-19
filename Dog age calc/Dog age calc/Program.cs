using System;

namespace Dog_age_calc
{
    class Program
    {
        static void Main(string[] args)
        {
          

            while(true)
                
            {

                int finaldogage = 0;
                int dogage = 0;
                int dogage2 = 0;


                Console.WriteLine("How many human years is your dog?");
                int humanage = Convert.ToInt32(Console.ReadLine());

                dogage = (humanage * 7);

                if (humanage >= 1)
                {
                    dogage2 += 8;

                }

                if (humanage >= 2)
                {
                    dogage2 += 3;
                }

                finaldogage = (dogage + dogage2);

                Console.WriteLine("your dog's age in human teams is " + finaldogage);
            }
        }
    }
}
