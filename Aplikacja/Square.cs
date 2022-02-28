using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja
{
    internal class Square
    {

        private int side;
        private int area;
        private int surface;
        public Square(int side)
        {
            this.side = side;  
            calcArea(); 
            calcSurface();
        }

        private void calcArea()
        {
            area = side * side;
        }
        private void calcSurface()
        {
            surface = area * 20;
        }
     
        public int Side { get { return side; } }    
        
        public int Area { get { return area; } }

        public int Surface { get { return surface; } }

         
    }
}
