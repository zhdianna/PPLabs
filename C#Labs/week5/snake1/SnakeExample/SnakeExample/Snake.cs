using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeExample
{
    class Snake
    {
        public List<Point> body;
        public char sign;
        public ConsoleColor color;
        public Wall w = new Wall();

        public Snake()
        {
            sign = 'o';
            color = ConsoleColor.Yellow;
            body = new List<Point>();

            body.Add(new Point(11, 10));
            body.Add(new Point(10, 10));
            body.Add(new Point(9, 10));
        }

        public void Move(int dx, int dy)
        {
            /*Point lastPoint = body[body.Count - 1];
            Console.SetCursorPosition(lastPoint.x, lastPoint.y);
            Console.Write(' ');
            */

            for(int i = body.Count - 1; i > 0; i--)
            {
                
                    body[i].x = body[i - 1].x;
                    body[i].y = body[i - 1].y;
                
             
            }

            body[0].x = body[0].x + dx;
            body[0].y = body[0].y + dy;
            

        }

        public bool Eat(Food food)
        {
            if(body[0].x == food.location.x 
                && body[0].y == food.location.y)
            {
                body.Add(new Point(body[body.Count - 1].x, body[body.Count - 1].y));
                return true;
            }
            return false;
        }

        public Boolean Collision()
        {
            bool notOk = true;

            for (int i = 2; i < 15; i++)
            {
                if (body[0].x == 12 && body[0].y == i)
                {
                    Console.Clear();

                    Console.SetCursorPosition(30, 11);

                    Console.Write("GAME OVER!!");
                    return false;
                }

            }


            for (int i = 12; i < 25; i++)
            {
                if (body[0].x == i && body[0].y == 1)
                {
                    Console.Clear();
                    Console.SetCursorPosition(30, 11);

                    Console.Write("GAME OVER!!");
                    return false;
                }
            }
            return true;
        }


        public void Draw()
        {
            
            for (int i = 0; i < body.Count; i++)
            {
                /*if (i == 0)
                    Console.ForegroundColor = ConsoleColor.Red;
                else
                    Console.ForegroundColor = color;*/


                Console.ForegroundColor = (i == 0) ? ConsoleColor.Red : color;
                Console.SetCursorPosition(body[i].x, body[i].y);
                Console.Write(sign);
            }

            for(int i = 1; i <body.Count; i++)
            {
                if(body[0].x == body[i].x && body[0].y == body[i].y)

                {
                    Console.SetCursorPosition(30, 11);
                    Console.WriteLine("GAME OVER!");
                }
            }



            /*          int index = 0;
                        foreach (Point p in body)
                        {
                            if (index == 0)
                                Console.ForegroundColor = ConsoleColor.Red;
                            else
                                Console.ForegroundColor = color;
                            Console.SetCursorPosition(p.x, p.y);
                            Console.Write(sign);
                            index++;
                        }*/

            /*if (!w.CheckWallForSnake(body[0].x, body[0].y)) {
                Console.SetCursorPosition(30, 11);

                Console.Write("GAME OVER!!");
                
            }
            */

            Collision();
           
        }
    }
}
