using System;
using System.Text;

class GeneratesAllTheCombinations
{
    static void Comb(int[] arr, int k)
    {
        StringBuilder str = new StringBuilder();
        for (int i = 1; i <= Math.Pow(2, arr.Length) - 1; i++)
        {
            string temp = Convert.ToString(i, 2).PadLeft(arr.Length, '0');
            for (int j = 0; j < temp.Length; j++)
            {
                if (temp[j] == '1')
                {
                    str.Append(arr[j] + " ");
                }
            }
            string[] split = str.ToString().Split(null as string[], StringSplitOptions.RemoveEmptyEntries);
            if (split.Length == k)
            {
                Console.WriteLine(str.ToString());
            }
            str.Clear();
            Array.Clear(split, 0, split.Length);
        }
    }
    static void Main(string[] args)
    {
        int n;
        bool isN = int.TryParse(Console.ReadLine(), out n);
        if (isN)
        {
            int k = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = i + 1;
            }
            Comb(arr, k);
        }
    }
}

