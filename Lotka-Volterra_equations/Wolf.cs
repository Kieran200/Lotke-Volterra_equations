using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotkaVolterra_equations
{
    class Wolf : Animal
    {
        public Wolf(int[,] field, int x, int y) : base(field, x, y)
        {
            TypeOfAnimal = 2;
            _field[_x, _y] = TypeOfAnimal;
        }
        public void EatSheep(int[,] field, List<Sheep> sList, int i, out int r)
        {
            r = 0;
            if (field[_x, (_y + 1)] == sList[i].TypeOfAnimal)
            {
                sList.RemoveAt(i);
                field[_x, (_y + 1)] = 0;
                r += 1;
            }
            if (field[_x, (_y - 1)] == sList[i].TypeOfAnimal)
            {
                sList.RemoveAt(i);
                field[_x, (_y - 1)] = 0;
                r += 1;
            }
            if (field[(_x + 1), _y] == sList[i].TypeOfAnimal)
            {
                sList.RemoveAt(i);
                field[(_x + 1), _y] = 0;
                r += 1;
            }
            if (field[(_x - 1), _y] == sList[i].TypeOfAnimal)
            {
                sList.RemoveAt(i);
                field[(_x - 1), _y] = 0;
                r += 1;
            }
            if (field[(_x + 1), (_y + 1)] == sList[i].TypeOfAnimal)
            {
                sList.RemoveAt(i);
                field[(_x + 1), (_y + 1)] = 0;
                r += 1;
            }
            if (field[(_x +1), (_y - 1)] == sList[i].TypeOfAnimal)
            {
                sList.RemoveAt(i);
                field[(_x + 1), (_y - 1)] = 0;
                r += 1;
            }
            if (field[(_x - 1) , (_y + 1)] == sList[i].TypeOfAnimal)
            {
                sList.RemoveAt(i);
                field[(_x - 1), (_y + 1)] = 0;
                r += 1;
            }
            if (field[(_x - 1), (_y - 1)] == sList[i].TypeOfAnimal)
            {
                sList.RemoveAt(i);
                field[(_x - 1), (_y - 1)] = 0;
                r += 1;
            }
        }

    }           

            
}
