using  System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace _01练习
{
    class Program
    {
        static void Main(string[] args)
        {

            #region:方法来实现：请计算出一个整型数组的平均值。{ 1, 3, 5, 7, 90, 2, 4, 6, 8, 10 }。要求：计算结果如果有小数，则显示小数点后两位（四舍五入）。Math.Round()
            //int[] arrInt = { 1, 3, 5, 7, 90, 2, 4, 6, 8, 10 ,1};
            //double avg = GetAvg(arrInt);
            //Console.WriteLine("平均值是：{0}", avg);
            //Console.ReadKey();

            #endregion

            #region:通过冒泡排序法对整数数组{ 1, 3, 5, 7, 90, 2, 4, 6, 8, 10 }实现升序排序
            //int[] arrInt = { 1, 3, 5, 7, 90, 2, 4, 6, 8, 10 };
            //for (int i = 0; i < arrInt.Length - 1;  i++)
            //{
            //    for (int j = arrInt.Length - 1; j > i; j--)
            //    {
            //        if (arrInt[j] < arrInt[j - 1])
            //        {
            //            int tmp = arrInt[j];
            //            arrInt[j] = arrInt[j - 1];
            //            arrInt[j - 1] = tmp;
            //        }
            //    }
            //}
            //for(int n = 0;n< arrInt.Length; n++)
            //{
            //    Console.WriteLine(arrInt[n]);
            //}
            //Console.ReadKey();
            #endregion

            #region:统计出该字符中“咳嗽”二字的出现次数，以及每次“咳嗽”出现的索引位置.扩展（*）：统计出每个字符的出现次数
            //string msg = "患者：“大夫，我咳嗽得很重。” 大夫：“你多大年记？”患者：“七十五岁。”大夫：“二十岁咳嗽吗”患者：“不咳嗽。”大夫：“四十岁时咳嗽吗？”患者：“也不咳嗽。”大夫：“那现在不咳嗽，还要等到什么时咳嗽？”";
            //IndexOf()
            //msg.IndexOf("咳嗽",0)
            //记录咳嗽出现的次数
            //int count = 0;
            //int index =0;
            //while( (index = msg.IndexOf("咳嗽", index))!= -1  )
            //{
            //    count++;
            //    Console.WriteLine("第{0}次出现【咳嗽】的索引位置为：{1}",count,index);
            //    index = index + "咳嗽".Length;
            //}

            //Console.WriteLine("【咳嗽】总共出现了{0}次。",count);
            //Console.ReadKey();
            #endregion

            #region 将字符串"  hello      world,你  好 世界   !    "两端空格去掉，并且将其中的所有其他空格都替换成一个空格，输出结果为："hello world,你 好 世界 !"。
            ////int[] a = { };

            //string msg = "  hello      world,你  好 世界   !      ";
            ////msg = msg.Trim();//这样表示去掉两边空格
            //string[] words = msg.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //msg = string.Join(" ", words);

            //Console.WriteLine("==========" + msg + "===================");
            //Console.ReadKey();

            #endregion

            #region 制作一个控制台小程序。要求：用户可以在控制台录入每个学生的姓名，当用户输入quit（不区分大小写）时，程序停止接受用户的输入，并且显示出用户输入的学生的个数，以及每个学生的姓名。效果如图：
            //string name = string.Empty;

            //int count = 0;


            //List<string> list = new List<string>();
            //do
            //{
            //    Console.WriteLine("请输入姓名：");
            //    name = Console.ReadLine();
            //    if (name.IndexOf('王') == 0)
            //    {
            //        count++;
            //    }

            //    list.Add(name);
            //} while (name.ToLower() != "quit");


            ////除去集合中的最后一个元素。
            //list.RemoveAt(list.Count - 1);


            //Console.WriteLine("共输入学生个数：{0}", list.Count);
            //Console.WriteLine("分别是：");
            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}
            //Console.WriteLine("姓王的同学的个数是：{0}", count);
            //Console.ReadKey();


            #endregion


            #region 将普通日期格式：“2011年6月4日” 转换成汉字日期格式：“二零一一年六月四日”。暂时不考虑10日、13日、23日等“带十”的问题。

            //string msg = "1992年5月1日";

            //msg = ConvertToDate(msg);

            //Console.WriteLine(msg);
            //Console.ReadKey();

            #endregion
            //ItcastClass ic = new ItcastClass();
            //////Console.WriteLine(ic._names[0]);
            ////for (int i = 0; i < ic._names.Length; i++)
            ////{
            ////    Console.WriteLine(ic._names[i]);
            ////}

            //for (int i = 0; i < ic.Count; i++)
            //{
            //    Console.WriteLine(ic[i]);
            //}
            //ic[0] = "sk";
            //Console.ReadKey();

            #region 请将字符串数组{ "中国", "美国", "巴西", "澳大利亚", "加拿大" }中的内容反转。然后输出反转后的数组。不能用数组的Reverse()方法。

            string[] msg = { "中国", "美国", "巴西", "澳大利亚", "加拿大" };

            //所有数组都是引用类型。
            //int[] arr;

            //反转该数组
            MyReverse(msg);


            for (int i = 0; i < msg.Length; i++)
            {
                Console.WriteLine(msg[i]);
            }
            Console.ReadKey();

            #endregion
        }

        private static void MyReverse(string[] msg)
        {
            for (int i = 0; i < msg.Length / 2; i++)
            {
                string tmp = msg[i];
                msg[i] = msg[msg.Length - 1 - i];
                msg[msg.Length - 1 - i] = tmp;
            }
        }

        private static string ConvertToDate(string msg)
        {
            //不能这么做，因为字符串具有不可变性。
            //msg[0] = '二';
            char[] chs = msg.ToCharArray();

            #region 循环修改字符
            for (int i = 0; i < chs.Length; i++)
            {
                switch (chs[i])
                {
                    case '0':
                        chs[i] = '零';
                        break;
                    case '1':
                        chs[i] = '一';
                        break;
                    case '2':
                        chs[i] = '二';
                        break;
                    case '3':
                        chs[i] = '三';
                        break;
                    case '4':
                        chs[i] = '四';
                        break;
                    case '5':
                        chs[i] = '五';
                        break;
                    case '6':
                        chs[i] = '六';
                        break;
                    case '7':
                        chs[i] = '七';
                        break;
                    case '8':
                        chs[i] = '八';
                        break;
                    case '9':
                        chs[i] = '九';
                        break;

                    default:
                        break;
                }
            }
            #endregion

            //把一个char数组转换为字符串
            return new string(chs);
        }

    private static double GetAvg(int[] arrInt)
        {
         int sum = 0;
            for(int i = 0; i < arrInt.Length; i++)
            {
                sum +=arrInt[i];
            }
        //return Math.Round (sum / (double)arrInt.Length,2);
            return sum /(double ) arrInt.Length ;
        }
    }
}