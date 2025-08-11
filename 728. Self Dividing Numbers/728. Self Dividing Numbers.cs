using System;
using System.Collections.Generic;

public class Solution
{
    public IList<int> SelfDividingNumbers(int left, int right)
    {
        List<int> result = new List<int>();

        for (int num = left; num <= right; num++)
        {
            if (IsSelfDividing(num))
            {
                result.Add(num);
            }
        }

        return result;
    }

    private bool IsSelfDividing(int num)
    {
        int original = num;

        while (num > 0)
        {
            int digit = num % 10; 
            if (digit == 0 || original % digit != 0)
            {
                return false;
            }
            num /= 10;
        }

        return true;
    }
}