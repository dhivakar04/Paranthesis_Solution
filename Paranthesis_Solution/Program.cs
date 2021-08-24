using System;

namespace Paranthesis_Solution
{
    class Program
    {
        static void MaxValidParanthesisCheck(String s)
        {
            int open = 0;
            int close = 0;
            int max = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                    open++;
                else
                    close++;
                if (open == close)
                {
                    int len = open + close;
                    max = Math.Max(max, len);
                }
                else if (close > open)
                    open = close = 0;
            }
            open = close = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] == '(')
                    open++;
                else
                    close++;
                if (open == close)
                {
                    int len = open + close;
                    max = Math.Max(max, len);
                }
                else if (close < open)
                    open = close = 0;
            }
            Console.WriteLine("Longest Valid paranthesis in this {0} is {1}", s, max);
        }
        static void Main(string[] args)
        {
            MaxValidParanthesisCheck("(()(()()");
            MaxValidParanthesisCheck("))))((((");
            MaxValidParanthesisCheck("()()(())()()((");

        }
    }
}
