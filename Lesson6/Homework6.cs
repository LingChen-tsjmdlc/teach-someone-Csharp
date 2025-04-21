using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCSharp
{
    public static class Homework6
    {
        static public void Homework()
        {
            Console.WriteLine("欢迎来到猜数字游戏，你一共有十次机会！");
            float number = 55;
            Console.WriteLine("请输入你猜想的数字：");
            string guessNumber = Console.ReadLine();

            // 转换数
            if (float.TryParse(guessNumber, out float toGuessNumber))
            {
                // 控制循环次数
                for (int frequency = 1; frequency <= 10; frequency++)
                {
                    // 判断猜测的数值是否比设定的小
                    if (number > toGuessNumber)
                    {

                    }

                    // 判断猜测的数值是否比设定的大
                    if (number < toGuessNumber)
                    {

                    }

                    // 判断猜测的数值是否与设定相等
                    if (number == toGuessNumber)
                    {
                        
                    }

                    Console.ReadKey();

                }
            }
        }
    }
}
