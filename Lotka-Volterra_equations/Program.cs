
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
            int[,] field = new int[22, 22]; //наше поле :)
            Random rnd = new Random();

            List<Wolf> wList = new List<Wolf>();       //список волков
            List<Sheep> sList = new List<Sheep>();      //список овец
            for (int i = 0; i < 5; i++)                           //добавляем волков
            {
                Wolf wolf = new Wolf(field, rnd.Next(5, 15), rnd.Next(5, 15));
                wList.Add(wolf);
                wolf.steps = 0;
            }
            for (int i = 0; i < 6; i++)                   //добавляем овец
            {
                Sheep sheep = new Sheep(field, rnd.Next(5, 15), rnd.Next(5, 15));
                sList.Add(sheep);
            }
            


            while (true)       //основной цикл
            {               
                DrawField();
                int P = wList.Count();
                for (int j = 0; j < P; j++)  //едим овец
                {
                    int CountWellFedWolfs = 0;
                    for (int i = 0; i < sList.Count(); i++)
                    {
                        wList[j].EatSheep(field, sList, i, out r);
                        if (r > 0 && i > 0)
                        {
                            i -= r;
                            CountWellFedWolfs += 1;
                        }
                        else if (r > 0)
                            i = 0;
                    }
                    if (CountWellFedWolfs > 0)       //множим волков
                    {
                        wList[j].Reproproduction(wList, field);
                    }
                }

                for (int j = 0; j < wList.Count(); j++)       //убиваем волков
                {
                    if (wList[j].steps %  4 == 0 && wList[j].steps > 0)
                    {
                        field[(wList[j]._x), (wList[j]._y)] = 0;
                        wList.RemoveAt(j);
                        if (j - 1 >= 0)
                            j--;
                        else if (j - 1 < 0)
                            j = 0;
                    }
                }

                if (countsteps > 0 && countsteps % 5 == 0)         //множим овец
                {
                    int R = sList.Count();
                    for (int i = 0; i < R; i++)
                    {
                        sList[i].Reproproduction(sList, field);
                    }
                }

                Console.ReadKey();   // дополнительная отрисовка поля (проверка на съедение овец)
                DrawField();

                for (int j = 0; j < wList.Count(); j++)  //волки ходят
                {
                    wList[j].Move(rnd.Next(0, 4),field);
                    wList[j].steps += 1;
                }
                for (int i = 0; i < sList.Count(); i++)   //овцы ходят
                {
                    sList[i].Move(rnd.Next(0, 4),field);
                }
                Console.ReadKey();
                countsteps += 1;
            }




            void DrawField()        //метод вырисовки поля
            {
                Console.Clear();
                for (int j = 1; j < field.GetLength(0) - 1; j++)
                {
                    for (int i = 1; i < field.GetLength(1) - 1; i++)
                    {
                        if (field[i, j] == 1)
                            Console.ForegroundColor = ConsoleColor.Yellow;
                        if (field[i, j] == 0)
                            Console.ForegroundColor = ConsoleColor.Green;
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
