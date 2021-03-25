using AntJob;
using AntJob.Providers;

using NewLife.Log;

using System;

namespace Tech.Cluee.HisAgent
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            XTrace.UseConsole();

            //获取当前配置
            AntSetting set = AntSetting.Current;

            //1.实例化调度器
            Scheduler scr = new Scheduler
            {

                //使用分布式调度引擎替换默认的本地文件调度
                Provider = new NetworkJobProvider()
                {
                    Server = set.Server,
                    AppID = set.AppID,
                    Secret = set.Secret
                }
            };

            //2.添加作业处理器
            scr.Handlers.Add(new HelloJob());
            scr.Handlers.Add(new BuildPatientJob());
            scr.Handlers.Add(new BuildWillJob());

            //3.启动调度引擎，调度内部多线程处理
            scr.Start();

            Console.WriteLine("OK");

            Console.ReadKey();

        }
    }
}
