using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCSharp
{
    internal class Lesson2
    {
        static public void Lessons2()
        {
            Console.WriteLine("\n数值的转换:");
            NumberConversion();
            Console.WriteLine("\n字符串的转换:");
            StringConversion();
            Console.WriteLine("\n布尔类型转换:");
            BoolConversion();
            Console.WriteLine("\n时间类型转换（不常用）:");
            TimeConversion();
            Console.WriteLine("\n算术运算符:");
            ArithmeticOperators();
        }

        /// <summary>
        /// 数值的转换
        /// </summary>
        public static void NumberConversion()
        {
            float d = 5673.74f;
            int i;

            // 将 float 类型转换为 int
            i = (int)d;
            Console.WriteLine("转换前{0}，转换后{1}", d, i);
            Console.ReadKey();
            // 转换前5673.74，转换后5673
        }

        /// <summary>
        /// 字符串的转换
        /// </summary>
        public static void StringConversion()
        {
            int i = 75;
            float f = 53.005f;
            bool b = true;

            Console.WriteLine(i.ToString()); // "75"
            Console.WriteLine(f.ToString()); // "53.005"
            Console.WriteLine(b.ToString()); // "True"
            Console.ReadKey();
        }

        /// <summary>
        /// 布尔类型转换
        /// </summary>
        public static void BoolConversion()
        {
            int i1 = 1;
            int i2 = 0;
            bool b1 = Convert.ToBoolean(i1);
            bool b2 = Convert.ToBoolean(i2);
            Console.WriteLine(b1); // 输出: True
            Console.WriteLine(b2); // 输出: False
            Console.ReadKey();
        }

        /// <summary>
        /// 时间类型转换
        /// </summary>
        public static void TimeConversion()
        {
            string dateString = "2020-04-21 15:57:32";
            DateTime date = Convert.ToDateTime(dateString);
            Console.WriteLine(date); // 输出: "2020/4/21 15:57:32"
            Console.ReadKey();
        }

        /// <summary>
        /// 算术运算符
        /// </summary>
        public static void ArithmeticOperators()
        {
            int a = 10;
            int b = 20;

            Console.WriteLine("a + b = {0}", a + b);
            Console.WriteLine("a - b = {0}", a - b);
            Console.WriteLine("a * b = {0}", a * b);
            Console.WriteLine("a / b = {0}", a / b);
            Console.WriteLine("a % b = {0}", a % b);
            Console.WriteLine("++a 的值是 {0}", ++a);
            a = 10; // 重新给变量 a 赋值
            Console.WriteLine("a-- 的值是 {0}", a--);
            Console.WriteLine("a 的值是 {0}", a);
            Console.ReadLine();
            /*
                结果：
                a + b = 30  
			    a - b = -10  
			    a * b = 200  
			    a / b = 0  
			    a % b = 10  
			    ++a 的值是 11  
			    a-- 的值是 10  
			    a 的值是 9
            */
        }
    }
}
