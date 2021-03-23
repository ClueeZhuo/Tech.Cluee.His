using AntJob;

using System;

namespace Tech.Cluee.HisAgent
{
    public class HelloJob : Handler
    {
        public HelloJob()
        {
            AntJob.Data.IJob job = Job;
            job.Start = DateTime.Today;
            job.Step = 10;
        }

        protected override int Execute(JobContext ctx)
        {
            //当前任务时间
            DateTime time = ctx.Task.Start;
            WriteLog($"新生命蚂蚁调度系统!当前任务时间：{time}");

            //成功处理数据量
            return 1;
        }
    }
}
