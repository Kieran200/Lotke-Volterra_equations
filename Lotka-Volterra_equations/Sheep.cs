using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotkaVolterra_equations
{
    class Sheep : Animal
    {
        public Sheep(int[,] field, int x, int y) : base(field, x, y)
        {
            TypeOfAnimal = 1;
            _field[_x, _y] = TypeOfAnimal;
        }

        public void Reproproduction(List<Sheep> sList, int[,] field)
        {
            for (int j = 0; j < 1; j++)
            {
                if (field[_x, _y+1] == 0 && _y + 1 < _field.GetLength(1)) 
                {
                    Sheep newsheep = new Sheep(field, (_x), (_y + 1));
                    sList.Add(newsheep);
                    break;
                }
                if (field[_x, _y - 1] == 0 && _y - 1 > _field.GetLength(1)) 
                {
                    Sheep newsheep = new Sheep(field, (_x ), (_y - 1));
                    sList.Add(newsheep);
                    break;
                }
                if (field[_x + 1, _y] == 0 && _x + 1 < _field.GetLength(0))
                {
                    Sheep newsheep = new Sheep(field, (_x + 1), (_y));
                    sList.Add(newsheep);
                    break;
                }
                if (field[_x-1, _y] == 0 && _x - 1 > _field.GetLength(0))
                {
                    Sheep newsheep = new Sheep(field, (_x - 1), (_y));
                    sList.Add(newsheep);
                    break;
                }
                if (field[_x+1, _y + 1] == 0 && _y + 1 < _field.GetLength(1) && _x + 1 < _field.GetLength(0))
                {
                    Sheep newsheep = new Sheep(field, (_x + 1), (_y + 1));
                    sList.Add(newsheep);
                    break;
                }
                if (field[_x+1, _y - 1] == 0 && _y - 1 > _field.GetLength(1) && _x + 1 < _field.GetLength(0))
                {
                    Sheep newsheep = new Sheep(field, (_x + 1), (_y - 1));
                    sList.Add(newsheep);
                    break;
                }
                if (field[_x-1, _y + 1] == 0 && _y + 1 < _field.GetLength(1) && _x - 1 > _field.GetLength(0))
                {
                    Sheep newsheep = new Sheep(field, (_x - 1), (_y + 1));
                    sList.Add(newsheep);
                    break;
                }
                if (field[_x-1, _y - 1] == 0 && _y - 1 > _field.GetLength(1) && _x - 1 > _field.GetLength(0))
                {
                    Sheep newsheep = new Sheep(field, (_x - 1), (_y - 1));
                    sList.Add(newsheep);
                    break;
                }
            }
        }
    }
}
