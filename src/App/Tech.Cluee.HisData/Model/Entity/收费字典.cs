using System;
using System.ComponentModel;

using XCode;
using XCode.Configuration;
using XCode.DataAccessLayer;

namespace Tech.Cluee.HisData.Model
{
    /// <summary>收费字典</summary>
    [Serializable]
    [DataObject]
    [Description("收费字典")]
    [BindIndex("IU_ZDSF_BM", true, "BM")]
    [BindTable("ZDSF", Description = "收费字典", ConnName = "His", DbType = DatabaseType.None)]
    public partial class ZDSF
    {
        #region 属性
        private int _ID;
        /// <summary>编号</summary>
        [DisplayName("编号")]
        [Description("编号")]
        [DataObjectField(true, true, false, 0)]
        [BindColumn("ID", "编号", "")]
        public int ID { get => _ID; set { if (OnPropertyChanging("ID", value)) { _ID = value; OnPropertyChanged("ID"); } } }

        private string _BM;
        /// <summary>编码</summary>
        [DisplayName("编码")]
        [Description("编码")]
        [DataObjectField(false, false, false, 50)]
        [BindColumn("BM", "编码", "", Master = true)]
        public string BM { get => _BM; set { if (OnPropertyChanging("BM", value)) { _BM = value; OnPropertyChanged("BM"); } } }

        private string _DH;
        /// <summary>拼音码</summary>
        [DisplayName("拼音码")]
        [Description("拼音码")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("DH", "拼音码", "")]
        public string DH { get => _DH; set { if (OnPropertyChanging("DH", value)) { _DH = value; OnPropertyChanged("DH"); } } }

        private string _MC;
        /// <summary>名称</summary>
        [DisplayName("名称")]
        [Description("名称")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("MC", "名称", "")]
        public string MC { get => _MC; set { if (OnPropertyChanging("MC", value)) { _MC = value; OnPropertyChanged("MC"); } } }

        private decimal _DJ;
        /// <summary>单价</summary>
        [DisplayName("单价")]
        [Description("单价")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("DJ", "单价", "")]
        public decimal DJ { get => _DJ; set { if (OnPropertyChanging("DJ", value)) { _DJ = value; OnPropertyChanged("DJ"); } } }

        private string _DW;
        /// <summary>单位</summary>
        [DisplayName("单位")]
        [Description("单位")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("DW", "单位", "")]
        public string DW { get => _DW; set { if (OnPropertyChanging("DW", value)) { _DW = value; OnPropertyChanged("DW"); } } }

        private int _Mzyflb;
        /// <summary>门诊费用类别</summary>
        [DisplayName("门诊费用类别")]
        [Description("门诊费用类别")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("Mzyflb", "门诊费用类别", "")]
        public int Mzyflb { get => _Mzyflb; set { if (OnPropertyChanging("Mzyflb", value)) { _Mzyflb = value; OnPropertyChanged("Mzyflb"); } } }

        private int _Zyfylb;
        /// <summary>住院费用类别</summary>
        [DisplayName("住院费用类别")]
        [Description("住院费用类别")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("Zyfylb", "住院费用类别", "")]
        public int Zyfylb { get => _Zyfylb; set { if (OnPropertyChanging("Zyfylb", value)) { _Zyfylb = value; OnPropertyChanged("Zyfylb"); } } }

        private double _Zfbl;
        /// <summary>自费比例</summary>
        [DisplayName("自费比例")]
        [Description("自费比例")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("Zfbl", "自费比例", "")]
        public double Zfbl { get => _Zfbl; set { if (OnPropertyChanging("Zfbl", value)) { _Zfbl = value; OnPropertyChanged("Zfbl"); } } }

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
                    case "BM": return _BM;
                    case "DH": return _DH;
                    case "MC": return _MC;
                    case "DJ": return _DJ;
                    case "DW": return _DW;
                    case "Mzyflb": return _Mzyflb;
                    case "Zyfylb": return _Zyfylb;
                    case "Zfbl": return _Zfbl;
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
                    case "BM": _BM = Convert.ToString(value); break;
                    case "DH": _DH = Convert.ToString(value); break;
                    case "MC": _MC = Convert.ToString(value); break;
                    case "DJ": _DJ = Convert.ToDecimal(value); break;
                    case "DW": _DW = Convert.ToString(value); break;
                    case "Mzyflb": _Mzyflb = value.ToInt(); break;
                    case "Zyfylb": _Zyfylb = value.ToInt(); break;
                    case "Zfbl": _Zfbl = value.ToDouble(); break;
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
        /// <summary>取得收费字典字段信息的快捷方式</summary>
        public partial class _
        {
            /// <summary>编号</summary>
            public static readonly Field ID = FindByName("ID");

            /// <summary>编码</summary>
            public static readonly Field BM = FindByName("BM");

            /// <summary>拼音码</summary>
            public static readonly Field DH = FindByName("DH");

            /// <summary>名称</summary>
            public static readonly Field MC = FindByName("MC");

            /// <summary>单价</summary>
            public static readonly Field DJ = FindByName("DJ");

            /// <summary>单位</summary>
            public static readonly Field DW = FindByName("DW");

            /// <summary>门诊费用类别</summary>
            public static readonly Field Mzyflb = FindByName("Mzyflb");

            /// <summary>住院费用类别</summary>
            public static readonly Field Zyfylb = FindByName("Zyfylb");

            /// <summary>自费比例</summary>
            public static readonly Field Zfbl = FindByName("Zfbl");

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

        /// <summary>取得收费字典字段名称的快捷方式</summary>
        public partial class __
        {
            /// <summary>编号</summary>
            public const string ID = "ID";

            /// <summary>编码</summary>
            public const string BM = "BM";

            /// <summary>拼音码</summary>
            public const string DH = "DH";

            /// <summary>名称</summary>
            public const string MC = "MC";

            /// <summary>单价</summary>
            public const string DJ = "DJ";

            /// <summary>单位</summary>
            public const string DW = "DW";

            /// <summary>门诊费用类别</summary>
            public const string Mzyflb = "Mzyflb";

            /// <summary>住院费用类别</summary>
            public const string Zyfylb = "Zyfylb";

            /// <summary>自费比例</summary>
            public const string Zfbl = "Zfbl";

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