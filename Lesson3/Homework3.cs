using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCSharp
{
    public static class Homework3
    {
        static public void Homework()
        {
            Console.WriteLine("\n第一题输出：");
            Question1();
            Console.ReadKey();

            Console.WriteLine("\n第二题输出：");
            Question2();
            Console.ReadKey();

            Console.WriteLine("\n第三题输出：");
            Question3();
            Console.ReadKey();
        }

        /*
        题目1：
            string userInput = "3.14";

            // 请完成以下要求：
                // 1. 使用tryParse方法尝试将userInput转换为float类型
                // 2. 如果转换成功，输出"转换成功，值为：[值]"
                // 3. 如果转换失败，输出"输入格式不正确"
                // 4. 使用驼峰命名法定义接收变量
        */
        private static void Question1()
        {
            
        }


        /*
        题目2：
            加法和减法计算器

            // 请完成以下要求：
                // 1. 创建三个变量:用户输入的值1，用户输入的值2，用户使用加法（+）还是减法（-）的变量
                // 2. 使用控制台读取功能，将用户的输入存入刚刚创建的变量中
                // 3. 如果用户输入不正确，输出“输入错误”，并退出程序（退出程序: Environment.Exit(1);）
                // 4. 使用判断语句判断用户输入的是 + 还是 -，加法执行：值1 + 值2，减法执行：值1 - 值2
            // 提示：
                在用户输入之前可以先输出提示用户应该输入什么东西。
                比如我想让用户输入第一个数值：
                    Console.WriteLine("请输入第一个值：");          // 这里就是提示
                    string userInput1 = Console.ReadLine();      //  这里是实际的用户输入逻辑
        */
        private static void Question2()
        {
            
        }


        /*
        题目3：
            检查当前月份为哪个季节

            // 请完成以下要求：
                // 根据输入的数字月份(1-12)，使用 switch 语句输出对应季节：
                // 12/1/2月 - 冬季
                // 3-5月 - 春季
                // 6-8月 - 夏季
                // 9-11月 - 秋季
                // 其他输入 - "无效月份"
        */
        private static void Question3()
        {
            
        }
    }
}
