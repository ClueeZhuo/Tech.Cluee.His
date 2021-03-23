using System;
using System.ComponentModel;

using XCode;
using XCode.Configuration;
using XCode.DataAccessLayer;

namespace Tech.Cluee.HisData.Model
{
    /// <summary>病人医嘱信息</summary>
    [Serializable]
    [DataObject]
    [Description("病人医嘱信息")]
    [BindIndex("IU_ZYBHYZ0_BHID_MGROUPID", true, "BHID,MGROUPID")]
    [BindIndex("IX_ZYBHYZ0_BHID", false, "BHID")]
    [BindTable("ZYBHYZ0", Description = "病人医嘱信息", ConnName = "His", DbType = DatabaseType.SQLite)]
    public partial class ZYBHYZ0
    {
        #region 属性
        private int _ID;
        /// <summary>编号</summary>
        [DisplayName("编号")]
        [Description("编号")]
        [DataObjectField(true, true, false, 0)]
        [BindColumn("ID", "编号", "")]
        public int ID { get => _ID; set { if (OnPropertyChanging("ID", value)) { _ID = value; OnPropertyChanged("ID"); } } }

        private int _Bhid;
        /// <summary>病人ID</summary>
        [DisplayName("病人ID")]
        [Description("病人ID")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("Bhid", "病人ID", "")]
        public int Bhid { get => _Bhid; set { if (OnPropertyChanging("Bhid", value)) { _Bhid = value; OnPropertyChanged("Bhid"); } } }

        private int _Mgroupid;
        /// <summary>医嘱组号</summary>
        [DisplayName("医嘱组号")]
        [Description("医嘱组号")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("Mgroupid", "医嘱组号", "", Master = true)]
        public int Mgroupid { get => _Mgroupid; set { if (OnPropertyChanging("Mgroupid", value)) { _Mgroupid = value; OnPropertyChanged("Mgroupid"); } } }

        private DateTime _Kyzrq;
        /// <summary>开医嘱日期</summary>
        [DisplayName("开医嘱日期")]
        [Description("开医嘱日期")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("Kyzrq", "开医嘱日期", "")]
        public DateTime Kyzrq { get => _Kyzrq; set { if (OnPropertyChanging("Kyzrq", value)) { _Kyzrq = value; OnPropertyChanged("Kyzrq"); } } }

        private DateTime _Tyzrq;
        /// <summary>停医嘱日期</summary>
        [DisplayName("停医嘱日期")]
        [Description("停医嘱日期")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("Tyzrq", "停医嘱日期", "")]
        public DateTime Tyzrq { get => _Tyzrq; set { if (OnPropertyChanging("Tyzrq", value)) { _Tyzrq = value; OnPropertyChanged("Tyzrq"); } } }

