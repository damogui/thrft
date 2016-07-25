using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thrfitCsharp
{
    class HelloWroldImpl : HelloWorldService.Iface
    {

        public  string sayHello(string username){
            Console.WriteLine("hello"+username);
            return "hello" + username;
        }

        public string Sum(int num1, int num2)
        {
            Console.WriteLine("hello" + (num1+num2));
            return "hello" + (num1+num2);
        }
    }
}
