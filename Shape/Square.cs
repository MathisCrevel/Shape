﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    
    public class Square : Form
    {
        public double Side { get; set; }

        public Square(double side)
        {
            Side = side;
        }
        public override double Area()
        {
            return Side * Side;
        }
    }
}
