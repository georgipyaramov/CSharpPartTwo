using System;

class OneToAHundredFactorial
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
    static int[] SumOfTwoArrays(int[] firstArr, int[] secArr) //Returns the sum of two numbers as a reversed array 
    {                                                         //(the last digit of the number is in position [0] in the array) 
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
            Array.Reverse(newSumArr); // Reversing the result array to avoid errors when using in a loop. Otherwise it returns array
            return newSumArr;         // like {1,2,3}, but when using in a loop it needs to be like {3,2,1}
        }
        else
        {
            Array.Reverse(sumOfArrs); // Reversing the result array to avoid errors when using in a loop.
            return sumOfArrs;
        }

    }
    static int[] MultiplyArrays(int[] firstArr, int multiplyer) //Represents a * 2 as a + a; a * 3 = a + a + a
    {
        int[] result = firstArr;
        if (multiplyer == 0)
        {
            result = new int[] { 0 };
        }
        for (int i = 0; i < multiplyer - 1; i++)
        {
            result = SumOfTwoArrays(result, firstArr);
        }
        return result;
    }
    static void Main()
    {
        int[] bigNumOne = MakeBigInt("1");
        int[] result = bigNumOne;
        for (int i = 0; i < 100; i++)
        {
            result = SumOfTwoArrays(result, MultiplyArrays(result, i));
            int[] factorial = new int[result.Length];
            for (int j = 0; j < factorial.Length; j++) // Reversing the result array
            {
                factorial[j] = result[factorial.Length - 1 - j];
            }
            Console.WriteLine(string.Join("", factorial));
        }
        Console.WriteLine();
    }
}
