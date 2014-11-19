using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MagicWords
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<string> words = new List<string>();
        for (int i = 0; i < n; i++)
        {
            words.Add(Console.ReadLine());
        }
        //words.Add("hi");
        //words.Add("academy");
        //words.Add("exam");
        string tempToMove = null;
        for (int i = 0; i < n; i++)
        {
            int indexToInsert = (words[i].Length % (n + 1));            
            tempToMove = words[i];
            words.Insert(indexToInsert, tempToMove);
            if (indexToInsert < i)
            {
                words.RemoveAt(i + 1);
            }
            else
            {
                words.RemoveAt(i);
            }
            
            
        }
        StringBuilder stringg = new StringBuilder();
        for (int i = 0; i < 1001; i++)
        {
            for (int j = 0; j < words.Count; j++)
            {
                if (i < words[j].Length)
                {
                    stringg.Append(words[j][i]);
                }
            }
        }
        Console.WriteLine(stringg);
    }
}
/*3
hi
academy
exam*/
