using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thrfitCsharp.My
{
    public class MyInterface: MyCase.Iface
    {
        public int Test1(int num1, int num2, string num3)
        {

            Console.WriteLine("方法二一斤实现");
            num3 = "哈哈";
             return (num1+num2);
        }

        public List<string> Test2(Dictionary<string, string> num1)
        {
           

            Console.WriteLine("方法二一斤实现");
            return new List<string>() {"方法二的选项"};
        }

        public void Test3()
        {
            Console.WriteLine("方法三实现");
            
        }

        public void Test4(List<Book> book)
        {
            Console.WriteLine("方法四实现");
        }
    }

}
