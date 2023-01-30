using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Strings
{
    public static class Task01
    {
        public static void ReverseString()
        {
            var initialString = "introduction";
            var resultString = new StringBuilder();

            for (int i = initialString.Length; i > 0; i--)
            {
                resultString.Append(initialString[i - 1]);
            }

            Console.WriteLine(initialString);

            Console.WriteLine(resultString);
        }

        public static void CheckParentheses()
        {
            var expression = "((a+b)/5-d)";
            var checkSum = 0;

            for (int i = 0; i <= expression.Length - 1; i++)
            {
                if (expression[i] == '(')
                {
                    checkSum++;
                }

                if (expression[i] == ')')
                {
                    checkSum--;
                }

                if (checkSum < 0)
                {
                    break;
                }
            }

            if (checkSum != 0)
            {
                Console.WriteLine("Not OK");
            }
            else
            {
                Console.WriteLine("OK");
            }
        }

        public static void SubstringCount()
        {
            var substring = "in";
            var text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";

            var pos = text.IndexOf(substring, StringComparison.OrdinalIgnoreCase);
            var count = 0;

            while (pos != -1)
            {
                count++;
                pos = text.IndexOf(substring, pos + 1, StringComparison.OrdinalIgnoreCase);
            }

            Console.WriteLine(count);

            
            
            Console.WriteLine(text.ToLower().Split(substring.ToLower()).Length - 1);

        }
    }
}
