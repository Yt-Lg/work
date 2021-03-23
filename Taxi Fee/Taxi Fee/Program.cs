using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi_Fee
{
    class Program
    {
        static void Main(string[] args)
        {

            
            while(true)
            {
                Console.WriteLine("How many Passengers?");
                int passengers = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("What Distance?");
                int distance = Convert.ToInt32(Console.ReadLine());

                double totalcost = ( 2 * distance + 1);

                if (passengers >= 5)
                {
                    totalcost += (totalcost / 2);
                }

                Console.WriteLine("total cost of ride is: £" + totalcost);



            }
          

        }
    }
}
