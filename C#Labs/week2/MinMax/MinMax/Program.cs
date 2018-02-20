using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMax
{
    class Program
    {
        
        
        static void f1()
        {
            FileStream f = new FileStream(@"C:\Users\dianna\Desktop\minAndmax\text.txt", FileMode.Open, FileAccess.Read);
            StreamReader fs = new StreamReader(f);
            StreamWriter ws = new StreamWriter(@"C:\Users\dianna\Desktop\minAndmax\text1.txt");
            string[] all = fs.ReadLine().Split();

            int maxi = int.Parse(all[0]);
            int mini = int.Parse(all[1]);

            foreach (string s in all) // checking each element
            {
                int x = int.Parse(s); // converting to int
                if (x > maxi)
                {
                    maxi = x;
                }

            }

            foreach(string s in all)
            {
                int x = int.Parse(s);
                if (x < mini) {
                    mini = x;
                }
            }




            ws.WriteLine("Max is" + maxi + "  " + "Min is" + mini );
            fs.Close();
            f.Close();
            ws.Close();

         


        }
        static void Main(string[] args)
        {
            f1();
            Console.ReadKey();
        }
        

       
    }
}
