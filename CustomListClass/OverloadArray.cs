using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
    public class OverloadArray
    {
        private int _a, _b;
        public OverloadArray(int a, int b)                  //basic constructor
        {
            _a = a; 
            _b = b;
        }
        public int a
        {
            get { return _a; }
            set { _b = value; }
        }
        public int b
        {
            get { return _b; }
            set { _b = value; }
        }
        public static OverloadArray operator +()
        {
            OverloadArray overload = new OverloadArray();
            
        }
        //public static OverloadArray operator +(OverloadArray input1, OverloadArray input2)
        //{
        //    OverloadArray wz = new OverloadArray(input1 + input2, input2 + input3);
        //    return wz;
        //}
        //public void display()
        //{
        //    Console.WriteLine(w);
        //    Console.WriteLine(z);
        //}
        //public static OverloadArray -(OverloadArray w, OverloadArray z)
        //{
        //    OverloadArray wz = new OverloadArray(w - y, y - z);
        //    return wz;
        //}
    }
}
