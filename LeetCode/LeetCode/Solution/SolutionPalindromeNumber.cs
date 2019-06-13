using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class SolutionPalindromeNumber:BaseSolution
{
    public bool Execute(int x)
    {
        return IsPalindrome(x);
    }
    public bool IsPalindrome(int x)
    {
        if (x < 0)
            return false;

        int digitCnt = 1;
        List<int> digitList = new List<int>();
        digitList.Add(x % 10);
        while (x/10 > 0)
        {
            digitCnt++;
            x = x / 10;
            digitList.Add(x % 10);
        }
        
        for(int i = 0;i<digitCnt/2;i++)
        {
            if (digitList[i] != digitList[digitCnt - 1 - i])
                return false;
        }
        return true;
    }
}

