using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime
{
    class PrimeN
    {

        static void Main(string[] args)
        {
            string no = Console.ReadLine(); // - input
            args = no.Split(' '); 

            foreach (string s in args) // checking each element
            {
                int x = int.Parse(s); // converting to int
                bool Prime = true;
                for (int i = 2; i *i <= x; i++) //sorting out the numbers from 2 to square root of x
                {
                    if(x% i == 0)
                    {
                        Prime = false;
                        break;

                    }
                }
            if(Prime == true)
            {
                Console.WriteLine(x + "is a prime number,yeahhhy");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine(x + "is not a prime number,yeahhhy");
                Console.ReadKey();
            }

        }
        }
    }
}


