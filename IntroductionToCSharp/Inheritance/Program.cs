using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape S = new Shape();
            
            Rectangle R = new Rectangle();
            Triangle T = new Triangle();
            
            R.CalArea();
         
        }
    }
}
