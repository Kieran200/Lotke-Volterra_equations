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
    }
}
