using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SnakeExample
{
    class Game
    {
        public static Snake snake;
        public static Food food;

        public static Wall wall;

        public static bool GameOver = false;
        public static void GameOverMethod()
        {
            for(int i = 0; i < wall.body.Count; i++)
            {
                if(snake.body[0].x == wall.body[i].x && snake.body[0].y == wall.body[i].y)
                {
                    GameOver = true;
                    Console.Clear();
                    Console.SetCursorPosition(30, 11);
                    Console.WriteLine("Game Over");
                    Console.ReadKey();
                }
            }
            

        }



        public static void Init()

        {

            Console.CursorVisible = false;

            Console.SetWindowSize(70, 20);



            GameOver = false;



            snake = new Snake();

            food = new Food();

            wall = new Wall();


        }



        public static void Draw()

        {

            Console.Clear();

            snake.Draw();

            food.Draw();

            wall.Draw();

        }


        
        public static void  Seer()
        {
            Snake.f1();
        }

        public static void Deeser()
        {
            Snake.f2();
        }


        // serialize objects (Save function)

        // desiralize objects (Resume function)

    }

}

