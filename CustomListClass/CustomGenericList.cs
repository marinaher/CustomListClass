using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
    public class CustomGenericList<T> : IEnumerable<T>                  //implementing IEnumerable literally applies that this class is enumerable 
    {                                                                   //i.e.can be iterated and IEnumerator merely returns the enumerator and hence IEnumberable implements IEnumerator.
        public T[] innerArray;                                          //IEnumerator remembers it's place to go back and after running thru

        public CustomGenericList(T[] x)
        {
            this.innerArray = x;
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
            T[] temporaryArray = new T[innerArray.Length + 1];           //created a 'temporaryArray' to hold items
            for (int i = 0; i < innerArray.Length; i++)                  //to add items to end of an array when new array is created.
            {
                temporaryArray[i] = innerArray[i];
            }
            temporaryArray[innerArray.Length] = item;
            innerArray = temporaryArray;                                 //now items array will have all the same things as the new temporary array
        }

        public void RemoveAt(T removeItem)                               //removing from array
        {
            bool notFound = true;
            T[] temporaryGenericArray = new T[innerArray.Length - 1];
            for (int i = 0; i < innerArray.Length; i++)
            {
                if (notFound)
                {
                    if (innerArray[i].Equals(removeItem))                //.Equals: compares the contents of two StringBuilders. Returns true or false;
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

        public static string ConvertStringArrayToString(string[] array)               //ideal for when you need to loop over your string array before adding the elements.
        {
            StringBuilder builder = new StringBuilder();
            foreach (string value in array)
            {
                builder.Append(value);                                                //Append: adds contents of it's arguments to the buffer in the StringBuilder
                builder.Append('.');                                                  //Arguements are converted to strings with ToString
            }
            string result = string.Join(", ", array);
            return builder.ToString();                                                //ToString: returns the buffer. Returns contents as a string.
        }
        public int Count()                                                            //Count
        {
            int index = 0;
            for (int i = 0; i < innerArray.Length; i++)
            {
                index++;
            }
            return index;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}