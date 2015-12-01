using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
  public class Shape
    {
        private int length;
        public int _length
        {
            get
            {
                return length;
            }
            set
            {
                length = value;

            }
        }
        private int width;
        public int _width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;

            }
        }
        private int area;
        public int _area
        {
            get
            {
                return area;
            }
            set
            {
                area = value;

            }
        }
        protected int provar;
        private int privar;
        public void CalArea()
        {
            Console.WriteLine("The Area is "+area  );
        }
       

    }

  public class Rectangle : Shape
    {
       
       public void CalRecArea()
       {
           _area = _length * _width;
            base.CalArea();
       }
    }
  public class Triangle : Shape
  {
      public void CalTriArea()
      {
          _area =(int)( 0.5*_length * _width);
          base.CalArea();
      }
  }
}
