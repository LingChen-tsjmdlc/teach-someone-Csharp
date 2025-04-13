using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCSharp
{
    internal class Lesson4
    {
        static public void Lessons4()
        {
            BasicForLoopExample();
            Console.ReadKey();
            ArrayDeclarationAndInitialization();
            Console.ReadKey();
            ArrayAssignmentMethods();
            Console.ReadKey();
            AccessingArrayElements();
            Console.ReadKey();
            TraverseArrayExample();
            Console.ReadKey();
            NestedLoopExample();
            Console.ReadKey();
            // InfiniteLoopExample(); // 注释掉以防程序无法终止
        }

        // 1. 基础for循环示例
        static void BasicForLoopExample()
        {
            Console.WriteLine("=== 基础for循环示例 ===");
            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine("打印！第" + i + "次");
            }
        }

        // 2. 数组声明和初始化
        static void ArrayDeclarationAndInitialization()
        {
            Console.WriteLine("\n=== 数组声明和初始化 ===");

            // 声明数组
            int[] numberArray;
            string[] stringArray;

            // 初始化数组
            numberArray = new int[10];
            stringArray = new string[5];

            // 声明并初始化
            int[] arr1 = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] arr2 = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.WriteLine("arr1长度: " + arr1.Length);
            Console.WriteLine("arr2长度: " + arr2.Length);
        }

        // 3. 数组赋值方法
        static void ArrayAssignmentMethods()
        {
            Console.WriteLine("\n=== 数组赋值方法 ===");

            // 初始化时赋值
            int[] arr1 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // 通过索引赋值
            int[] arr2 = new int[10];
            arr2[0] = 10;
            arr2[1] = 11;

            Console.WriteLine("arr1[0]: " + arr1[0]);
            Console.WriteLine("arr2[0]: " + arr2[0]);
            Console.WriteLine("arr2[1]: " + arr2[1]);
        }

        // 4. 访问数组元素
        static void AccessingArrayElements()
        {
            Console.WriteLine("\n=== 访问数组元素 ===");

            int[] arr = { 10, 20, 30, 40, 50 };

            // 通过索引访问
            Console.WriteLine("第一个元素: " + arr[0]);
            Console.WriteLine("最后一个元素: " + arr[arr.Length - 1]);

            // 修改元素
            arr[0] = 100;
            Console.WriteLine("修改后的第一个元素: " + arr[0]);
        }

        // 5. 遍历数组示例
        static void TraverseArrayExample()
        {
            Console.WriteLine("\n=== 遍历数组示例 ===");

            int[] numbers = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

            // 使用for循环遍历
            Console.WriteLine("使用for循环遍历:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"numbers[{i}] = {numbers[i]}");
            }

            // 使用foreach循环遍历
            Console.WriteLine("\n使用foreach循环遍历:");
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
        }

        // 6. 嵌套循环示例
        static void NestedLoopExample()
        {
            Console.WriteLine("\n=== 嵌套循环示例 ===");

            // 创建3个独立的一维数组来模拟3x4的矩阵
            int[] row1 = { 1, 2, 3, 4 };
            int[] row2 = { 5, 6, 7, 8 };
            int[] row3 = { 9, 10, 11, 12 };

            // 将数组放入另一个数组中（数组的数组）
            int[][] matrix = { row1, row2, row3 };

            // 外层循环遍历行
            for (int row = 0; row < 3; row++)
            {
                // 内层循环遍历列
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    Console.WriteLine($"matrix[{row}][{col}] = {matrix[row][col]}");
                }
            }
        }

        // 7. 死循环示例
        static void InfiniteLoopExample()
        {
            Console.WriteLine("\n=== 死循环示例 ===");
            Console.WriteLine("警告：这将进入无限循环！");
            Console.WriteLine("按Ctrl+C可以终止程序");
            Console.WriteLine("即将开始！！！！！");

            for (; ; )
            {
                Console.WriteLine("死循环，会一直打印这一行。");
            }
        }
    }
}