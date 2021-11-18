
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
            int countsteps = 0;      //счет ходов
            int[,] field = new int[20, 20];   //наше поле :)
            Random rnd = new Random();

            List<Wolf> wList = new List<Wolf>();       //список волков
            List<Sheep> sList = new List<Sheep>();      //список овец
            for (int i = 0; i < 3; i++)                           //добавляем волков
            {
                Wolf wolf = new Wolf(field, rnd.Next(5, 15), rnd.Next(5, 15));
                wList.Add(wolf);
            }
            for (int i = 0; i < 6; i++)                   //добавляем овец
            {
                Sheep sheep = new Sheep(field, rnd.Next(5, 15), rnd.Next(5, 15));
                sList.Add(sheep);
            }
            

            while (true)       //основной цикл
            {
                countsteps += 1;
                DrawField();
                for (int j = 0; j < wList.Count(); j++)
                {
                    for (int i = 0; i < sList.Count(); i++)
                    {
                        wList[j].EatSheep(field, sList, i, out r);
                        if (r > 0 && i > 0)
                            i -= r;
                        else if (r > 0)
                            i = 0;
                    }
                }
                Console.ReadKey();
                DrawField();
                for (int j = 0; j < wList.Count(); j++)
                {
                    wList[j].Move(rnd.Next(0, 4),field);
                }
                for (int i = 0; i < sList.Count(); i++)
                {
                    sList[i].Move(rnd.Next(0, 4),field);
                }
                
                Console.ReadKey();
            }

            void DrawField()        //метод вырисовки поля
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
