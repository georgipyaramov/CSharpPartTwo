using System;

class ReadIntegerNumbers
{
    /*Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end]. 
     * If an invalid number or non-number text is entered, the method should throw an exception. 
     * Using this method write a program that enters 10 numbers:
			a1, a2, … a10, such that 1 < a1 < … < a10 < 100*/

    static void ReadNumber(int start,int end)
    {
        string[] nums = new string[10];
        int[] intNums = new int[10];
        int numCount = 0;
        Console.WriteLine("Enter 10 numbers as follows - {0} < num1 < … < num10 < {1}",start,end);
        for (int i = 1; i <= 10; i++)
        {
            Console.Write("[{0}]: ",i);
            nums[numCount] = Console.ReadLine();

            try
            {
                int.Parse(nums[numCount]);
                int number = int.Parse(nums[numCount]);
                intNums[i] = number;
                if (i == 1) //Checks only the first entered number
                {
                    if (number <= start || number > end)
                    {
                        throw new System.ArgumentOutOfRangeException();
                    }
                }
                else if (number < intNums[numCount] || number > end) //Check rest of the numbers
                {
                    throw new System.ArgumentOutOfRangeException();
                }
            }
            catch (FormatException) //when it's not a valid integer
            {
                Console.WriteLine("Error: Not a valid integer number!");
                throw;
            }
            catch (ArgumentOutOfRangeException) //out of integer range or user defined start...end range
            {
                Console.WriteLine("Error: Integer out of range!");
                throw;
            }
            numCount++;
        }
    }

    static void Main()
    {
        int start = 1;
        int end = 100;
        ReadNumber(start,end);
    }
}

