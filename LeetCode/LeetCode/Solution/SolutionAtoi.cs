using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SolutionAtoi:BaseSolution
{
    public new int Execute(string str)
    {
        return MyAtoi(str);
    }
    int MyAtoi(string str)
    {
        bool start = false;
        bool end = false;
        int symbol = 1;
        int ret = 0;
        int tempRet = 0;
        for(int i=0;i<str.Length;i++)
        {
            if(!start)
            {
                if (str[i] != ' ')
                {
                    start = true;
                    int num = CharToInt(str[i]);
                    if(num < 0)
                    {
                        if (str[i] == '-')
                            symbol = -1;
                        else if (str[i] == '+')
                            symbol = 1;
                        else
                            break;
                    }
                    else
                    {
                        tempRet = ret * 10 + num;
                        if (IsNumOverFlow(ret, tempRet))
                            return symbol > 0 ? int.MaxValue : int.MinValue;
                        ret = tempRet;
                    }
                }
            }
            else
            {
                int num = CharToInt(str[i]);
                if (num < 0)
                {
                    break;
                }
                else
                {
                    tempRet = ret * 10 + num;
                    if (IsNumOverFlow(ret, tempRet))
                        return symbol > 0 ? int.MaxValue : int.MinValue;
                    ret = tempRet;
                }
            }
        }
        return ret*symbol;
    }

    int CharToInt(char c)
    {
        if (c >= '0' && c <= '9')
            return c - '0';
        return -1;
    }

    bool IsNumOverFlow(int before, int after)
    {
        if (after < before)
            return true;
        if (before > 0 && after < 0)
            return true;
        if (before < 0 && after > 0)
            return true;
        int calBefore = after / 10;
        if (calBefore != before)
            return true;
        return false;
    }
}

