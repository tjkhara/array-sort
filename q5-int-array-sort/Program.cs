using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q5_int_array_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            arraySort();
        }

        static void arraySort()
        {
            int[] intArray = new int[5];
            int holder;
            Console.WriteLine("Please enter 5 integers");

            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int l = 0; l < intArray.Length; l++)

            {

                for (int j = intArray.Length - 1; j > 0; j--)
                {
                    if (intArray[j - 1] > intArray[j])
                    {
                        holder = intArray[j];
                        intArray[j] = intArray[j - 1];
                        intArray[j - 1] = holder;
                    }
                }

            }
            

            for (int k = 0; k < intArray.Length; k++)
            {
                Console.WriteLine(intArray[k]);
            }
        }
    }
}
