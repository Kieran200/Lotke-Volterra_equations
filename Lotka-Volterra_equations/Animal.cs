using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotkaVolterra_equations
{
    abstract class Animal
    {
        Random rnd = new Random();
        public int _x;
        public int _y;
        public int[,] _field;
        public int TypeOfAnimal;
        public int steps;
        public Animal(int[,] field, int x, int y)
        {
            TypeOfAnimal = 0;
            _field = field;
            _x = x;
            _y = y;
            _field[_x, _y] = TypeOfAnimal;
            
        }

        public void Move(int direction, int [,] field)
        {
            _field[_x, _y] = 0;
            switch (direction)
            {
                case 0:
                    {
                        if (_x+1 < (_field.GetLength(0)-1) && field [_x+1,_y] == 0)
                        {
                            _x = _x +1;
                            break;
                        }
                        else break;
                    }
                case 1:
                    {
                        if (_x-1 > 0 && field[_x-1, _y] == 0)
                        {
                            _x = _x -1;
                            break;
                        }
                        else break;
                    }
                case 2:
                    {
                        if (_y-1 > 0 && field[_x, _y-1] == 0)
                        {
                            _y = _y -1;
                            break;
                        }
                        else break;   
                    }
                case 3:
                    {
                        if (_y+1 < (_field.GetLength(1)-1) && field[_x, _y+1] == 0)
                        {
                            _y = _y + 1;
                            break;
                        }
                        else break;
                    }
            }
            _field[_x, _y] = TypeOfAnimal;
        }
    }
}
