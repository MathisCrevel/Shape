using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    internal class Triangle
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public Triangle(double height, double width) 
        {
            Height = height;
            Width = width;
        }

    }
}
