using System;
using System.ComponentModel;

using XCode;
using XCode.Configuration;
using XCode.DataAccessLayer;

namespace Tech.Cluee.XCode.Module
{
    /// <summary>学生信息</summary>
    [Serializable]
    [DataObject]
    [Description("学生信息")]
    [BindTable("Student", Description = "学生信息", ConnName = "SmartEdu", DbType = DatabaseType.SqlServer)]
    public partial class Student
    {
        #region 属性
        private long _Id;
        /// <summary>自增主键</summary>
        [DisplayName("自增主键")]
        [Description("自增主键")]
        [DataObjectField(true, true, false, 0)]
        [BindColumn("Id", "自增主键", "")]
        public long Id { get => _Id; set { if (OnPropertyChanging("Id", value)) { _Id = value; OnPropertyChanged("Id"); } } }

        private string _FirstName;
        /// <summary>名</summary>
        [DisplayName("名")]
        [Description("名")]
        [DataObjectField(false, false, false, 256)]
        [BindColumn("FirstName", "名", "")]
        public string FirstName { get => _FirstName; set { if (OnPropertyChanging("FirstName", value)) { _FirstName = value; OnPropertyChanged("FirstName"); } } }

        private string _LastName;
        /// <summary>姓</summary>
        [DisplayName("姓")]
        [Description("姓")]
        [DataObjectField(false, false, false, 256)]
        [BindColumn("LastName", "姓", "")]
        public string LastName { get => _LastName; set { if (OnPropertyChanging("LastName", value)) { _LastName = value; OnPropertyChanged("LastName"); } } }

        private int _Age;
        /// <summary>年龄</summary>
        [DisplayName("年龄")]
        [Description("年龄")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("Age", "年龄", "")]
        public int Age { get => _Age; set { if (OnPropertyChanging("Age", value)) { _Age = value; OnPropertyChanged("Age"); } } }

        private string _IdCard;
        /// <summary>身份证</summary>
        [DisplayName("身份证")]
        [Description("身份证")]
        [DataObjectField(false, false, false, 256)]
        [BindColumn("IdCard", "身份证", "")]
        public string IdCard { get => _IdCard; set { if (OnPropertyChanging("IdCard", value)) { _IdCard = value; OnPropertyChanged("IdCard"); } } }

        private decimal _Balance;
        /// <summary>余额</summary>
        [DisplayName("余额")]
        [Description("余额")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("Balance", "余额", "decimal(18, 4)", Precision = 0, Scale = 4)]
        public decimal Balance { get => _Balance; set { if (OnPropertyChanging("Balance", value)) { _Balance = value; OnPropertyChanged("Balance"); } } }
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
                    case "FirstName": return _FirstName;
                    case "LastName": return _LastName;
                    case "Age": return _Age;
                    case "IdCard": return _IdCard;
                    case "Balance": return _Balance;
                    default: return base[name];
                }
            }
            set
            {
                switch (name)
                {
                    case "Id": _Id = value.ToLong(); break;
                    case "FirstName": _FirstName = Convert.ToString(value); break;
                    case "LastName": _LastName = Convert.ToString(value); break;
                    case "Age": _Age = value.ToInt(); break;
                    case "IdCard": _IdCard = Convert.ToString(value); break;
                    case "Balance": _Balance = Convert.ToDecimal(value); break;
                    default: base[name] = value; break;
                }
            }
        }
        #endregion

        #region 字段名
        /// <summary>取得学生信息字段信息的快捷方式</summary>
        public partial class _
        {
            /// <summary>自增主键</summary>
            public static readonly Field Id = FindByName("Id");

            /// <summary>名</summary>
            public static readonly Field FirstName = FindByName("FirstName");

            /// <summary>姓</summary>
            public static readonly Field LastName = FindByName("LastName");

            /// <summary>年龄</summary>
            public static readonly Field Age = FindByName("Age");

            /// <summary>身份证</summary>
            public static readonly Field IdCard = FindByName("IdCard");

            /// <summary>余额</summary>
            public static readonly Field Balance = FindByName("Balance");

            private static Field FindByName(string name)
            {
                return Meta.Table.FindByName(name);
            }
        }

        /// <summary>取得学生信息字段名称的快捷方式</summary>
        public partial class __
        {
            /// <summary>自增主键</summary>
            public const string Id = "Id";

            /// <summary>名</summary>
            public const string FirstName = "FirstName";

            /// <summary>姓</summary>
            public const string LastName = "LastName";

            /// <summary>年龄</summary>
            public const string Age = "Age";

            /// <summary>身份证</summary>
            public const string IdCard = "IdCard";

            /// <summary>余额</summary>
            public const string Balance = "Balance";
        }
        #endregion
    }
}