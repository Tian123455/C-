using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01练习
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 声明两个变量：int n1=10,n2=20;要求两个变量交换
            //    int n1 = 10, n2 = 20;
            //    int tmp = n1;
            //    n1 = n2;
            //    n2 = tmp;

            //    Console.WriteLine(n1);
            //    Console.WriteLine(n2);
            //    Console.ReadKey();

            #endregion

            #region:用方法来实现：将上题封装一个方法来做，方法有两个参数分别为num1,num2,将两值交换

            //int n1 = 10;
            //int n2 = 20;

            //swap(ref n1, ref n2);
            //Console.WriteLine(n1);
            //Console.WriteLine(n2);
            //Console.ReadKey();

            #endregion

            #region:请用户输入一个字符串，计算字符串中的字符个数，并输出

            //while (true)
            //{
            //    Console.WriteLine("请输入一个字符：");
            //    string msg = Console.ReadLine();
            //    Console.WriteLine("字符串的长度是：{0}",msg.Length);
            //}
            #endregion

            #region:用方法来实现：计算两个数的最大值。

            //Console.WriteLine("请输入两个值：");
            // int num1 = int.Parse (Console.ReadLine());
            //int num2 = int.Parse(Console.ReadLine());
            ////crtl+K+u  取消选中代码注释

            //int max = GetMaxNumber (num1, num2);
            //Console.WriteLine("最大值是：{0}",max);
            //Console.ReadKey();

            //可变参数
            //int max = GetMaxNumbers(10, 30, 40, 50, 80);
            //Console.WriteLine("最大值是：{0}", max);
            //Console.ReadKey();
            #endregion

            #region:用方法来实现：计算1-100之间的所有整数的和
            //int r = GetSum();
            //Console.WriteLine(r);
            //Console.ReadKey ();


            #endregion

            #region:用方法来实现：计算1-100之间的所有奇数的和
            //int r = GetOddSum();
            //Console.WriteLine(r);
            //Console.ReadKey();

            //int r = GetEvenSum();
            //Console.WriteLine(r);
            //Console.ReadKey();


            #endregion

            #region:方法来实现：判断一个给定的整数是否为“质数”

            //while (true)
            //{
            //    Console.WriteLine("请输入一个整数");
            //    int number = Convert .ToInt32(Console.ReadLine());
            //    bool b = Iszhishu(number);
            //    Console.WriteLine(b);
            //}

            #endregion

            #region:方法来实现：计算1-100之间的所有质数（素数）的和

            //int r = GetzhishuSum();
            //Console.WriteLine(r);
            //Console.ReadKey();

            #endregion


            #region:方法来实现：有一个整数数组：{ 1, 3, 5, 7, 90, 2, 4, 6, 8, 10 },找出其中最大值，并输出。不能调用数组的Max()方法
            //int[] arrInt = { 1, 3, 5, 7, 90, 2, 4, 6, 8, 10 };
            //int maxValue = GetMaxFromArray(arrInt);
            //Console.WriteLine(maxValue);
            //Console.ReadKey();

            #endregion


            #region:方法来实现：有一个字符串数组：{ "马龙", "迈克尔乔丹", "雷吉米勒", "蒂姆邓肯", "科比布莱恩特" },请输出最长的字符串

            //string[] names = { "马龙", "迈克尔乔丹", "雷吉米勒", "蒂姆邓肯", "科比布莱恩特" };
            //string maxName = GetMaxName(names);
            //Console.WriteLine(maxName);
            //Console.ReadKey();

            //int[] arr = new int[10];

            //int[] arr1 = new int[3] { 10, 20, 30 };
            //int[] arr2 = { 11, 22, 33 };

            #endregion


        }

        private static string GetMaxName(string[] names)
        {
            string maxName = names[0];
            for(int i=1; i < names.Length; i++)
            {
                if(names.Length  > maxName.Length )
                {
                    maxName = names[i];
                }
            }
            return maxName;
        }

        private static int GetMaxFromArray(int[] arrInt)
        {
           int max = arrInt[0];
            for(int i = 1; i < arrInt.Length; i++)
            {
                if(arrInt[i] > max)
                {
                    max = arrInt[i];
                }
            }
            return max;
        }

        private static int GetzhishuSum()
        {
            int sum = 0;
            for(int i = 2; i <= 100; i++)
            {
                if(Iszhishu(i))
                {
                    sum += i;
                }
            }
            return sum;
        }

        private static bool Iszhishu(int number)
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        private static int GetEvenSum()
        {
            int sum = 0;
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }

        private static int GetOddSum()
        {
            int sum = 0;
            for (int i = 0; i <= 100; i++)
            {
                if(i % 2 != 0)
                {
                    sum += i;
                }
            }
            return sum;
        }

        static int GetSum()
        {
            int result = 0;
            for (int i = 0; i <= 100; i++)
            {
                result = result + i;
            }
            return result;
        }


        static int GetMaxNumbers(params int[] pms)
        {
           int max = pms[0];
            for (int i = 1; i < pms.Length; i++)
            {
                if (pms[i] > max)
                {
                    max = pms[i];
                }
            }
            return max;
        }

        private static int GetMaxNumber(int num1, int num2)
        {
            return (num1 > num2) ? num1 :num2 ;
        }

        private static void swap(ref int n1, ref int n2)
        {
            int tmp = n1;
            n1 = n2;
            n2 = tmp;
        }
    }
}