        private string _Kyzys;
        /// <summary>开医嘱医生</summary>
        [DisplayName("开医嘱医生")]
        [Description("开医嘱医生")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Kyzys", "开医嘱医生", "")]
        public string Kyzys { get => _Kyzys; set { if (OnPropertyChanging("Kyzys", value)) { _Kyzys = value; OnPropertyChanged("Kyzys"); } } }

        private int _State;
        /// <summary>状态</summary>
        [DisplayName("状态")]
        [Description("状态")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("State", "状态", "")]
        public int State { get => _State; set { if (OnPropertyChanging("State", value)) { _State = value; OnPropertyChanged("State"); } } }

        private string _CreateUser;
        /// <summary>创建者</summary>
        [DisplayName("创建者")]
        [Description("创建者")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("CreateUser", "创建者", "")]
        public string CreateUser { get => _CreateUser; set { if (OnPropertyChanging("CreateUser", value)) { _CreateUser = value; OnPropertyChanged("CreateUser"); } } }

        private int _CreateUserID;
        /// <summary>创建者</summary>
        [DisplayName("创建者")]
        [Description("创建者")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("CreateUserID", "创建者", "")]
        public int CreateUserID { get => _CreateUserID; set { if (OnPropertyChanging("CreateUserID", value)) { _CreateUserID = value; OnPropertyChanged("CreateUserID"); } } }

        private DateTime _CreateTime;
        /// <summary>创建时间</summary>
        [DisplayName("创建时间")]
        [Description("创建时间")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("CreateTime", "创建时间", "")]
        public DateTime CreateTime { get => _CreateTime; set { if (OnPropertyChanging("CreateTime", value)) { _CreateTime = value; OnPropertyChanged("CreateTime"); } } }

        private string _CreateIP;
        /// <summary>创建地址</summary>
        [DisplayName("创建地址")]
        [Description("创建地址")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("CreateIP", "创建地址", "")]
        public string CreateIP { get => _CreateIP; set { if (OnPropertyChanging("CreateIP", value)) { _CreateIP = value; OnPropertyChanged("CreateIP"); } } }

        private string _UpdateUser;
        /// <summary>更新者</summary>
        [DisplayName("更新者")]
        [Description("更新者")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("UpdateUser", "更新者", "")]
        public string UpdateUser { get => _UpdateUser; set { if (OnPropertyChanging("UpdateUser", value)) { _UpdateUser = value; OnPropertyChanged("UpdateUser"); } } }

        private int _UpdateUserID;
        /// <summary>更新者</summary>
        [DisplayName("更新者")]
        [Description("更新者")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("UpdateUserID", "更新者", "")]
        public int UpdateUserID { get => _UpdateUserID; set { if (OnPropertyChanging("UpdateUserID", value)) { _UpdateUserID = value; OnPropertyChanged("UpdateUserID"); } } }

        private DateTime _UpdateTime;
        /// <summary>更新时间</summary>
        [DisplayName("更新时间")]
        [Description("更新时间")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("UpdateTime", "更新时间", "")]
        public DateTime UpdateTime { get => _UpdateTime; set { if (OnPropertyChanging("UpdateTime", value)) { _UpdateTime = value; OnPropertyChanged("UpdateTime"); } } }

        private string _UpdateIP;
        /// <summary>更新地址</summary>
        [DisplayName("更新地址")]
        [Description("更新地址")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("UpdateIP", "更新地址", "")]
        public string UpdateIP { get => _UpdateIP; set { if (OnPropertyChanging("UpdateIP", value)) { _UpdateIP = value; OnPropertyChanged("UpdateIP"); } } }
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
                    case "ID": return _ID;
                    case "Bhid": return _Bhid;
                    case "Mgroupid": return _Mgroupid;
                    case "Kyzrq": return _Kyzrq;
                    case "Tyzrq": return _Tyzrq;
                    case "Kyzys": return _Kyzys;
                    case "State": return _State;
                    case "CreateUser": return _CreateUser;
                    case "CreateUserID": return _CreateUserID;
                    case "CreateTime": return _CreateTime;
                    case "CreateIP": return _CreateIP;
                    case "UpdateUser": return _UpdateUser;
                    case "UpdateUserID": return _UpdateUserID;
                    case "UpdateTime": return _UpdateTime;
                    case "UpdateIP": return _UpdateIP;
                    default: return base[name];
                }
            }
            set
            {
                switch (name)
                {
                    case "ID": _ID = value.ToInt(); break;
                    case "Bhid": _Bhid = value.ToInt(); break;
                    case "Mgroupid": _Mgroupid = value.ToInt(); break;
                    case "Kyzrq": _Kyzrq = value.ToDateTime(); break;
                    case "Tyzrq": _Tyzrq = value.ToDateTime(); break;
                    case "Kyzys": _Kyzys = Convert.ToString(value); break;
                    case "State": _State = value.ToInt(); break;
                    case "CreateUser": _CreateUser = Convert.ToString(value); break;
                    case "CreateUserID": _CreateUserID = value.ToInt(); break;
                    case "CreateTime": _CreateTime = value.ToDateTime(); break;
                    case "CreateIP": _CreateIP = Convert.ToString(value); break;
                    case "UpdateUser": _UpdateUser = Convert.ToString(value); break;
                    case "UpdateUserID": _UpdateUserID = value.ToInt(); break;
                    case "UpdateTime": _UpdateTime = value.ToDateTime(); break;
                    case "UpdateIP": _UpdateIP = Convert.ToString(value); break;
                    default: base[name] = value; break;
                }
            }
        }
        #endregion

        #region 字段名
        /// <summary>取得病人医嘱信息字段信息的快捷方式</summary>
        public partial class _
        {
            /// <summary>编号</summary>
            public static readonly Field ID = FindByName("ID");

            /// <summary>病人ID</summary>
            public static readonly Field Bhid = FindByName("Bhid");

            /// <summary>医嘱组号</summary>
            public static readonly Field Mgroupid = FindByName("Mgroupid");

            /// <summary>开医嘱日期</summary>
            public static readonly Field Kyzrq = FindByName("Kyzrq");

            /// <summary>停医嘱日期</summary>
            public static readonly Field Tyzrq = FindByName("Tyzrq");

            /// <summary>开医嘱医生</summary>
            public static readonly Field Kyzys = FindByName("Kyzys");

            /// <summary>状态</summary>
            public static readonly Field State = FindByName("State");

            /// <summary>创建者</summary>
            public static readonly Field CreateUser = FindByName("CreateUser");

            /// <summary>创建者</summary>
            public static readonly Field CreateUserID = FindByName("CreateUserID");

            /// <summary>创建时间</summary>
            public static readonly Field CreateTime = FindByName("CreateTime");

            /// <summary>创建地址</summary>
            public static readonly Field CreateIP = FindByName("CreateIP");

            /// <summary>更新者</summary>
            public static readonly Field UpdateUser = FindByName("UpdateUser");

            /// <summary>更新者</summary>
            public static readonly Field UpdateUserID = FindByName("UpdateUserID");

            /// <summary>更新时间</summary>
            public static readonly Field UpdateTime = FindByName("UpdateTime");

            /// <summary>更新地址</summary>
            public static readonly Field UpdateIP = FindByName("UpdateIP");

            private static Field FindByName(string name)
            {
                return Meta.Table.FindByName(name);
            }
        }

        /// <summary>取得病人医嘱信息字段名称的快捷方式</summary>
        public partial class __
        {
            /// <summary>编号</summary>
            public const string ID = "ID";

            /// <summary>病人ID</summary>
            public const string Bhid = "Bhid";

            /// <summary>医嘱组号</summary>
            public const string Mgroupid = "Mgroupid";

            /// <summary>开医嘱日期</summary>
            public const string Kyzrq = "Kyzrq";

            /// <summary>停医嘱日期</summary>
            public const string Tyzrq = "Tyzrq";

            /// <summary>开医嘱医生</summary>
            public const string Kyzys = "Kyzys";

            /// <summary>状态</summary>
            public const string State = "State";

            /// <summary>创建者</summary>
            public const string CreateUser = "CreateUser";

            /// <summary>创建者</summary>
            public const string CreateUserID = "CreateUserID";

            /// <summary>创建时间</summary>
            public const string CreateTime = "CreateTime";

            /// <summary>创建地址</summary>
            public const string CreateIP = "CreateIP";

            /// <summary>更新者</summary>
            public const string UpdateUser = "UpdateUser";

            /// <summary>更新者</summary>
            public const string UpdateUserID = "UpdateUserID";

            /// <summary>更新时间</summary>
            public const string UpdateTime = "UpdateTime";

            /// <summary>更新地址</summary>
            public const string UpdateIP = "UpdateIP";
        }
        #endregion
    }
}