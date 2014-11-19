using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MultiverseCommunication
{
    static void Main()
    {
        string input = Console.ReadLine();
        List<string> code = new List<string>();
        string toGoInArr = null;
        for (int i = 0; i < input.Length; i++)
        {
            toGoInArr = input[i].ToString() + input[i + 1].ToString() + input[i + 2].ToString();
            i += 2;
            code.Add(toGoInArr);
            toGoInArr = null;
        }
        int[] codeInNums = new int[code.Count];
        for (int i = 0; i < code.Count; i++)
        {
            switch (code[i])
            {
                case "CHU": codeInNums[i] = 0;
                    break;
                case "TEL": codeInNums[i] = 1;
                    break;
                case "OFT": codeInNums[i] = 2;
                    break;
                case "IVA": codeInNums[i] = 3;
                    break;
                case "EMY": codeInNums[i] = 4;
                    break;
                case "VNB": codeInNums[i] = 5;
                    break;
                case "POQ": codeInNums[i] = 6;
                    break;
                case "ERI": codeInNums[i] = 7;
                    break;
                case "CAD": codeInNums[i] = 8;
                    break;
                case "K-A": codeInNums[i] = 9;
                    break;
                case "IIA": codeInNums[i] = 10;
                    break;
                case "YLO": codeInNums[i] = 11;
                    break;
                case "PLA": codeInNums[i] = 12;
                    break;
                default:
                    break;
            }
        }
        int index = 0;
        double result = 0;
        for (int i = codeInNums.Length - 1; i >= 0; i--)
        {
            result += codeInNums[index] * Math.Pow(13, i);
            index++;
        }
        Console.WriteLine(result);
    }
}

/*0	CHU
1	TEL
2	OFT
3	IVA
4	EMY
5	VNB
6	POQ
7	ERI
8	CAD
9	K-A
10	IIA
11	YLO
12	PLA
*/