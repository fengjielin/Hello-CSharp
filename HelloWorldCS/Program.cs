using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldCS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入你的姓名：");
            string name = Console.ReadLine();

            Console.WriteLine("请输入你的故乡：");
            string address = Console.ReadLine();

            Console.WriteLine("请输入你的爱好：");
            string hobby = Console.ReadLine();

            Console.WriteLine("请输入你的年龄：");
            string age = Console.ReadLine();

            Console.WriteLine();
            string newInfo = "你的名字是：" + name + "，故乡是：" + address + "，爱好是：" + hobby + "，年龄是" + age + "岁";
            Console.WriteLine(newInfo);

            bool bo1 = name == "张三";

            if (bo1)
            {
                name = "法外狂徒·张三";
                Console.WriteLine();
                Console.WriteLine("原来是小瘪三：" + name);
            }

            Console.ReadKey();
        }
    }
}
