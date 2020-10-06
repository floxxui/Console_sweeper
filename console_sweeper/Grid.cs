using System;

namespace console_sweeper
{
    public class Grid
    {
        public int[,] gridSize = new int[10, 10];
        //skapa en grid som är 10*10

        public void CreateGrid()
        {
            

            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    gridSize[x,y] = 9;
                    System.Console.Write(gridSize[x,y] + " ");
                }
                System.Console.WriteLine("");
            }
            Console.ReadLine();
        }

        public void BombLocation() 
        {

        }
    }
}
