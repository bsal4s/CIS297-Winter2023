using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_ObjectOrientedProgramming
{
    public class Rectangle
    {
        public int Area => _length * _width;

        public int getArea()
        {
            return _length * _width;
        }

        private int _length;
        public int Length
        {
            get
            {
                return _length;
            }
            set
            {
                if (value > 0)
                {
                    _length = value;
                }
                else
                {
                    _length = 0;
                }

            }

        }

        private int _width;
        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
                if (value > 0)
                {
                    _width = value;
                }
                else
                {
                    _width = 0;
                }

            }

        }
    }
}
