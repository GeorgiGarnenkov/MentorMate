namespace MentorMate
{
    using System;

    public class MentorMateMain
    {
        public static void Main()
        {
            var n = NumberWriter();

            while (!IsInBorder(n) || !IsOdd(n))
            {
                Console.WriteLine("The value of 'n' needs to be an odd number, greater than 2 and lower than 10000.");

                n = NumberWriter();
            }

            DrawsFirstPart(n);
            DrawsSecondPart(n);
            DrawsThirdPart(n);
            DrawsFourthPart(n);

        }

        private static void DrawsFirstPart(int n)
        {
            var dash = '-';
            var star = '*';

            for (int i = 0; i < 2; i++)
            {
                Console.Write("{0}{1}{2}{3}{4}",
                    new string(dash, n),
                    new string(star, n),
                    new string(dash, n),
                    new string(star, n),
                    new string(dash, n));
            }
            Console.WriteLine();
        }
        private static void DrawsSecondPart(int n)
        {
            var dash = '-';
            var star = '*';
            var rowCounter = ((n + 1) / 2) - 1;

            var counter = 2;

            for (int i = 1; i <= rowCounter; i++)
            {
                Console.Write("{0}{1}{2}{3}{4}",
                    new string(dash, n - i),
                    new string(star, n + counter),
                    new string(dash, n - counter),
                    new string(star, n + counter),
                    new string(dash, n - i));

                Console.Write("{0}{1}{2}{3}{4}",
                    new string(dash, n - i),
                    new string(star, n + counter),
                    new string(dash, n - counter),
                    new string(star, n + counter),
                    new string(dash, n - i));
                counter += 2;
                Console.WriteLine();
            }
        }
        private static void DrawsThirdPart(int n)
        {
            var dash = '-';
            var star = '*';
            var rowCounter = ((n + 1) / 2) - 1;

            var counter = 0;

            for (int i = 0; i < rowCounter; i++)
            {
                Console.Write("{0}{1}{2}{3}{4}{5}{6}",
                    new string(dash, rowCounter - i),
                    new string(star, n),
                    new string(dash, 1 + counter),
                    new string(star, (n * 2) - 1 - counter),
                    new string(dash, 1 + counter),
                    new string(star, n),
                    new string(dash, rowCounter - i));

                Console.Write("{0}{1}{2}{3}{4}{5}{6}",
                    new string(dash, rowCounter - i),
                    new string(star, n),
                    new string(dash, 1 + counter),
                    new string(star, (n * 2) - 1 - counter),
                    new string(dash, 1 + counter),
                    new string(star, n),
                    new string(dash, rowCounter - i));
                counter += 2;
                Console.WriteLine();
            }

        }
        private static void DrawsFourthPart(int n)
        {
            var dash = '-';
            var star = '*';

            for (int i = 0; i < 2; i++)
            {
                Console.Write("{0}{1}{2}{3}{4}",
                    new string(star, n),
                    new string(dash, n),
                    new string(star, n),
                    new string(dash, n),
                    new string(star, n));
            }

            Console.WriteLine();
        }

        private static int NumberWriter()
        {
            return int.Parse(Console.ReadLine());
        }

        private static bool IsOdd(int n)
        {
            return n % 2 != 0;
        }

        private static bool IsInBorder(int n)
        {
            return n > 2 && n < 10000;
        }

    }
}
