using System;
using System.IO;
using System.Text;
using System.Threading;
using UzEx.TMQ;
using UzEx.TMQ.Helpers;
using UzEx.TMQ.Models;
using UzEx.TMQ.Repositories;
using UzEx.TMQ.Services;

namespace MQ.Demo
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var xml = File.ReadAllText("IMMain.xml", Encoding.UTF8);
            var uzex = IOHelper.XmlDecode<SE_Info_Main>(xml);

            using (var mq = new TUzExRepository())
            {
                var t = mq.ReceiveTResult(uzex);//TODO: Need do merge our locale server
                var result = new TResult();//TODO: Replicate to remote server

                mq.SendUzExResult(result);
            }

            Console.ReadKey();
        }
    }
}