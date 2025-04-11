using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCSharp
{
    internal static class Lesson3
    {
        static public void Lessons3()
        {
            Console.WriteLine("\n 输入语法:");
            Read(); 
            Console.WriteLine("\n if 语句语法:");
            JudgmentStatementIf();
            Console.WriteLine("\n if else 语句语法:");
            JudgmentStatementIfElse();
            Console.WriteLine("\n if elseif 语句语法:");
            JudgmentStatementIfElseIf();
            Console.WriteLine("\n case 语句语法:");
            CaseStatement();
        }

        private static void Read()
        {
            Console.WriteLine("即将输入！");
            string input = Console.ReadLine();
            Console.WriteLine("你输入的内容：" + input);
            Console.ReadKey();
        }

        private static void JudgmentStatementIf()
        {
            int s = 59;
            if (s < 60)
            {
                Console.WriteLine("补考");
            }
            Console.ReadKey();
        }

        private static void JudgmentStatementIfElse()
        {
            int s = 61;
            if (s < 60)
            {
                Console.WriteLine("补考");  // if为真执行
            }
            else
            {
                Console.WriteLine("不需要补考"); // if为假执行
            }
            Console.ReadKey();
        }

        private static void JudgmentStatementIfElseIf()
        {
            int s = 85;
            if (s < 60)
            {
                Console.WriteLine("补考");  // if为真执行
            }
            else if (s > 90)
            {
                Console.WriteLine("优秀分数");
            }
            else if (s > 80)
            {
                Console.WriteLine("还可以分数");
            }
            else if (s > 90)
            {
                Console.WriteLine("比及格强分数");
            }
            else
            {
                Console.WriteLine("不需要补考"); // if为假执行
            }
            Console.ReadKey();
        }

        private static void CaseStatement()
        {
            int number = 8;
            switch (number)
            {
                case 10:
                    Console.WriteLine("优秀");
                    break;
                case 9:
                    Console.WriteLine("优秀");
                    break;
                case 8:
                    Console.WriteLine("良好");
                    break;
                case 7:
                    Console.WriteLine("及格");
                    break;
                case 6:
                    Console.WriteLine("及格");
                    break;
                default:
                    Console.WriteLine("不及格");
                    break;
            }
            Console.ReadKey();
        }
    }
}
