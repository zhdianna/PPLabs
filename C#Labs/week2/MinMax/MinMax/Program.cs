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

            ws.WriteLine("Max is" + all.Max() + "  " + "Min is" + all.Min() );
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
