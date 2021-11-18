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
            for (int j = 0; j < 1; j++)
            {
                if (_x == sList[i]._x && _y + 1 == sList[i]._y) // сосед снизу
                {
                    sList.RemoveAt(i);
                    field[_x, (_y + 1)] = 0;
                    r += 1;
                    break;
                }
                if (_x == sList[i]._x && _y - 1 == sList[i]._y) //сосед сверху
                {
                    sList.RemoveAt(i);
                    field[_x, (_y - 1)] = 0;
                    r += 1;
                    break;
                }
                if (_x + 1 == sList[i]._x && _y == sList[i]._y) //сосед справа
                {
                    sList.RemoveAt(i);
                    field[(_x + 1), _y] = 0;
                    r += 1;
                    break;
                }
                if (_x - 1 == sList[i]._x && _y == sList[i]._y) //сосед слева
                {
                    sList.RemoveAt(i);
                    field[(_x - 1), _y] = 0;
                    r += 1;
                    break;
                }
                if (_x + 1 == sList[i]._x && _y + 1 == sList[i]._y) //сосед справа снизу
                {
                    sList.RemoveAt(i);
                    field[(_x + 1), (_y + 1)] = 0;
                    r += 1;
                    break;
                }
                if (_x + 1 == sList[i]._x && _y - 1 == sList[i]._y) //сосед справа сверху
                {
                    sList.RemoveAt(i);
                    field[(_x + 1), (_y - 1)] = 0;
                    r += 1;
                    break;
                }
                if (_x - 1 == sList[i]._x && _y + 1 == sList[i]._y) //сосед слева снизу
                {
                    sList.RemoveAt(i);
                    field[(_x - 1), (_y + 1)] = 0;
                    r += 1;
                    break;
                }
                if (_x - 1 == sList[i]._x && _y - 1 == sList[i]._y) //сосед слева сверху
                {
                    sList.RemoveAt(i);
                    field[(_x - 1), (_y - 1)] = 0;
                    r += 1;
                    break;
                }
            }
        }
    }                 
}
