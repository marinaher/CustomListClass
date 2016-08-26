using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
    public class CustomGenericList<T> : IEnumerable<T>
    {
        public T[] innerArray;     
        public T[] GenericArrayList;

        public CustomGenericList()
        {
            innerArray = new T[0];
        }
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < innerArray.Length; i++)
            {
                if (innerArray != null)
                {
                    yield return innerArray[i];
                }
            }
        }
        public void Add(T item)
        {
            T[] temporaryArray = new T[innerArray.Length + 1]; 
            for (int i = 0; i < innerArray.Length; i++)
            {
                temporaryArray[i] = innerArray[i];
            }
            temporaryArray[innerArray.Length] = item;
            innerArray = temporaryArray;
        }
        public void RemoveAt(T removeItem)
        {
            bool notFound = true;
            T[] temporaryGenericArray = new T[innerArray.Length - 1];
            for (int i = 0; i < innerArray.Length; i++)
            {
                if (notFound)
                {
                    if (innerArray[i].Equals(removeItem))
                    {
                        notFound = false;
                    }
                    else
                    {
                        temporaryGenericArray[i] = innerArray[i];
                    }
                }
                else
                {
                    temporaryGenericArray[i - 1] = innerArray[i];
                }
            }
            innerArray = temporaryGenericArray;
        }
        public string GenericString()
        {
            string genericString = "Delicious Fruits: ";
            for (int i = 0; i < innerArray.Length; i++)
            {
                genericString = genericString + ", " + innerArray[i];
            }
            return genericString;
        }

        public static CustomGenericList<T> operator +(CustomGenericList<T> List1, CustomGenericList<T> List2)
        {
            CustomGenericList<T> combinedLists = new CustomGenericList<T>();
            foreach (T item in List1.innerArray)
            {
                combinedLists.Add(item);
            }
            foreach (T item in List2.innerArray)
            {
                combinedLists.Add(item);
            }
            return combinedLists;
        }

        public static CustomGenericList<T> operator -(CustomGenericList<T> List1, CustomGenericList<T> List2)
        {
            for (int i = 0; i < List1.Count(); i++)
            {
                for (int j = 0; j < List2.Count(); j++)
                {
                    if (List1.innerArray[i].Equals(List2.innerArray[j]))
                    {
                        List1.RemoveAt(List2.innerArray[j]);
                    }
                }
            }
            return List1;
        }

        public int Count()
        {
            int index = 0;
            for (int i = 0; i < innerArray.Length; i++)
            {
                index++;
            }
            return index;
        }
        public void Print()
        {
            foreach (T item in innerArray)
            {
                Console.WriteLine(item);
            }
        }
        public void Zipper(CustomGenericList<T> List1, CustomGenericList<T> List2)
        {
            if (List1.innerArray.Length > List2.innerArray.Length || List1.innerArray.Length < List2.innerArray.Length || List1.innerArray.Length == List2.innerArray.Length)
            {
                for (int i = 0; i < List2.innerArray.Length; i++)
                {
                    Console.WriteLine("{0} \t{1}", List1.innerArray[i], List2.innerArray[i]);
                }
                for (int i = List2.innerArray.Length; i < List1.innerArray.Length; i++)
                {
                    Console.WriteLine("{0}", List1.innerArray[i]);
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}