using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCSharp
{
    internal class Homework2
    {
        public static void Homework()
        {
            Console.WriteLine("\n题目1：商品价格计算");
            CommodityPrice();
            Console.ReadKey();
            Console.WriteLine("\n题目2：求余数");
            FindRemainder();
            Console.ReadKey();
        }

        /*
        题目1：商品价格计算
            ​要求：
                编写程序，计算购买某商品的总金额。

            题目内容：
                商品单价为 float 类型（59.99f），购买数量为 int 类型（3个）。
                总金额按单价乘以数量计算，结果需转换为 int 类型（直接截断小数）。
                输出示例：单价: 59.99, 数量: 3, 总金额: 179

            提示：
                注意浮点数与整数转换的精度问题。

            结果：
                单价: 59.99, 数量: 3, 总金额: 177
         */
        /// <summary>
        /// 题目1：商品价格计算
        /// </summary>
        public static void CommodityPrice()
        {
            float price1 = 59.99f;
            int price2;
            price2 = (int)price1;
            int quantity = 3;
            float lump_sum = price2 * quantity;
            Console.WriteLine($"单价：{price1},数量:{quantity},总金额：{lump_sum}");
        }


        /*
        题目2：求余数
            要求：
                string inputA = "15.6";  
                string inputB = "7";  
                将这两个字符串转换为整数，计算它们的余数并输出

            提示：
                先把字符串转换为整数，然后再计算余数
            
            结果：
                1
         */
        /// <summary>
        /// 题目2：求余数
        /// </summary>
        public static void FindRemainder()
        {
            string inputA = "15.6";
            string inputB = "7";
            float a1 = float.Parse(inputA); // 字符串 转 浮点数
            int inputBToInt = int.Parse(inputB);  // 字符串 转 整数
            //int a2;           // 1. 声明变量
            //a2 = (int)a1;     // 2. 赋值变量
            int a2 = (int)a1;   // 声明 + 赋值 一起写，转换为整数
            Console.WriteLine("a2 % b = {0}", a2 % inputBToInt);  // 取余数
        }

    }
}
