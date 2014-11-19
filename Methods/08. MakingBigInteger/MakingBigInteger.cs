using System;

class MakingBigInteger
{
    static int[] MakeBigInt(string numAsText)
    {
        int[] numAsArr = new int[numAsText.Length];
        for (int i = 0; i < numAsArr.Length; i++)
        {
            numAsArr[i] = int.Parse(numAsText[(numAsText.Length - 1) - i].ToString());
        }
        return numAsArr;
    }
    static int[] SumOfTwoArrays(int[] firstArr, int[] secArr)
    {
        int maxLength = Math.Max(firstArr.Length, secArr.Length) + 1;
        int[] arrOne = new int[maxLength];
        int[] arrTwo = new int[maxLength];
        for (int i = 0; i < firstArr.Length; i++)
        {
            arrOne[i] = firstArr[i];
        }
        for (int i = 0; i < secArr.Length; i++)
        {
            arrTwo[i] = secArr[i];
        }
        int onesValue = 0;
        int tensValue = 0;
        int[] sumOfArrs = new int[maxLength];
        int tenCount = 0;
        for (int i = 0; i < maxLength; i++)
        {
            onesValue = (arrOne[i] + arrTwo[i]) % 10;
            if (i != 0)
	        {
                tensValue = (arrOne[i - 1] + arrTwo[i - 1]) / 10;
	        }
            if (onesValue + tensValue != 10 && onesValue + tensValue + tenCount != 10)
            {
                sumOfArrs[i] = onesValue + tensValue + tenCount;
                tenCount = 0;
            }
            else
            {
                sumOfArrs[i] = 0;
                tenCount = 1;                                
            }
            
        }
        Array.Reverse(sumOfArrs);
        if (sumOfArrs[0] == 0)
        {
            int[] newSumArr = new int[sumOfArrs.Length - 1];
            for (int i = 0; i < newSumArr.Length; i++)
            {
                newSumArr[i] = sumOfArrs[i + 1];
            }
            return newSumArr;
        }
        else
        {
            return sumOfArrs;
        }       
        
    }
    static void Main()
    {
        Console.Write("Enter the first number: ");
        string firstInputNum = Console.ReadLine();
        int[] firstBigNum = MakeBigInt(firstInputNum);
        Console.Write("Enter the second number: ");
        string secondInputNum = Console.ReadLine();
        int[] secondBigNum = MakeBigInt(secondInputNum);
        int[] sumArr = SumOfTwoArrays(firstBigNum, secondBigNum);
        Console.WriteLine(string.Join("", sumArr));
    }
}

