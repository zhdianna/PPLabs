using System;

using System.Collections.Generic;

using System.IO;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace FarManager

{

    class Program

    {
        static void showFile(string path)

        {

            Console.CursorVisible = false;

            FileStream file = new FileStream(path, FileMode.Open, FileAccess.ReadWrite);

            StreamReader reading = new StreamReader(file);

            string text = reading.ReadToEnd();



            Console.Clear();

            Console.WriteLine();

            Console.WriteLine(text);



            file.Close();

            reading.Close();



            ConsoleKeyInfo btn = Console.ReadKey();

            while (btn.Key != ConsoleKey.Escape)

            {

                btn = Console.ReadKey();

            }



        }

        static void showFolderContent(DirectoryInfo cur, int pos)

        {

            FileSystemInfo[] data = cur.GetFileSystemInfos();

            for (int i = 0; i < data.Length; i++)

            {

                if (i == pos)

                    Console.BackgroundColor = ConsoleColor.White;

                else

                    Console.BackgroundColor = ConsoleColor.Black;



                if (data[i].GetType() == typeof(DirectoryInfo))

                    Console.ForegroundColor = ConsoleColor.Blue;

                else

                    Console.ForegroundColor = ConsoleColor.Red;




                Console.WriteLine(data[i].Name);

            }



        }



        static void Main(string[] args)

        {

            Console.CursorVisible = false;

            int pos = 0;



            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\dianna\Desktop\PPLabs");



            while (true)

            {

                Console.Clear();

                showFolderContent(dir, pos);



                ConsoleKeyInfo btn = Console.ReadKey();

                switch (btn.Key)

                {

                    case ConsoleKey.UpArrow:

                        pos--;

                        if (pos < 0)


                            pos = dir.GetFileSystemInfos().Length - 1;

                        break;


                    case ConsoleKey.DownArrow:

                        pos++;
                        if (pos >= dir.GetFileSystemInfos().Length)

                            pos = 0;
                        Console.BackgroundColor = ConsoleColor.Black;


                        break;

                    case ConsoleKey.Enter:

                        FileSystemInfo f = dir.GetFileSystemInfos()[pos];

                        if (f.GetType() == typeof(DirectoryInfo))
                        {
                            try
                            {
                                dir = new DirectoryInfo(f.FullName);
                            }
                            catch (Exception e)
                            {

                            }

                        }

                        else
                        {
                            string v = f.FullName;
                            showFile(v);





                        }

                        break;
                    case ConsoleKey.Backspace:
                        dir = dir.Parent;
                        break;
                    case ConsoleKey.Escape:
                        break;



                }

            }





        }

    }

}