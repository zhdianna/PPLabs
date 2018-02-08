using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.SetWindowSize(70, 20);

            Snake snake = new Snake();
            Food food = new Food();
            Wall wall = new Wall();

            if (!snake.Collision()) {
                Console.Clear();

            }



            ConsoleKeyInfo lastKey = Console.ReadKey();
            while (true)
            {
                Console.Clear();
                snake.Draw();
                food.Draw();
                wall.Draw();

                ConsoleKeyInfo btn = Console.ReadKey();
                

                if (lastKey.Key == ConsoleKey.UpArrow)// если вверх

                {

                    switch (btn.Key) // создаем положительные случаи

                    {

                        case ConsoleKey.UpArrow: // идти вверх

                            snake.Move(0, -1);

                            break;

                        case ConsoleKey.RightArrow: // идти вправо

                            snake.Move(1, 0);

                            break;

                        case ConsoleKey.LeftArrow: // идти влево

                            snake.Move(-1, 0);

                            break;

                    }

                }

                else if (lastKey.Key == ConsoleKey.DownArrow) // если вниз

                {

                    switch (btn.Key) // случаи

                    {

                        case ConsoleKey.DownArrow: // вниз

                            snake.Move(0, 1);

                            break;

                        case ConsoleKey.RightArrow: // вправо

                            snake.Move(1, 0);

                            break;

                        case ConsoleKey.LeftArrow: // влево

                            snake.Move(-1, 0);

                            break;

                    }

                }

                else if (lastKey.Key == ConsoleKey.LeftArrow) // если влево

                {

                    switch (btn.Key)

                    {

                        case ConsoleKey.UpArrow: // вверх

                            snake.Move(0, -1);

                            break;

                        case ConsoleKey.DownArrow: // вниз

                            snake.Move(0, 1);

                            break;

                        case ConsoleKey.LeftArrow: // влево

                            snake.Move(-1, 0);

                            break;

                    }

                }

                else if (lastKey.Key == ConsoleKey.RightArrow) // если вправо

                {

                    switch (btn.Key)

                    {

                        case ConsoleKey.UpArrow: // вверх

                            snake.Move(0, -1);

                            break;

                        case ConsoleKey.DownArrow: // вниз

                            snake.Move(0, 1);

                            break;

                        case ConsoleKey.RightArrow: // вправо

                            snake.Move(1, 0);

                            break;

                    }

                }
                if (btn.Key == ConsoleKey.LeftArrow && lastKey.Key != ConsoleKey.RightArrow) // невозможные случаи

                    lastKey = btn;

                if (btn.Key == ConsoleKey.RightArrow && lastKey.Key != ConsoleKey.LeftArrow)

                    lastKey = btn;

                if (btn.Key == ConsoleKey.UpArrow && lastKey.Key != ConsoleKey.DownArrow)

                    lastKey = btn;

                if (btn.Key == ConsoleKey.DownArrow && lastKey.Key != ConsoleKey.UpArrow)

                    lastKey = btn;


                /*switch (btn.Key)
                {
                    case ConsoleKey.UpArrow:
                        snake.Move(0, -1);
                        if (lastKey.Equals( ConsoleKey.DownArrow))
                        {
                            

                        }
                        lastKey = btn;
                        break;
                    case ConsoleKey.DownArrow:
                        snake.Move(0, 1);
                        lastKey = btn;
                        break;
                    case ConsoleKey.LeftArrow:
                        snake.Move(-1, 0);
                        lastKey = btn;
                        break;
                    case ConsoleKey.RightArrow:
                        snake.Move(1, 0);
                        lastKey = btn;
                        break;
                }
                */

                if (snake.body[0].x > 69)
                    snake.body[0].x = 0;
                if (snake.body[0].x < 0)
                    snake.body[0].x = 69;

                if (snake.body[0].y > 19)
                    snake.body[0].y = 0;
                if (snake.body[0].y < 0)
                    snake.body[0].y = 19;



                if (snake.Eat(food))
                {
                    food.SetRandomPosition();
                }

            }

            
        }
    }
}
