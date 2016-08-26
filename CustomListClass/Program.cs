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
            CustomGenericList<string> CustomGenericList = new CustomGenericList<string>();

            //added fruits below
            CustomGenericList.Add("apple");
            CustomGenericList.Add("banana");
            CustomGenericList.Add("pear");
            CustomGenericList.Add("blueberry");
            CustomGenericList.Add("raspberry");
            CustomGenericList.Add("grapefruit");
            CustomGenericList.Print();
            Console.ReadLine();

            //removed 1 element
            Console.WriteLine("Removed raspberry from arrayList");
            CustomGenericList.RemoveAt("raspberry");
            CustomGenericList.Print();
            Console.ReadLine();

            string GenericString = CustomGenericList.GenericString();
            Console.WriteLine(GenericString);
            Console.ReadLine();

            //count property
            Console.WriteLine("There are {0} fruits in my arrayList now.", CustomGenericList.Count());
            CustomGenericList.Print();
            Console.ReadLine();

            ////Overloading + operator
            //Console.WriteLine("+ Operator Overload: ");
            //OverloadArray overload1 = new OverloadArray("Nick", 24);
            //overload1.Display();

            //OverloadArray overload2 = new OverloadArray("Carter", 12);
            //overload2.Display();

            //OverloadArray overload3 = overload1 + overload2;
            //overload3.Display();

            ////Overloading - operator
            //Console.WriteLine("\n- Operator Overload: ");
            //OverloadArray overload4 = new OverloadArray(10, 5);
            //OverloadArray overload5 = new OverloadArray(5, 2);
            //OverloadArray overload6 = overload4 - overload5;
            //overload6.Display1();

            //Console.ReadLine();

            //Add Overload

            Console.WriteLine("\nOverload + Operator to add two instances of my custom class.");
            CustomGenericList<string> TemporaryList = new CustomGenericList<string>();

            TemporaryList.Add("4");
            TemporaryList.Add("7");
            TemporaryList.Add("1");
            
            CustomGenericList<string> CombinedList = new CustomGenericList<string>();
            CombinedList = CustomGenericList + TemporaryList;
            CombinedList.Print();
            Console.ReadLine();

            Console.WriteLine("\nOverload - Operator to remove one custom list from another.");
            CustomGenericList<string> RemoveFromList = new CustomGenericList<string>();
            RemoveFromList = CustomGenericList - TemporaryList;
            RemoveFromList.Print();
            Console.ReadLine();

            //Zipper
            Console.WriteLine("\nZipper two Custom Lists");
            CustomGenericList<string> ZipperList = new CustomGenericList<string>();
            ZipperList.Zipper(CustomGenericList, TemporaryList);
            ZipperList.Print();
            Console.ReadLine();
            
        }
    }
}
