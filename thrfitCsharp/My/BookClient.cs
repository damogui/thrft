using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thrift.Protocol;
using Thrift.Transport;

namespace thrfitCsharp.My
{
    class BookClient
    {

        static Dictionary<String, String> map = new Dictionary<String, String>();
        static List<Blog> blogs = new List<Blog>();

        public void startClient()
        {
            TTransport transport = new TSocket("localhost", 7912);//启用服务端
            try
            {

                TProtocol protocol = new TBinaryProtocol(transport);
                MyCase.Client client = new MyCase.Client(protocol);
                transport.Open();
                Console.WriteLine("csharp client open .....");
                if (map != null)
                {
                    map.Clear();
                }
                map.Add("url", "http://amosli.cnblogs.com");
                map.Add("username", "amosli");

                //case1
                client.Test1(10, 21, "3");

                //case2
                client.Test2(map);

                //case3            
                client.Test3();

                Blog blog = new Blog();
                blog.Content = Encoding.UTF8.GetBytes("this is blog content");
                blog.CreatedTime = DateTime.Now.Ticks;
                blog.Id = "543322";
                blog.IpAddress = "127.0.0.1";
                blog.Topic = "this is blog topic";
                blogs.Add(blog);
                //case4
                client.Test4(new List<Book>());

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (transport != null)
                    transport.Close();//close
            }

        }
    }
}
