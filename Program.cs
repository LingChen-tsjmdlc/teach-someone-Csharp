using System;   // 使用命名空间
using StudyCSharp;


namespace StudyCSharp
{
    class Program
    {      
         static void Main()
         {
            // 第一节课
            Console.WriteLine("<-- 第一节课 -->");
            Lesson1.Lesson();
            Console.WriteLine("<-- 第一节课作业 -->");
            HomeWork.Homework();
        }
    }
}