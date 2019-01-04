using System;

namespace TicTacToe
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Field a = new Field();
        }


    }

    class Field {

        int[,] field = new int[3, 3];



    }
}
