using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class EncodeAndEncrypt
{
    static void Main()
    {
        string message = Console.ReadLine();
        string cypher = Console.ReadLine();
        int cypherLneght = cypher.Length;
        int keyCount = 0;
        var listBeforeChange = new List<int>();
        for (int i = 0; i < message.Length; i++)
        {
            listBeforeChange.Add(message[i] - 65);
        }
        var listCypher = new List<int>();
        for (int i = 0; i < cypher.Length; i++)
        {
            listCypher.Add(cypher[i] - 65);
        }
        var listTemp = new List<int>();
        for (int i = 0; i < message.Length; i++)
        {
            listTemp.Add(message[i] - 65);
        }
        StringBuilder result = new StringBuilder();
        if (cypher.Length <= message.Length)
        {
            for (int i = 0; i < message.Length; i++)
            {
                result.Append(((char)((listBeforeChange[i] ^ listCypher[keyCount]) + 65)).ToString());
                keyCount++;
                if (keyCount == cypher.Length)
                {
                    keyCount = 0;
                }
            }
        }
        else
        {
            for (int i = 0; i < cypher.Length; i++)
            {
                listTemp[keyCount] = listTemp[keyCount] ^ listCypher[i];
                keyCount++;
                if (keyCount == listTemp.Count)
                {
                    keyCount = 0;
                }
            }
            for (int i = 0; i < listTemp.Count; i++)
            {
                result.Append(((char)(listTemp[i] + 65)).ToString());
            }
        }
        var semiRsult = new List<string>();
        for (int i = 0; i < result.Length; i++)
        {
            semiRsult.Add(result[i].ToString());
        }
        int numberOfRepetition = 1;
        string output = null;
        for (int i = 0; i < semiRsult.Count; i++)
        {
            if (i < semiRsult.Count - 1)
            {
                if (semiRsult[i] == semiRsult[i + 1])
                {
                    numberOfRepetition++;
                }
                else if (semiRsult[i] != semiRsult[i + 1] && numberOfRepetition >= 3)
                {
                    output += numberOfRepetition.ToString() + semiRsult[i];
                    numberOfRepetition = 1;
                }
                else if (semiRsult[i] != semiRsult[i + 1] && numberOfRepetition < 3)
                {
                    for (int j = 0; j < numberOfRepetition; j++)
                    {
                        output += semiRsult[i];
                    }
                    numberOfRepetition = 1;
                }
            }
            else
            {
                if (numberOfRepetition >= 3)
                {
                    output += numberOfRepetition.ToString() + semiRsult[i];
                    numberOfRepetition = 1;
                }
                else if (numberOfRepetition < 3)
                {
                    for (int j = 0; j < numberOfRepetition; j++)
                    {
                        output += semiRsult[i];
                    }
                    numberOfRepetition = 1;
                }
            }
            
        }
        semiRsult = new List<string>();
        for (int i = 0; i < cypher.Length; i++)
        {
            semiRsult.Add(cypher[i].ToString());
        }
        numberOfRepetition = 1;
        for (int i = 0; i < semiRsult.Count; i++)
        {
            if (i < semiRsult.Count - 1)
            {
                if (semiRsult[i] == semiRsult[i + 1])
                {
                    numberOfRepetition++;
                }
                else if (semiRsult[i] != semiRsult[i + 1] && numberOfRepetition >= 3)
                {
                    output += numberOfRepetition.ToString() + semiRsult[i];
                    numberOfRepetition = 1;
                }
                else if (semiRsult[i] != semiRsult[i + 1] && numberOfRepetition < 3)
                {
                    for (int j = 0; j < numberOfRepetition; j++)
                    {
                        output += semiRsult[i];
                    }
                    numberOfRepetition = 1;
                }
            }
            else
            {
                if (numberOfRepetition >= 3)
                {
                    output += numberOfRepetition.ToString() + semiRsult[i];
                    numberOfRepetition = 1;
                }
                else if (numberOfRepetition < 3)
                {
                    for (int j = 0; j < numberOfRepetition; j++)
                    {
                        output += semiRsult[i];
                    }
                    numberOfRepetition = 1;
                }
            }
            
        }
        output += cypherLneght.ToString();
        Console.WriteLine(output);
    }
}

