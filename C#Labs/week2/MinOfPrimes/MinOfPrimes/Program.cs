using System;
using System.Collections.Generic;
using System.IO;
using System.Linq; 
using System.Text;
using System.Threading.Tasks;

namespace MinOfPrimes
{
    class Program
    {

        static public void Sol()
        {

            bool ifPrime(int a)
            {
                int x = a;
                for (int i = 2; i <= Math.Sqrt(x); i++) //sorting out the numbers from 2 to square root of x
                {
                    if (x % i == 0)
                    {
                        return false;
                    }
                }

                return true;
            }
            StreamReader r = new StreamReader(@"C:\Users\dianna\Desktop\primeNum\text.txt");
            StreamWriter w = new StreamWriter(@"C:\Users\dianna\Desktop\primeNum\text1.txt");

            string[] all = r.ReadLine().Split();
            int ind = 0;
            List<int> allPrimes = new List<int>();

            foreach (string s in all) // checking each element
            {


                int x = int.Parse(s); // converting to int

                if(ifPrime(x))
                {
                    allPrimes.Add(x);
                    ind++;
                }


         }
            

            w.WriteLine("Min is " + allPrimes.Min());
            w.Close();
            r.Close();

        }

        static void Main(string[] args)
        {
            Sol();
            Console.ReadKey();
        }
    }
}





