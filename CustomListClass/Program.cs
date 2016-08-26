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

            //added fruits below to Array

            CustomGenericList.Add("pear");
            CustomGenericList.Add("blueberry");
            CustomGenericList.Add("raspberry");
            CustomGenericList.Add("grapefruit");
            CustomGenericList.Print();
            Console.ReadLine();

            Console.WriteLine("Removed raspberry from arrayList");
            CustomGenericList.RemoveAt("raspberry");
            CustomGenericList.Print();
            Console.ReadLine();

            string GenericString = CustomGenericList.GenericString();
            Console.WriteLine(GenericString);
            Console.ReadLine();


            Console.WriteLine("There are {0} fruits in my arrayList now.", CustomGenericList.Count());
            CustomGenericList.Print();
            Console.ReadLine();

            //Overloading + operator
            OverloadArray overload1 = new OverloadArray("Nick", 26);
            overload1.Display();

            OverloadArray overload2 = new OverloadArray("Carter", 21);
            overload2.Display();

            OverloadArray overload3 = overload1 + overload2;
            overload3.Display();

        }
    }
}
