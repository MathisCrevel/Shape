using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    public class AreaCalculator
    { 
        public AreaCalculator() { }
        public double TotalArea(Form[] arrObjects) 
        {
            double area = 0;
            foreach(var objForm in arrObjects)
            {
                area += objForm.Area();
            } 
            return area;
            }
        
        }
    
    }


