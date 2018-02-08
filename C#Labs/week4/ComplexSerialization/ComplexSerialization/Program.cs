
using System;

using System.Collections.Generic;

using System.IO;

using System.Linq;

using System.Runtime.Serialization.Formatters.Binary;

using System.Text;

using System.Threading.Tasks;

using System.Xml.Serialization;



namespace ComplexSerialization

{
    [Serializable]
    class Program

    {



        static void f1()

        {

            FileStream fs = new FileStream(@"dat2.ser", FileMode.Create, FileAccess.Write);



            Complex s = new Complex();

            BinaryFormatter bf = new BinaryFormatter();

            try

            {

                bf.Serialize(fs, s);

            }

            catch (Exception e)

            {

                Console.WriteLine(e.Message);

            }

            finally

            {

                fs.Close();

            }



            Console.WriteLine("done");

        }



        static void f2()

        {

            FileStream fs = new FileStream(@"dat2.ser", FileMode.Open, FileAccess.Read);

            BinaryFormatter bf = new BinaryFormatter();



            try

            {

                Complex s = bf.Deserialize(fs) as Comlex;



                Console.WriteLine(s);

            }

            catch (Exception e)

            {

                Console.WriteLine(e.Message);

            }

            finally

            {

                fs.Close();

            }

        }



        static void Main(string[] args)

        {

            f2();

            Console.ReadKey();


            Complex a = new Complex(1, 2);

            Complex b = new Complex(1, 2);



            Console.WriteLine(a + b);



            Console.ReadKey();

        }

    }

}
