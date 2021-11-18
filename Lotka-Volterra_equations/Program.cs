
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotkaVolterra_equations
{
    class Program
    {
        static void Main(string[] args)
        {
            int r = 0;
            int countsteps = 0;
            int[,] field = new int[20, 20];
            Random rnd = new Random();

            List<Wolf> wList = new List<Wolf>();
            List<Sheep> sList = new List<Sheep>();
            for (int i = 0; i < 3; i++)
            {
                Wolf wolf = new Wolf(field, rnd.Next(5, 15), rnd.Next(5, 15));
                wList.Add(wolf);
            }
            for (int i = 0; i < 6; i++)
            {
                Sheep sheep = new Sheep(field, rnd.Next(5, 15), rnd.Next(5, 15));
                sList.Add(sheep);
            }
            

            while (true)
            {
                countsteps += 1;
                DrawField();
                foreach (var wolf in wList)
                {
                    for (int i = 0; i < sList.Count(); i++)
                    {
                        wolf.EatSheep(field, sList, i, out r);
                        if (r > 0 && i > 0)
                            i -= r;
                        else if (r > 0)
                            i = 0;
                    }
                }
                Console.ReadKey();
                DrawField();
                foreach (var wolf in wList)
                {
                    wolf.Move(rnd.Next(0, 4));
                }
                foreach (var sheep in sList)
                {
                    sheep.Move(rnd.Next(0, 4));
                }
                Console.ReadKey();
            }

            void DrawField()
            {
                Console.Clear();
                for (int j = 0; j < field.GetLength(0); j++)
                {
                    for (int i = 0; i < field.GetLength(1); i++)
                    {
                        if (field[i, j] == 1)
                            Console.ForegroundColor = ConsoleColor.Yellow;
                        if (field[i, j] == 2)
                            Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(field[i, j]);
                        Console.ResetColor();
                    }
                    Console.WriteLine("");
                }
            }
        }
    }
}
