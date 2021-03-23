using NewLife;
using NewLife.Data;

using System;
using System.Collections.Generic;

using XCode;
using XCode.Cache;
using XCode.Membership;

namespace Tech.Cluee.HisData.Model
{
    /// <summary>病人基本信息</summary>
    public partial class ZYBH0 : Entity<ZYBH0>
    {
        #region 对象操作
        static ZYBH0()
        {
            // 累加字段，生成 Update xx Set Count=Count+1234 Where xxx
            //var df = Meta.Factory.AdditionalFields;
            //df.Add(nameof(Bhid));

            // 过滤器 UserModule、TimeModule、IPModule
            Meta.Modules.Add<UserModule>();
            Meta.Modules.Add<TimeModule>();
            Meta.Modules.Add<IPModule>();

            // 单对象缓存
            //ISingleEntityCache<object, ZYBH0> sc = Meta.SingleCache;
            //sc.FindSlaveKeyMethod = k => Find(_.Bhid == k);
            //sc.GetSlaveKeyMethod = e => e.Bhid;
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

            // 检查唯一索引
            // CheckExist(isNew, nameof(Bhid));
        }

        ///// <summary>首次连接数据库时初始化数据，仅用于实体类重载，用户不应该调用该方法</summary>
        //[EditorBrowsable(EditorBrowsableState.Never)]
        //protected override void InitData()
        //{
        //    // InitData一般用于当数据表没有数据时添加一些默认数据，该实体类的任何第一次数据库操作都会触发该方法，默认异步调用
        //    if (Meta.Session.Count > 0) return;

        //    if (XTrace.Debug) XTrace.WriteLine("开始初始化ZYBH0[病人基本信息]数据……");

        //    var entity = new ZYBH0();
        //    entity.ID = 0;
        //    entity.Bhid = 0;
        //    entity.XM = "abc";
        //    entity.Ryrq = DateTime.Now;
        //    entity.Cyrq = DateTime.Now;
        //    entity.Sfzh = "abc";
        //    entity.FB = "abc";
        //    entity.State = 0;
        //    entity.Flag = 0;
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

        //    if (XTrace.Debug) XTrace.WriteLine("完成初始化ZYBH0[病人基本信息]数据！");
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
        public static ZYBH0 FindByID(int id)
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
        /// <returns>实体对象</returns>
        public static ZYBH0 FindByBhid(int bhid)
        {
            // 实体缓存
            if (Meta.Session.Count < 1000)
            {
                return Meta.Cache.Find(e => e.Bhid == bhid);
            }

            // 单对象缓存
            //return Meta.SingleCache.GetItemWithSlaveKey(bhid) as ZYBH0;

            return Find(_.Bhid == bhid);
        }
        #endregion

        #region 高级查询
        /// <summary>高级查询</summary>
        /// <param name="bhid">病人ID</param>
        /// <param name="start">创建时间开始</param>
        /// <param name="end">创建时间结束</param>
        /// <param name="key">关键字</param>
        /// <param name="page">分页参数信息。可携带统计和数据权限扩展查询等信息</param>
        /// <returns>实体列表</returns>
        public static IList<ZYBH0> Search(int bhid, DateTime start, DateTime end, string key, PageParameter page)
        {
            WhereExpression exp = new WhereExpression();

            if (bhid >= 0)
            {
                exp &= _.Bhid == bhid;
            }

            exp &= _.CreateTime.Between(start, end);
            if (!key.IsNullOrEmpty())
            {
                exp &= _.XM.Contains(key) | _.Sfzh.Contains(key) | _.FB.Contains(key) | _.Remark.Contains(key) | _.CreateUser.Contains(key) | _.CreateIP.Contains(key) | _.UpdateUser.Contains(key) | _.UpdateIP.Contains(key);
            }

            return FindAll(exp, page);
        }

        // Select Count(ID) as ID,Category From ZYBH0 Where CreateTime>'2020-01-24 00:00:00' Group By Category Order By ID Desc limit 20
        //static readonly FieldCache<ZYBH0> _CategoryCache = new FieldCache<ZYBH0>(nameof(Category))
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