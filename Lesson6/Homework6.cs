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

            if (float.TryParse(guessNumber, out float toGuessNumber))
            {
                for (int frequency = 1; frequency <= 10; frequency++)
                {
                    if (number > toGuessNumber)
                    {
                        Console.WriteLine("太小了");
                        Console.WriteLine("请继续输入你猜想的数字：");
                        string guessNumberTwo = Console.ReadLine();

                        if (float.TryParse(guessNumberTwo, out float toguessNumberTwo))
                        {
                            if (number < toguessNumberTwo)
                            {
                                Console.WriteLine("太大了");
                            }
                            else if (number < toguessNumberTwo)
                            {
                                Console.WriteLine("太小了");
                            }
                            else if (number == toguessNumberTwo)
                            {
                                Console.WriteLine("猜对了！");
                                break;
                            }

                        }

                        else if (number < toGuessNumber)
                        {
                            Console.WriteLine("太大了");
                            Console.WriteLine("请继续输入你猜想的数字：");

                            string guessNumberOne = Console.ReadLine();
                            if (float.TryParse(guessNumberOne, out float toguessNumberOne))
                            {
                                if (number < toguessNumberOne)
                                {
                                    Console.WriteLine("太大了");
                                }
                                else if (number < toguessNumberOne)
                                {
                                    Console.WriteLine("太小了");
                                }
                                else if (number == toguessNumberOne)
                                {
                                    Console.WriteLine("猜对了！");
                                    break;
                                }
                            }

                        }

                        else if (number == toGuessNumber)
                        {
                            Console.WriteLine("猜对了！");
                            break;
                        }


                        else
                        {
                            Console.WriteLine("输入错误！");
                        }
                        Console.WriteLine($"你还剩：{10 - frequency}次机会");
                    }

                    Console.ReadKey();

                }
            }
        }
    }
}
