using System;
using System.Text;

public class MainClass
{
    static void Main()
    {
        RuneTestCasePalindromeNumber();

        Console.ReadLine();
    }

    static void RunTestCaseAtoi()
    {
        SolutionAtoi s = new SolutionAtoi();
        int ret = s.Execute("-6147483648");
        Console.Write(ret);
    }

    static void RuneTestCasePalindromeNumber()
    {
        SolutionPalindromeNumber s = new SolutionPalindromeNumber();
        if (s.Execute(-1))
            Console.Write("yes");
        else
            Console.Write("no");
    }
}
