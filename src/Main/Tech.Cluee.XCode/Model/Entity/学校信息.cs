using System;
using System.ComponentModel;

using XCode;
using XCode.Configuration;
using XCode.DataAccessLayer;

namespace Tech.Cluee.XCode.Module
{
    /// <summary>学校信息</summary>
    [Serializable]
    [DataObject]
    [Description("学校信息")]
    [BindTable("School", Description = "学校信息", ConnName = "SmartEdu", DbType = DatabaseType.SqlServer)]
    public partial class School
    {
        #region 属性
        private long _Id;
        /// <summary>自增主键</summary>
        [DisplayName("自增主键")]
        [Description("自增主键")]
        [DataObjectField(true, true, false, 0)]
        [BindColumn("Id", "自增主键", "")]
        public long Id { get => _Id; set { if (OnPropertyChanging("Id", value)) { _Id = value; OnPropertyChanged("Id"); } } }

        private string _Code;
        /// <summary>学校编号</summary>
        [DisplayName("学校编号")]
        [Description("学校编号")]
        [DataObjectField(false, false, false, 256)]
        [BindColumn("Code", "学校编号", "", Master = true)]
        public string Code { get => _Code; set { if (OnPropertyChanging("Code", value)) { _Code = value; OnPropertyChanged("Code"); } } }

        private string _Name;
        /// <summary>学校名称</summary>
        [DisplayName("学校名称")]
        [Description("学校名称")]
        [DataObjectField(false, false, false, 256)]
        [BindColumn("Name", "学校名称", "", Master = true)]
        public string Name { get => _Name; set { if (OnPropertyChanging("Name", value)) { _Name = value; OnPropertyChanged("Name"); } } }

        private bool _IsDelete;
        /// <summary>是否删除</summary>
        [DisplayName("是否删除")]
        [Description("是否删除")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("IsDelete", "是否删除", "")]
        public bool IsDelete { get => _IsDelete; set { if (OnPropertyChanging("IsDelete", value)) { _IsDelete = value; OnPropertyChanged("IsDelete"); } } }
        #endregion

        #region 获取/设置 字段值
        /// <summary>获取/设置 字段值</summary>
        /// <param name="name">字段名</param>
        /// <returns></returns>
        public override object this[string name]
        {
            get
            {
                switch (name)
                {
                    case "Id": return _Id;
                    case "Code": return _Code;
                    case "Name": return _Name;
                    case "IsDelete": return _IsDelete;
                    default: return base[name];
                }
            }
            set
            {
                switch (name)
                {
                    case "Id": _Id = value.ToLong(); break;
                    case "Code": _Code = Convert.ToString(value); break;
                    case "Name": _Name = Convert.ToString(value); break;
                    case "IsDelete": _IsDelete = value.ToBoolean(); break;
                    default: base[name] = value; break;
                }
            }
        }
        #endregion

        #region 字段名
        /// <summary>取得学校信息字段信息的快捷方式</summary>
        public partial class _
        {
            /// <summary>自增主键</summary>
            public static readonly Field Id = FindByName("Id");

            /// <summary>学校编号</summary>
            public static readonly Field Code = FindByName("Code");

            /// <summary>学校名称</summary>
            public static readonly Field Name = FindByName("Name");

            /// <summary>是否删除</summary>
            public static readonly Field IsDelete = FindByName("IsDelete");

            private static Field FindByName(string name)
            {
                return Meta.Table.FindByName(name);
            }
        }

        /// <summary>取得学校信息字段名称的快捷方式</summary>
        public partial class __
        {
            /// <summary>自增主键</summary>
            public const string Id = "Id";

            /// <summary>学校编号</summary>
            public const string Code = "Code";

            /// <summary>学校名称</summary>
            public const string Name = "Name";

            /// <summary>是否删除</summary>
            public const string IsDelete = "IsDelete";
        }
        #endregion
    }
}