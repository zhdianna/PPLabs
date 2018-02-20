using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SnakeExample
{
    class Program
    {

        // public static int direction = 1;

        /*public static void MoveFaster()
        {
            while (!Game.GameOver)
            {
                switch (direction)
                {
                    case 1:
                        Game.snake.Move(1, 0);
                        break;
                    case 2:
                        Game.snake.Move(-1, 0);
                        break;
                    case 3:
                        Game.snake.Move(-1, 0);
                        break;
                    case 4:
                        Game.snake.Move(0, -1);
                        break;
                }

                Game.Draw();
                Thread.Sleep(100);


            }
            */


        static void Main(string[] args)
        {

            Game.Init();


            //Thread t = new Thread(MoveFaster); // - making new thread
            //t.Start();

            ConsoleKeyInfo lastKey = Console.ReadKey();

            while (!Game.GameOver)
            {
                Game.Draw();

                ConsoleKeyInfo btn = Console.ReadKey();


                if (lastKey.Key == ConsoleKey.UpArrow)// если вверх

                {
                    

                    switch (btn.Key) // создаем положительные случаи

                    {

                        case ConsoleKey.UpArrow: // идти вверх
                                                 // direction = 4;
                            Game.snake.Move(0, -1);

                            break;

                        case ConsoleKey.DownArrow:
                            // direction = 3;
                            Game.snake.Move(-1, 0);

                            break;

                        case ConsoleKey.RightArrow: // идти вправо
                            //direction = 1;
                            Game.snake.Move(1, 0);

                            break;

                        case ConsoleKey.LeftArrow: // идти влево
                                                   // direction = 2;

                            Game.snake.Move(-1, 0);

                            break;

                    }


                }

                else if (lastKey.Key == ConsoleKey.DownArrow) // если вниз

                {

                    switch (btn.Key) // случаи

                    {

                        case ConsoleKey.DownArrow: // вниз

                            Game.snake.Move(0, 1);

                            break;



                        case ConsoleKey.RightArrow: // вправо

                            Game.snake.Move(1, 0);

                            break;

                        case ConsoleKey.LeftArrow: // влево

                            Game.snake.Move(-1, 0);

                            break;


                    }

                }

                else if (lastKey.Key == ConsoleKey.LeftArrow) // если влево

                {

                    switch (btn.Key)

                    {

                        case ConsoleKey.UpArrow: // вверх

                            Game.snake.Move(0, -1);

                            break;

                        case ConsoleKey.DownArrow: // вниз

                            Game.snake.Move(0, 1);

                            break;

                        case ConsoleKey.LeftArrow: // влево

                            Game.snake.Move(-1, 0);

                            break;

                    }

                }

                else if (lastKey.Key == ConsoleKey.RightArrow) // если вправо

                {
                   

                    switch (btn.Key)

                    {

                        case ConsoleKey.UpArrow: // вверх

                            Game.snake.Move(0, -1);

                            break;

                        case ConsoleKey.DownArrow: // вниз

                            Game.snake.Move(0, 1);

                            break;

                        case ConsoleKey.RightArrow: // вправо

                            Game.snake.Move(1, 0);

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



                if (btn.Key == ConsoleKey.S) //- serilization method
                    Game.Seer();

                if (btn.Key == ConsoleKey.D)
                    Game.Deeser();

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

                if (Game.snake.body[0].x > 69)
                    Game.snake.body[0].x = 0;
                if (Game.snake.body[0].x < 0)
                    Game.snake.body[0].x = 69;

                if (Game.snake.body[0].y > 19)
                    Game.snake.body[0].y = 0;
                if (Game.snake.body[0].y < 0)
                    Game.snake.body[0].y = 19;



                if (Game.snake.Eat(Game.food))
                {
                    Game.food.SetRandomPosition();
                }

            }





        }

    }
    }

