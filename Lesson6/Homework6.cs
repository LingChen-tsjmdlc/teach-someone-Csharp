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
            Q4();
            Console.ReadKey();
            Q5();
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
        //3. 最后输出各等级人数统计结果
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
        //      - 用 if 判断元素是否为负数      或    能被3整除 且是（与、和） 正数
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
            // 声明一个 4x4 二维数组
            int[,] matrix = {
                    { 5, -2, 9, 4 },
                    { -1, 11, 3, 7 },
                    { 8, 6, -4, 12},
                    { -5, 10, 15, -3 }
            };

            //2. 使用嵌套 for 循环遍历矩阵
            for (int i = 0; i < matrix.GetLength(0); i++)   // 外层循环是行
            {
                for (int j = 0; j < matrix.GetLength(1); j++)   // 内层循环是列
                {
                    if (matrix[i,j] < 0 || (matrix[i, j] % 3 == 0 && matrix[i, j]>0) )
                    {
                        matrix[i, j] = 0;
                    }
                    Console.Write($"{matrix[i,j],5}");
                }
                Console.WriteLine();
            }

        }

        //题目三：数组元素替换与统计
        //要求：
        //1. 声明一个整型数组 numbers，初始值为 { 5, -2, 9, -4, 0, 7 }
        //2. 使用 for 循环遍历数组：
        //      - 用 if 语句判断元素是否为负数
        //      - 将负数替换为 0
        //3. 使用 foreach 循环 计算 并输出替换后数组的 正数总和
        //输出修改后的数组和正数总和

        public static void Q3()
        {
            //1. 声明一个整型数组 numbers，初始值为 { 5, -2, 9, -4, 0, 7 }
            int[] numbers = new int[] { 5, -2, 9, -4, 0, 7 };
            int sum = 0;

            //2. 使用 for 循环遍历数组：
            for (int i = 0; i <= numbers.Length; i++) {
                //      - 用 if 语句判断元素是否为负数
                if (i < 0) {
                    //      - 将负数替换为 0
                    numbers[i] = 0;
                    
                }
            }

            foreach (int i in numbers)
            {
                if (i > 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine("正数总和: " + sum);
        }

        //题目四：菜单系统（增，删，改，查）
        //要求：
        //1. 声明一个字符串数组 menu，选项有“查看数据，删除数据，退出系统”
        //2. 使用 while 循环和 switch 实现以下功能
        //      - 显示菜单（使用 for 循环输出代编号的选项）
        //      - 根据用户输入1~3 来执行对应的操作：
        //          - 1. 显示当前的数据
        //          - 2. 使用索引删除数组
        //          - 3. 退出程序
        //3. 使用 if 验证用户输入的合法性
        public static void Q4()
        {
            string[] menu = { "查看数据", "删除数据", "退出系统" }; 
            string[] data = { "苹果", "香蕉", "荔枝", "草莓", "西瓜", "梨子" };
            bool isRunning = true;  //运行状态

            while (isRunning)
            {
                // ------------------ 显示菜单功能 -----------------------
                Console.WriteLine("====== 菜单 ======");

                for (int i = 0; i < menu.Length; i++) 
                {
                    Console.WriteLine($"{i+1}: {menu[i]}");
                }

                Console.WriteLine("请选择 1~3 序号：");
                string input = Console.ReadLine();
                if (!int.TryParse(input, out int choice) || choice < 1 || choice > 3)   // 验证输入有效性
                {                               // choice: n. 选择
                    Console.WriteLine("输入错误！请输入 1~3 的数字！");
                    continue;   // 跳过本次错误的循环，执行下一次循环
                }

                // ------------------ 功能模块 -------------------
                switch (choice)
                {
                    case 1:// 查看数据
                        Console.WriteLine("当前数据：" + string.Join(",",data));// 苹果,香蕉,荔枝,草莓,西瓜,梨子
                        break;

                    case 2://删除数据
                        // 检测数据是否为空
                        if (data.Length == 0)
                        {
                            Console.WriteLine("错误：数据为空，无法删除！");
                            break;
                        }

                        Console.WriteLine($"请输入要删除的索引（0 ~ { data.Length - 1 }）");

                        if (!int.TryParse(Console.ReadLine(), out int index) || index < 0 || index >= data.Length)
                        {
                            Console.WriteLine("错误：超出索引范围！");
                            break;
                        }
                        /* 删除操作主要逻辑
                         1. 创建一个新的数组：长度比原来的小 1
                         2. 使用双指针
                            - i 遍历原来的数组
                            - j 记录新的数组的填充位置
                         3. 跳过要删除的索引
                         */
                        string[] newData = new string[data.Length - 1];
                        for (int i = 0, j =0 ; j < data.Length; i++)
                        {
                            if (i != index) // 保留非删除项
                            {
                                newData[i] = data[i];   // 复制元素
                                j++;                    // 移动
                            }
                        }
                        data = newData; // 
                        Console.WriteLine("删除成功！");

                        break;

                    case 3://退出系统
                        isRunning = false;
                        Console.WriteLine("感谢使用！");
                        break;
                }
            }
        }


        //题目五：字符串元音统计器
        //要求：
        //1. 编写程序统计用户输入的字符串中每个元音字母（a, e, i, o, u）的出现次数，不区分大小写(即大小写不敏感)
        //2. 使用 while 循环允许用户多次输入，直到选择退出
        //3. 功能实现需包含：
        //      - 输入验证：确保输入非空字符串
        //      - 统计逻辑：遍历字符串并计数
        //      - 结果输出：显示每个元音及其出现次数
        //4. 使用 switch 或 if-else 实现操作选择菜单：
        //      - 开始统计
        //      - 退出程序
        //
        // !!! 提示 !!! 
        // ToLower() 可以使大小写不敏感匹配
        // 作用：将字符串中的大写字母统一转为小写，实现大小写不敏感匹配
        /*  使用方法:
         *          string 原字符串变量 = Console.ReadLine();    // 比如说输入：ApplE
         *          string 新变量名 = 原字符串变量.ToLower();     // 全部转换成小写
         *          Console.WriteLine(新变量名);                // 输出： apple
         */

        public static void Q5()
        {
            bool functioning = true;  //运行状态

            while (functioning)
            {
                Console.WriteLine("请输入字母字符串：");
                string word = Console.ReadLine();
                string wordVowel = word.ToLower();

                if (string.IsNullOrEmpty(wordVowel))
                {
                    Console.WriteLine("输入不能为空！");
                }

                Console.WriteLine("请输入1或2序号数字：");
                string number = Console.ReadLine();

                if (int.TryParse(number,out int oneNumber)) {

                    switch (oneNumber)
                    {
                        case 1:
                            Console.WriteLine("开始统计");

                            string[] vowels = new string[] { "a", "e", "i" ,"o","u"};
                            foreach (var vowel in vowels)
                            {
                                Console.WriteLine($"{vowel}");
                            }

                            break;
                        case 2:
                            Console.WriteLine("退出程序");
                            break;
                    }
                }

            }
            
        }
    }
}
