using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCSharp
{
    public class Homework7
    {       
        // 做完的题目在此方法里面调用
        static public void Homework()
        {
            ConvertTemperature(0, true);
        }

        //1. 基础题：温度转换函数
        //    要求：
        //    编写一个静态方法 ConvertTemperature，实现摄氏温度和华氏温度的互相转换。
        //    方法接收两个参数：double temperature（温度值）和 bool isCelsiusToFahrenheit（转换方向）。
        //    若 isCelsiusToFahrenheit 为 true，将摄氏温度转换为华氏；否则将华氏转换为摄氏。

        //    公式：
        //    摄氏 → 华氏：华氏温度 = 摄氏温度 * 9/5 + 32
        //    华氏 → 摄氏：摄氏温度 = (华氏温度 - 32) * 5/9

        /// <summary>
        /// 温度转换函数
        /// </summary>
        /// <param name="temperature">温度</param>
        /// <param name="isCelsiusToFahrenheit">转换方向。为 true，将摄氏温度转换为华氏；否则将华氏转换为摄氏。</param>
        public static void ConvertTemperature(double temperature, bool isCelsiusToFahrenheit)
        {
            // 摄氏温度转换为华氏
            if (isCelsiusToFahrenheit)
            {
                double temperatureToFahrenheit = temperature * 9 / 5 + 32;
                Console.WriteLine($"转换完成的温度为{temperatureToFahrenheit}°F");
            }
            // 华氏转换为摄氏
            else
            {
                double FahrenheitTotemperature = (temperature - 32) * 5 / 9;
                Console.WriteLine($"转换完成的温度为{FahrenheitTotemperature}°C");
            }
        }













        //2. 应用题：学生成绩分析函数
        //    要求：
        //    写一个总方法 AnalyzeGrades（AnalyzeGrades:分析等级），调用下面的三个方法
        //    三个方法 ：统计学生成绩的 最高分（HighestScore）、最低分（LowestScore） 和 平均分（AverageScore）。

        //    参数：
        //    int[] grades：成绩数组（0-100之间的整数）。
        //    返回值：
        //          返回最高分（maxScore）
        //          返回最低分（minScore）
        //          返回平均分（average）

        //    规则：
        //    如果成绩数组为空，输出出异常。
        //    忽略无效分数（如负数或大于100的成绩）。

        //升序排序的提示：
        //      语法：Array.Sort(数组名);
        //      例子：
        //          int[] numbers = { 5, 3, 9, 1, 4 };
        //          Array.Sort(numbers);    // 输出: 1, 3, 4, 5, 9

        public static void AnalyzeGrades()
        {
            Console.WriteLine("欢迎来到成绩分析系统!");
            Console.WriteLine("请输入你想要分析的一组成绩0~100,用逗号或空格分隔：");
            string input = Console.ReadLine();
            string[] grades = input.Split(' ',',');
            int[] scores =new int[grades.Length];
            Array.Sort(scores);

            for (int i = 0; i < scores.Length; i++)
            {
                if (int.TryParse(grades[i], out int number))
                {
                    scores[i] = number;

                    if (number < 0 || number > 100)
                    {
                        Console.WriteLine($"输入的{scores[i]}不是有效整数，已忽略");
                    }
                }
            }

                if (scores.Length == 0)
                {
                    Console.WriteLine("输入为空，输出异常！");
                    return;
                }
            
            int excellent = 0; 
            int good = 0;
            int pass = 0;
            int fail = 0;

            foreach (int number in scores)
            {
                switch (number / 10)
                {
                    case 10:
                    case 9:
                        excellent++;
                        break;
                    case 8:
                    case 7:
                        good++;
                        break;
                    case 6:
                        pass++;
                        break;

                    default:
                        fail++;
                        break;
                }
            }
            Console.WriteLine($"优秀：{excellent}，良好：{good}，及格：{pass}，不及格：{fail}。");

            int mixScore = scores[0];
            Console.WriteLine($"最高分{mixScore}");
        }

        public static void HighestScore(9)
        {
            int maxScore = scores[-1];
            Console.WriteLine($"最高分{scores[-1]}");

        }

        public static void LowestScore()
        {

        }

        public static void AverageScore()
        {

        }








    }
}
