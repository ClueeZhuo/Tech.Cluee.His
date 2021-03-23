using AntJob;

using NewLife.Security;

using System;
using System.Collections.Generic;

using Tech.Cluee.HisData.Model;

using XCode;

namespace Tech.Cluee.HisAgent
{
    public class BuildPatientJob : Handler
    {
        public BuildPatientJob()
        {
            AntJob.Data.IJob job = Job;
            job.Start = DateTime.Today;
            job.Step = 15;
        }

        protected override int Execute(JobContext ctx)
        {
            // 随机造几个病人
            int count = Rand.Next(1, 9);
            List<ZYBH0> list = new List<ZYBH0>();
            for (int i = 0; i < count; i++)
            {
                DateTime time = DateTime.Now.AddSeconds(Rand.Next(-30 * 24 * 3600, 0));
                DateTime time2 = time.AddSeconds(Rand.Next(3600, 10 * 24 * 3600));
                ZYBH0 pi = new ZYBH0
                {
                    Bhid = Rand.Next(999999),
                    XM = Rand.NextString(8),
                    Ryrq = time,
                    Cyrq = time2,
                    Sfzh = Rand.NextString(18),
                    FB = Rand.NextString(6),
                    State = Rand.Next(8),
                    Flag = Rand.Next(2),
                };
                list.Add(pi);
            }
            list.Insert(true);
            // 成功处理数据量
            return count;
        }
    }
}
