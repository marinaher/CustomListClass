using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
    public class OverloadArray
    {
        public string indexA;
        public int indexB;
        public int indexC;

        public OverloadArray(string indexA, int indexB)
        {
            this.indexA = indexA;
            this.indexB = indexB;
        }
        public void Display()
        {
            Console.WriteLine(indexA);
            Console.WriteLine(indexB);
            Console.WriteLine(indexC);
        }

        public static OverloadArray operator +(OverloadArray indexA1, OverloadArray indexB1)
        {
            OverloadArray newOverload = new OverloadArray((indexA1.indexA + indexB1.indexA), (indexA1.indexB + indexB1.indexB));
            return newOverload;
        }
    }
}