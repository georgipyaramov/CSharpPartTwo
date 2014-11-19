using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeTrys
{
    class Program
    {
        private static bool NextPermutation(char[] array)
        {
            for (int index = array.Length - 2; index >= 0; index--)
            {
                if (array[index] < array[index + 1])
                {
                    int swapWithIndex = array.Length - 1;
                    while (array[index] >= array[swapWithIndex])
                    {
                        swapWithIndex--;
                    }

                    // Swap i-th and j-th elements
                    var tmp = array[index];
                    array[index] = array[swapWithIndex];
                    array[swapWithIndex] = tmp;

                    Array.Reverse(array, index + 1, array.Length - index - 1);
                    return true;
                }
            }

            // No more permutations
            return false;
        }
        static void Main(string[] args)
        {
            string a = "abcde";
            var shit = a.ToCharArray();
            do
            {
                Console.WriteLine(string.Join("", shit));
            } while (NextPermutation(shit));
        }
    }
}
