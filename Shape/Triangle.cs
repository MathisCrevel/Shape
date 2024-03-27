using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape 
{
    internal class Triangle : Form
    {
        public double Height { get; set; }
        public double Base { get; set; }
        public Triangle(double height, double Base) 
        {
            Height = height;
            this.Base = Base;
        }
        public override double Area()
        {
            return 0.5 * Base * Height;
        }
    }
}
