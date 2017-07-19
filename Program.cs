using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                string s = Console.ReadLine();
                if (IsBalanced(ref s))
                    Console.WriteLine("YES"); 
                else
                    Console.WriteLine("NO"); 
            }

        }

        static bool IsBalanced(ref string s)
        {

            if ((s.Length % 2) != 0)
                return false; 

            Stack<char> bracetStack = new Stack<char>(); 

            foreach(char c in s)
            {
                if (c == '{')
                    bracetStack.Push('}');
                else if (c == '(')
                    bracetStack.Push(')');
                else if (c == '[')
                    bracetStack.Push(']'); 
                else
                {
                    if (bracetStack.Count == 0)
                        return false; 

                    if (c != bracetStack.Pop())
                        return false; 
                }
            }

            if (bracetStack.Count > 0)
                return false; 

            return true; 
        }
    }
}
