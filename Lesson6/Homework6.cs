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
            int[] number = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            foreach (int numberOne in number)
            {
                foreach (int numberTwo in number)
                {

                    Console.Write($"{numberOne}*{numberTwo}={numberTwo * numberOne} ");

                }
            }
        }
    }
}
