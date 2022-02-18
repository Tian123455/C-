using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _03猜拳游戏;
using _02计算器;

namespace itheima7
{
    public class MyClass
    {

        int m = 1000;

        public void M1()
        {
            m++;
        }
        public void M2()
        {
            m++;
        }
        public void M3()
        {
            Console.WriteLine(m);
        }
        public MyClass()
        {
            M1();
            M2();
            Console.WriteLine(m);

            //this
            int n = 10;

            if (n == 10)
            {
                int x = 100;
                x++;

            }
            //Console.WriteLine(x);
            //x????
        }
        //public MyClass()
        //{
        //    //ComputerUser
        //    //Calculator
        //}
    }
}