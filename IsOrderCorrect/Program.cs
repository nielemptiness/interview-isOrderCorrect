using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "(";
            var result = text.ToCharArray();
            var openLine = '(';
            var endLine = ')';

            int occurCount = 0;
            foreach (var t in text)
            {
                if (t == openLine)
                {
                    occurCount++;
                    continue;
                }

                if (t == endLine)
                {
                    occurCount--;
                }

                if (occurCount < 0) throw new ArgumentException("Incorrect order!");
            }

            if (occurCount == 0)
            {
                Console.WriteLine("Success!");
                return;
            }

            throw new ArgumentException("Incorrect order!");
        }
    }
}
