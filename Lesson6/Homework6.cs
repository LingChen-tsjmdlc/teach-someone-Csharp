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
            Q1();
            Console.ReadKey();
            Q2();
            Console.ReadKey();
            Q3();
            Console.ReadKey();
        }

        //题目一：成绩等级分类系统
        //要求：
        //1. 声明一个整型数组 scores，包含10个学生的成绩（0-100随机值）
        //      例如：int[] scores = { 85, 92, 45, 78, 66, 95, 53, 88, 72, 60 };
        //2. 使用 foreach 遍历数组，并用 switch 语句统计各等级人数：
        //      - 优秀（90-100）
        //      - 良好（80-89）
        //      - 及格（60-79）
        //      - 不及格（0-59）
        //最后输出各等级人数统计结果
        //**注意**：是输出人数

        /* 输出结果：
                    优秀: 2, 良好: 2, 及格: 4, 不及格: 2
        */
        public static void Q1()
        {
            int[] scores = new int[] { 88, 74, 85, 92, 21, 70, 97, 79, 66, 57 };
            int excellent = 0;
            int good = 0;
            int pass = 0;
            int fail = 0;
            foreach (int grede in scores)
            {
                switch (grede / 10)
                {
                    case 10:
                    case 9:
                        excellent++;
                        break;
                    case 8:
                        good++;
                        break;
                    case 7:
                    case 6:
                        pass++;
                        break;
                    default:
                        fail++;
                        break;
                }
            }
            Console.WriteLine($"优秀：{excellent},良好：{good},及格:{pass},不及格:{fail}");

        }

        //题目二：矩阵特殊元素处理
        //要求：
        //1. 声明一个 4x4 二维数组 matrix，包含随机整数（正负均有）
        //    例如：
        //    int[,] matrix = {
        //        { 5, -2, 9, 4 },
        //        { -1, 12, 3, 7 },
        //        { 8, 6, -4, 0 },
        //        { -5, 10, 15, -3 }
        //    };
        //2. 使用嵌套 for 循环遍历矩阵：
        //      - 用 if 判断元素是否为负数 或 能被3整除的正数
        //      - 将满足条件的元素替换为 0
        //3. 输出修改后的矩阵
        //**提示**：二维数组使用两个for的嵌套循环进行遍历

        /* 输出结果：
          5   0   0   4
          0  11   0   7
          8   0   0   0
          0  10   0   0
        */
        public static void Q2()
        {
            int[,] matrix = {
                    { 5, -2, 9, 4 },
                    { -1, 11, 3, 7 },
                    { 8, 6, -4, 12},
                    { -5, 10, 15, -3 }
                };
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {

                }

            }
        }
    } 
}

        //题目三：数组元素替换与统计
        //要求：
        //1. 声明一个整型数组 numbers，初始值为 { 5, -2, 9, -4, 0, 7 }
        //2. 使用 for 循环遍历数组：
        //      - 用 if 语句判断元素是否为负数
        //      - 将负数替换为 0
        //3. 使用 foreach 循环计算并输出替换后数组的正数总和
        //输出修改后的数组和正数总和

        public static void Q3()
        {
            int[] numbers = new int[] { 5, -2, 9, -4, 0, 7 };
            for (int i = 0; i <= numbers.Length; i++) {
                if (i < 0) {
                    numbers[i] = 0;
                }
            }

        }
    }
}
