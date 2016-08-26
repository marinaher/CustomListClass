using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CustomGenericList<string> CustomGenericList = new CustomGenericList<string>(new string[] { "apple", "banana" });

            CustomGenericList.Add("pear");
            CustomGenericList.Add("blueberry");
            CustomGenericList.Add("raspberry");
            CustomGenericList.Add("grapefruit");

            CustomGenericList.RemoveAt("raspberry");

            string combindedString = string.Join(", ", CustomGenericList.ToArray());
            Console.WriteLine(String.Join(", ", CustomGenericList));
            Console.ReadLine();

            //CustomGenericList<int> GenericAddOverload = new CustomGenericList<int>(new int[] { 5, 10});


            //Console.WriteLine("Count: {0}", CustomGenericList.count);
        }
    }
}
