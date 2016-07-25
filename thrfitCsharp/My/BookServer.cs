using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thrift.Server;
using Thrift.Transport;

namespace thrfitCsharp.My
{
    class BookServer
    {

        public void StartServer()
        {
            try
            {
                TServerSocket serverTransport = new TServerSocket(7912, 0, false);
                MyCase.Processor processor = new MyCase.Processor(new MyInterface());
                TServer server = new TSimpleServer(processor, serverTransport);
                Console.WriteLine("Starting server on port 7912 ...");
                server.Serve();


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
