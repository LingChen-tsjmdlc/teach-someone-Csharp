﻿using System;   // 使用命名空间
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
            Console.WriteLine("\n\n\n <-- 第一节课作业 -->");
            HomeWork.Homework();

            // 第二节课
            Console.WriteLine("\n\n\n <-- 第二节课 -->");
            Lesson2.Lessons2();
            Console.WriteLine("\n\n\n <-- 第二节课作业 -->");
            Homework2.Homework();
        }
    }
}