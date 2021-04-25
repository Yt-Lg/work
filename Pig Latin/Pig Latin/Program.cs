using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pig_Latin
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)

            {

                try
                {
                    
                    Console.WriteLine("\n\ninput phrase\n");

                    string phrase = Console.ReadLine();
                    Console.WriteLine("\n");

                    string[] words = phrase.Split();



                    foreach (var word in words)
                    {
                        Console.Write(word.Substring(1));
                        Console.Write((word.Substring(0, 1) + "ay "));
                    }

                }

                catch
                {
                    Console.WriteLine("Invalid Input");
                }



            }
        }
    }
}
