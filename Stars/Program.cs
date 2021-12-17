using System;
using System.Linq;

namespace Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            DrawStars(64);
            DrawSquare(8);
            Console.WriteLine("Hello World!");
        }

        private static void DrawSquare(int n)
        {
            int amoutOfBlankSpaces = n - 2;
            for (int i = 1; i <= n; i++)
            {
                var line = "*" + string.Concat(Enumerable.Repeat(" ", amoutOfBlankSpaces)) + "*";
                var header = string.Concat(Enumerable.Repeat("*", n));
                Console.WriteLine(DisplatyLine(i, n, header, line));

            }

        }
        static string DisplatyLine(int i, int n, string header, string line)
        {
            var p = n;
            return (i, n, header, line) switch
            {
                (1, _, _, _) => header,
                (8, _, _, _) => header,
                _ => line
            };
        }


        static void DrawStars(int n)
            {
                DrawFormStars(n, n, false);
                DrawFormStars(n, 1, true);

            }


            private static void DrawFormStars(int n, int index, bool reverse)
            {

                for (int i = index; (reverse ? i <= n : i >= 0); i = (reverse ? i += 2 : i -= 2))
                {
                    var times = i == 0 ? 1 : i;
                    int amoutOfBlankSpaces = ((n - i) / 2);
                    var s = string.Concat(Enumerable.Repeat("*", times));

                    if (amoutOfBlankSpaces > 0)
                    {
                        if (amoutOfBlankSpaces == n / 2 && n % 2 == 0 && !reverse) amoutOfBlankSpaces--;
                        string blanks = string.Concat(Enumerable.Repeat(" ", amoutOfBlankSpaces));
                        s = s.Insert(0, blanks);
                        s = s.Insert(s.Length, blanks);
                    }

                    Console.WriteLine(s);
                }
            }
        }
    }

