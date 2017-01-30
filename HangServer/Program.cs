using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hangfire;
using Hangfire.SqlServer;
using HangLibrary;

namespace HangServer
{
    /*    
        К проекту подключена библиотека "HangLibrary". В ней содержатся методы, которые использует клиент. Иначе сервер не может их десериализовать
         */
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine($"Press \r\n1 for \"critical\" or\r\n2 for \"default\"");
            //char key = Console.ReadKey().KeyChar;
            //string table = "";
            //switch (key)
            //{
            //    case '1': table = "critical"; break;
            //    case '2': table = "default"; break;
            //    default: table = "default"; break;
            //}

            GlobalConfiguration.Configuration.UseSqlServerStorage("Data Source=.\\SQLEXPRESS;Initial Catalog=HangFireTest;Integrated Security=True;MultipleActiveResultSets=True");
            //var options = new BackgroundJobServerOptions { Queues = new[] { table } };
            using (var server = new BackgroundJobServer(/*options*/))
            {
                Console.WriteLine("\r\nHangfire Server started. Press any key to exit...");
                Console.ReadKey();
            }
        }
    }
}
