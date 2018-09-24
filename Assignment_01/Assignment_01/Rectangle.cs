using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_01
{
   public class Rectangle
    {
        private int length;
        private int width;

        public Rectangle()
        {
            length = 1;
            width = 1;
        }

        public Rectangle(int length, int width)
        {
            this.length = length;
            this.width = width;
        }


        public int Getlength()
        {
            return this.length;
        }

        public int Setlength(int length)
        {
            this.length = length;

            return this.length;
        }

        public int GetWidth()
        {

            return this.width;
        }

        public int SetWidth(int width)
        {
            this.width = width;
            return this.width;
        }

        public int GetPerimeter()
        {
            int perimeter = 2 * (this.length + this.width);

            return perimeter;
        }

        public int GetArea()
        {
            int area = this.length * this.width;
            return area;
        }
    }
}
