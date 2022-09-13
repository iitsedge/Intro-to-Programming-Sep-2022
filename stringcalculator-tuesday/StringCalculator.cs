
using System.Numerics;

namespace StringCalculator;

public class StringCalculator
{
    public char[] delimeters = { ',', '\n'};
    public int Add(string numbers)
    {
        if (numbers.Length == 0)
        {
            return 0;
        }

        if (!(numbers.Contains(",")| numbers.Contains("\n")))
        {
            return int.Parse(numbers);
        }
        else
        {
            string[] numbersArray = numbers.Split(delimeters);
            int totalSum = 0;
            for (int i = 0; i < numbersArray.Length; i++)
            {
                totalSum += int.Parse(numbersArray[i].Trim());
            }
            return totalSum;
        }
    }
}
