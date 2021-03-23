using AntJob;

using NewLife.Security;

using System;

using Tech.Cluee.HisData.Model;

using XCode;

namespace Tech.Cluee.HisAgent
{
    public class BuildWillJob : DataHandler
    {
        public BuildWillJob()
        {
            AntJob.Data.IJob job = Job;
            job.Start = DateTime.Today;
            job.Step = 30;
        }

        public override bool Start()
        {
            // 指定要抽取数据的实体类以及时间字段
            Factory = ZYBH0.Meta.Factory;
            Field = ZYBH0._.CreateTime;
            return base.Start();
        }
        protected override bool ProcessItem(JobContext ctx, IEntity entity)
        {
            ZYBH0 pi = entity as ZYBH0;
            // 创建医嘱信息
            ZYBHYZ0 will = new ZYBHYZ0
            {
                Bhid = pi.Bhid,
                Mgroupid = Rand.Next(9999),
                Kyzrq = pi.Ryrq.AddHours(1),
                Tyzrq = pi.Cyrq.AddHours(-3),
                Kyzys = Rand.NextString(8),
                State = pi.State,
            };
            will.Insert();
            return true;
        }

    }
}
