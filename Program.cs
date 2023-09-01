using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @ref
{
    class Program
    {
        static void resize (ref int[] Array, int newSize)
        {
            int[] newArray = new int[newSize];
            for (int i = 0; i < Array.Length && i< newArray.Length; i++)
            {
                newArray[i] = Array[i];
            }
            Array = newArray;
                        
        }
        static void add(ref int[] Array, int value, int index)
        {
            int[] newArray = new int[Array.Length+1];
            newArray[index] = value;
            for (int i = 0; i < newArray.Length; i++)
            {
                if (i<index) 
                    newArray[i] = Array[i];

                if (i > index)
                    newArray[i] = Array[i-1];
            }
            Array = newArray;
            
        }
        static void delete(ref int[] Array, int index)
        {
            int[] newArray = new int[Array.Length - 1];

            for (int i = 0; i < index; i++)            
                newArray[i] = Array[i];

            for (int i = index; i < newArray.Length; i++)            
                newArray[i] = Array[i+1];

            Array = newArray;
        }

        static void ArrayOnConsole(int[]Array)
        {
            for (int i = 0; i < Array.Length; i++)
            {
                Console.WriteLine(Array[i]);
            }
        }
        static void Main(string[] args)
        {
            int[] myArray = {1, 43, 21, 4};
            resize(ref myArray, 6);
            ArrayOnConsole(myArray);

            Console.WriteLine("---------");

            add(ref myArray, 2, 2);
            ArrayOnConsole(myArray);

            Console.WriteLine("---------");

            delete(ref myArray,1);
            ArrayOnConsole(myArray);
        }
    }
}
