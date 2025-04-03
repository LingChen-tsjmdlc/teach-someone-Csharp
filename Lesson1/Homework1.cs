using System;


namespace StudyCSharp
{
    class HomeWork
    {      
         static public void Homework()
         {
            Console.WriteLine("第一题输出：");
            Problenm1();
            Console.ReadKey();

            Console.WriteLine("第二题输出：");
            Problenm2();
            Console.ReadKey();

            Console.WriteLine("第三题输出：");
            Problenm3();
            Console.ReadKey();
        }

        /*
        /// <------- 1. 根据注释提示补全代码 ------->
        ___ bookName = "老人与海";     // 字符串类型  
        ___ publishYear = 1952;        // 整数类型  
        ___ price = 29.99;             // 小数类型  
        ___ isOutOfPrint = __;         // 布尔类型  

        // 目标输出：  
        // 书店有《老人与海》（出版年：1952），价格：29.99元，是否绝版：False  
        Console.WriteLine(___);  
        */
        static public void Problenm1()
        {
            string bookName = "老人与海";     // 字符串类型  
            int publishYear = 1952;        // 整数类型  
            float price = 29.99f;             // 小数类型  
            bool isOutOfPrint = false;         // 布尔类型 
            Console.WriteLine("书店有《" + bookName + "》（出版年：" + publishYear + "），价格：" + price + "元，是否绝版：" + isOutOfPrint);
        }


        /*
        /// <-------- 2. 变量存储字符图案元素 ---------->
        char edge = '★';
        char fill = '○';

        // 输出一个5x5的菱形图案
        // 目标效果：
                    ★  
                    ★○★  
                    ★○○○★  
                    ★○★  
                    ★
        */
        static public void Problenm2()
        {
            Console.WriteLine("★");
            Console.WriteLine("★○★");
            Console.WriteLine("★○○○★");
            Console.WriteLine("★○★");
            Console.WriteLine("★");
        }

        /*
        <----------- 3. 计算与输出混用练习 ---------->
        声明变量存储以下信息：
        商品名称：水杯（字符串类型）
        单价：15.5 元（小数类型）
        购买数量：2 个（整数类型）
        计算总价（单价 × 数量）

        // 输出格式：
        商品：水杯，单价：15.5元，数量：2个，总价：31元

        ！！！ 提示：先使用数学中的加法把总价算出来（也就是 15.5 + 15.5）存到一个变量 total 中（注意 total 的类型，想一想这个变量是什么类型）。
	          怎么存？例子：a = b + c（解释这个例子：把 b+c 算出来存到变量 a 中；比如 n = 1 + 2，就是先算 1+2，得出结果 3，3 再给到 n 变量）
         */
        static public void Problenm3()
        {
            string item = "水杯";
            float price = 15.5f;
            int quantity = 2;
            float total = price * quantity;
            Console.WriteLine($"商品：{item}，单价：{price}元，数量：{quantity}个，总价：{total}元");
        }
    }
    
}