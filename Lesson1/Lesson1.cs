using System;   // 使用命名空间



/// C Sharp 语言（C#）
namespace StudyCSharp   //  命名空间
{
    class Lesson1  // 类
    {      
         static public void Lesson() // 方法 or 函数
         {
            string animal = "小猫";  // 字符串类型
            int age = 3;            // 整数类型
            float weight = 40.5f;      // 小数类型
            bool isEndangered = true;  // 布尔类型

            Console.WriteLine("\n动物园有一只" + age + "岁的"+ animal + "，体重"+ weight+ "公斤，是否濒危：" + isEndangered);
            Console.ReadKey();
         }
    }
} 