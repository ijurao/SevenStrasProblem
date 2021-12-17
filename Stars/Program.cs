using System;
using System.Linq;

namespace Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            DrawStars(33);
            Console.WriteLine("Hello World!");
        }

        static void DrawStars(int n)
        {
            for (int i = n; i >= 0; i-=2)
            {
                var times = i == 0 ? 1 : i;
                int amoutOfBlankSpaces =  ( (n - i) / 2);
                var s = string.Concat(Enumerable.Repeat("*", times));
               
                if(amoutOfBlankSpaces > 0)
                {
                    if (amoutOfBlankSpaces == n / 2 && n % 2 == 0) amoutOfBlankSpaces--;
                    string blanks = string.Concat(Enumerable.Repeat(" ", amoutOfBlankSpaces));
                    s = s.Insert(0, blanks);
                    s = s.Insert(s.Length, blanks);
                }
                
                Console.WriteLine(s);
            }
            
            for (int i = 1; i <= n; i += 2)
            {
                var times = i == 0 ? 1 : i;
                int amoutOfBlankSpaces = ((n - i) / 2);
                var s = string.Concat(Enumerable.Repeat("*", times));

                if (amoutOfBlankSpaces > 0)
                {
                    string blanks = string.Concat(Enumerable.Repeat(" ", amoutOfBlankSpaces));
                    s = s.Insert(0, blanks);
                    s = s.Insert(s.Length, blanks);
                }

                Console.WriteLine(s);
            }
        }
    }
}
