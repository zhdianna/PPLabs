using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeExample
{
    class Wall
    {
        public List<Point> body;
        public char sign;
        public ConsoleColor color;
        public string line = "";

        public Wall()
        {
            sign = '#';
            color = ConsoleColor.Magenta;
            body = new List<Point>();
            LoadLevel(1);
        }

        public void LoadLevel(int level)
        {
            string fileName = string.Format(@"C:\Users\dianna\Desktop\level1.txt", level);
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            int row = 0;
            
            while(row < 20)
            {
                line = sr.ReadLine();
                for(int col = 0; col < line.Length; col++)
                {
                    if (line[col] == '#')
                        body.Add(new Point(col, row));
                }
                row++;
            }
        }

        public Boolean CheckWall()
        {
            int row = 0;

            while (row < 20)
            {
                for (int col = 0; col < line.Length; col++)
                {
                    if (line[col] == '#')
                        return false;
                    else continue;
                }
                row++;
            }
            return true;
        }

        public Boolean CheckWallForSnake(int x, int y)
        {
            int row = 0;

            while (row < 20)
            {
                for (int col = 0; col < line.Length; col++)
                {
                    if (line[col] == '#')
                    {
                        if (x == col && y == row)
                            return false;
                    }
                       
                }
                row++;
            }
            //Console.Write(line.Length);
            return true;
        }


        public void Draw()
        {
            Console.ForegroundColor = color;
            foreach(Point p in body)
            {
                Console.SetCursorPosition(p.x, p.y);
                Console.Write(sign);
            }
        }
    }
}
