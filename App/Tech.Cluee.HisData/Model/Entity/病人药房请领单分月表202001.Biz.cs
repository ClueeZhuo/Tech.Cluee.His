using NewLife;
using NewLife.Data;

using System;
using System.Collections.Generic;

using XCode;
using XCode.Membership;

namespace Tech.Cluee.HisData.Model
{
    /// <summary>病人药房请领单分月表202001</summary>
    public partial class ZYYFQLD : Entity<ZYYFQLD>
    {
        #region 对象操作
        static ZYYFQLD()
        {
            // 累加字段，生成 Update xx Set Count=Count+1234 Where xxx
            //var df = Meta.Factory.AdditionalFields;
            //df.Add(nameof(Qlrq));

            // 过滤器 UserModule、TimeModule、IPModule
            Meta.Modules.Add<UserModule>();
            Meta.Modules.Add<TimeModule>();
            Meta.Modules.Add<IPModule>();
        }

        /// <summary>验证并修补数据，通过抛出异常的方式提示验证失败。</summary>
        /// <param name="isNew">是否插入</param>
        public override void Valid(bool isNew)
        {
            // 如果没有脏数据，则不需要进行任何处理
            if (!HasDirty)
            {
                return;
            }

            // 建议先调用基类方法，基类方法会做一些统一处理
            base.Valid(isNew);

            // 在新插入数据或者修改了指定字段时进行修正
            // 货币保留6位小数
            DJ = Math.Round(DJ, 6);
            // 处理当前已登录用户信息，可以由UserModule过滤器代劳
            /*var user = ManageProvider.User;
            if (user != null)
            {
                if (isNew && !Dirtys[nameof(CreateUserID)]) CreateUserID = user.ID;
                if (!Dirtys[nameof(UpdateUserID)]) UpdateUserID = user.ID;
            }*/
            //if (isNew && !Dirtys[nameof(CreateTime)]) CreateTime = DateTime.Now;
            //if (!Dirtys[nameof(UpdateTime)]) UpdateTime = DateTime.Now;
            //if (isNew && !Dirtys[nameof(CreateIP)]) CreateIP = ManageProvider.UserHost;
            //if (!Dirtys[nameof(UpdateIP)]) UpdateIP = ManageProvider.UserHost;
        }

        ///// <summary>首次连接数据库时初始化数据，仅用于实体类重载，用户不应该调用该方法</summary>
        //[EditorBrowsable(EditorBrowsableState.Never)]
        //protected override void InitData()
        //{
        //    // InitData一般用于当数据表没有数据时添加一些默认数据，该实体类的任何第一次数据库操作都会触发该方法，默认异步调用
        //    if (Meta.Session.Count > 0) return;

        //    if (XTrace.Debug) XTrace.WriteLine("开始初始化ZYYFQLD[病人药房请领单分月表202001]数据……");

        //    var entity = new ZYYFQLD();
        //    entity.ID = 0;
        //    entity.Qlrq = 0;
        //    entity.Qlsj = 0;
        //    entity.Ksbm = "abc";
        //    entity.Yzgroupid = 0;
        //    entity.Bhid = 0;
        //    entity.Yzbm = "abc";
        //    entity.DJ = 0.0;
        //    entity.SL = 0.0;
        //    entity.Yfbm = "abc";
        //    entity.Fyrq = 0;
        //    entity.State = 0;
        //    entity.Remark = "abc";
        //    entity.CreateUser = "abc";
        //    entity.CreateUserID = 0;
        //    entity.CreateTime = DateTime.Now;
        //    entity.CreateIP = "abc";
        //    entity.UpdateUser = "abc";
        //    entity.UpdateUserID = 0;
        //    entity.UpdateTime = DateTime.Now;
        //    entity.UpdateIP = "abc";
        //    entity.Insert();

        //    if (XTrace.Debug) XTrace.WriteLine("完成初始化ZYYFQLD[病人药房请领单分月表202001]数据！");
        //}

        ///// <summary>已重载。基类先调用Valid(true)验证数据，然后在事务保护内调用OnInsert</summary>
        ///// <returns></returns>
        //public override Int32 Insert()
        //{
        //    return base.Insert();
        //}

        ///// <summary>已重载。在事务保护范围内处理业务，位于Valid之后</summary>
        ///// <returns></returns>
        //protected override Int32 OnDelete()
        //{
        //    return base.OnDelete();
        //}
        #endregion

        #region 扩展属性
        #endregion

        #region 扩展查询
        /// <summary>根据编号查找</summary>
        /// <param name="id">编号</param>
        /// <returns>实体对象</returns>
        public static ZYYFQLD FindByID(int id)
        {
            if (id <= 0)
            {
                return null;
            }

            // 实体缓存
            if (Meta.Session.Count < 1000)
            {
                return Meta.Cache.Find(e => e.ID == id);
            }

            // 单对象缓存
            return Meta.SingleCache[id];

            //return Find(_.ID == id);
        }

        /// <summary>根据病人ID查找</summary>
        /// <param name="bhid">病人ID</param>
        /// <returns>实体列表</returns>
        public static IList<ZYYFQLD> FindAllByBhid(int bhid)
        {
            // 实体缓存
            if (Meta.Session.Count < 1000)
            {
                return Meta.Cache.FindAll(e => e.Bhid == bhid);
            }

            return FindAll(_.Bhid == bhid);
        }
        #endregion

        #region 高级查询
        /// <summary>高级查询</summary>
        /// <param name="bhid">病人ID</param>
        /// <param name="start">更新时间开始</param>
        /// <param name="end">更新时间结束</param>
        /// <param name="key">关键字</param>
        /// <param name="page">分页参数信息。可携带统计和数据权限扩展查询等信息</param>
        /// <returns>实体列表</returns>
        public static IList<ZYYFQLD> Search(int bhid, DateTime start, DateTime end, string key, PageParameter page)
        {
            WhereExpression exp = new WhereExpression();

            if (bhid >= 0)
            {
                exp &= _.Bhid == bhid;
            }

            exp &= _.UpdateTime.Between(start, end);
            if (!key.IsNullOrEmpty())
            {
                exp &= _.Ksbm.Contains(key) | _.Yzbm.Contains(key) | _.Yfbm.Contains(key) | _.Remark.Contains(key) | _.CreateUser.Contains(key) | _.CreateIP.Contains(key) | _.UpdateUser.Contains(key) | _.UpdateIP.Contains(key);
            }

            return FindAll(exp, page);
        }

        // Select Count(ID) as ID,Category From ZYYFQLD Where CreateTime>'2020-01-24 00:00:00' Group By Category Order By ID Desc limit 20
        //static readonly FieldCache<ZYYFQLD> _CategoryCache = new FieldCache<ZYYFQLD>(nameof(Category))
        //{
        //Where = _.CreateTime > DateTime.Today.AddDays(-30) & Expression.Empty
        //};

        ///// <summary>获取类别列表，字段缓存10分钟，分组统计数据最多的前20种，用于魔方前台下拉选择</summary>
        ///// <returns></returns>
        //public static IDictionary<String, String> GetCategoryList() => _CategoryCache.FindAllName();
        #endregion

        #region 业务操作
        #endregion
    }
}