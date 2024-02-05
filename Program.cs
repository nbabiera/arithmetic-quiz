using System;

namespace arithmetic_quiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int cnt = rnd.Next(5,15);
            double ans = 0;
            int corrCnt = 0;
            char[] opt = { '+', '-', '*', '/' };
            Console.WriteLine($"Arithmetic Quiz {cnt}");
            Console.WriteLine("NOTE: If answer is in decimal please use two (2) decimal places");

            for (int i = 1; i <= cnt; i++)
            {
                double fNum = rnd.Next(100);
                double sNum = rnd.Next(100);
                char randomOpt = opt[rnd.Next(opt.Length)];
                Console.WriteLine($"\nQuestion{i}: What is {fNum} {randomOpt} {sNum}");
                Console.Write("Your Answer: ");
                while (!double.TryParse(Console.ReadLine(), out ans))
                {
                    Console.WriteLine("Invalid input, please enter a number");
                    Console.Write("Your Answer: ");
                }
;

                if (ans == checker(fNum, sNum, randomOpt))
                {
                    Console.WriteLine("Correct!");
                    corrCnt++;

                }
                else
                {
                    Console.WriteLine($"Incorrect! The correct answer is {checker(fNum, sNum, randomOpt)}");
                }
            }
            double percentage = Convert.ToDouble(corrCnt) / Convert.ToDouble(cnt);
            Console.WriteLine($"\nTotal correct answers:{corrCnt}");
            Console.WriteLine($"Percentage of correct answers:{Math.Round(percentage * 100,2)}%");
        }

        public static double checker (double fNum, double sNum, char opt)
        {
            double corAns = 0;
            switch (opt)
            {
                case '+':
                     corAns = fNum + sNum;
                    break;
                case '-':
                     corAns = fNum - sNum;
                    break;
                case '*':
                     corAns = fNum * sNum;
                    break;
                case '/':
                     if(sNum == 0)
                    {
                        Console.WriteLine("Invalid operations");
                    }
                    else
                    {
                        corAns = fNum / sNum;
                    }
                    break;
            }
            return Math.Round(corAns,2);
        }

    }

}
