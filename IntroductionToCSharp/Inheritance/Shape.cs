using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Shape
    {
        public int length { get; set; }
        public int width { get; set; }
        public int Area { get; set; }
        public void CalArea()
        {
            Console.WriteLine(Area);
        }
    }
    class Rectange:Shape
    {
        public void CalRectArea()
        {
            Area = length * width;
            base.CalArea();
        }
    }
}
