using System;
using System.ComponentModel;

using XCode;
using XCode.Configuration;
using XCode.DataAccessLayer;

namespace Tech.Cluee.HisWeb.Areas.School.Model
{
    /// <summary>交易</summary>
    [Serializable]
    [DataObject]
    [Description("交易")]
    [BindTable("Trade", Description = "交易", ConnName = "Bill", DbType = DatabaseType.None)]
    public partial class Trade
    {
        #region 属性
        private int _ID;
        /// <summary>订单编号</summary>
        [DisplayName("订单编号")]
        [Description("订单编号")]
        [DataObjectField(true, true, false, 0)]
        [BindColumn("ID", "订单编号", "")]
        public int ID { get => _ID; set { if (OnPropertyChanging("ID", value)) { _ID = value; OnPropertyChanged("ID"); } } }

        private int _NodeID;
        /// <summary>节点号</summary>
        [DisplayName("节点号")]
        [Description("节点号")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("NodeID", "节点号", "")]
        public int NodeID { get => _NodeID; set { if (OnPropertyChanging("NodeID", value)) { _NodeID = value; OnPropertyChanged("NodeID"); } } }

        private string _Tid;
        /// <summary>订单号</summary>
        [DisplayName("订单号")]
        [Description("订单号")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Tid", "订单号", "")]
        public string Tid { get => _Tid; set { if (OnPropertyChanging("Tid", value)) { _Tid = value; OnPropertyChanged("Tid"); } } }

        private int _Status;
        /// <summary>状态</summary>
        [DisplayName("状态")]
        [Description("状态")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("Status", "状态", "")]
        public int Status { get => _Status; set { if (OnPropertyChanging("Status", value)) { _Status = value; OnPropertyChanged("Status"); } } }

        private int _PayStatus;
        /// <summary>是否支付</summary>
        [DisplayName("是否支付")]
        [Description("是否支付")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("PayStatus", "是否支付", "")]
        public int PayStatus { get => _PayStatus; set { if (OnPropertyChanging("PayStatus", value)) { _PayStatus = value; OnPropertyChanged("PayStatus"); } } }

        private int _ShipStatus;
        /// <summary>是否发货</summary>
        [DisplayName("是否发货")]
        [Description("是否发货")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("ShipStatus", "是否发货", "")]
        public int ShipStatus { get => _ShipStatus; set { if (OnPropertyChanging("ShipStatus", value)) { _ShipStatus = value; OnPropertyChanged("ShipStatus"); } } }

        private string _CreateIPReceiverPhone;
        /// <summary>收货人电话</summary>
        [DisplayName("收货人电话")]
        [Description("收货人电话")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("CreateIPReceiverPhone", "收货人电话", "")]
        public string CreateIPReceiverPhone { get => _CreateIPReceiverPhone; set { if (OnPropertyChanging("CreateIPReceiverPhone", value)) { _CreateIPReceiverPhone = value; OnPropertyChanged("CreateIPReceiverPhone"); } } }

        private string _ReceiverMobile;
        /// <summary>收货人手机号</summary>
        [DisplayName("收货人手机号")]
        [Description("收货人手机号")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("ReceiverMobile", "收货人手机号", "")]
        public string ReceiverMobile { get => _ReceiverMobile; set { if (OnPropertyChanging("ReceiverMobile", value)) { _ReceiverMobile = value; OnPropertyChanged("ReceiverMobile"); } } }

        private string _ReceiverState;
        /// <summary>收货省</summary>
        [DisplayName("收货省")]
        [Description("收货省")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("ReceiverState", "收货省", "")]
        public string ReceiverState { get => _ReceiverState; set { if (OnPropertyChanging("ReceiverState", value)) { _ReceiverState = value; OnPropertyChanged("ReceiverState"); } } }

        private string _ReceiverCity;
        /// <summary>收货人区</summary>
        [DisplayName("收货人区")]
        [Description("收货人区")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("ReceiverCity", "收货人区", "")]
        public string ReceiverCity { get => _ReceiverCity; set { if (OnPropertyChanging("ReceiverCity", value)) { _ReceiverCity = value; OnPropertyChanged("ReceiverCity"); } } }

        private string _ReceiverDistrict;
        /// <summary>收货区</summary>
        [DisplayName("收货区")]
        [Description("收货区")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Receiver_District", "收货区", "")]
        public string ReceiverDistrict { get => _ReceiverDistrict; set { if (OnPropertyChanging("ReceiverDistrict", value)) { _ReceiverDistrict = value; OnPropertyChanged("ReceiverDistrict"); } } }

        private string _ReceiverAddress;
        /// <summary>收货地址</summary>
        [DisplayName("收货地址")]
        [Description("收货地址")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("ReceiverAddress", "收货地址", "")]
        public string ReceiverAddress { get => _ReceiverAddress; set { if (OnPropertyChanging("ReceiverAddress", value)) { _ReceiverAddress = value; OnPropertyChanged("ReceiverAddress"); } } }

        private string _BuyerName;
        /// <summary>买家昵称</summary>
        [DisplayName("买家昵称")]
        [Description("买家昵称")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("BuyerName", "买家昵称", "")]
        public string BuyerName { get => _BuyerName; set { if (OnPropertyChanging("BuyerName", value)) { _BuyerName = value; OnPropertyChanged("BuyerName"); } } }

        private int _Created;
        /// <summary>创建时间</summary>
        [DisplayName("创建时间")]
        [Description("创建时间")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("Created", "创建时间", "")]
        public int Created { get => _Created; set { if (OnPropertyChanging("Created", value)) { _Created = value; OnPropertyChanged("Created"); } } }

        private int _Modified;
        /// <summary>是否发送过</summary>
        [DisplayName("是否发送过")]
        [Description("是否发送过")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("Modified", "是否发送过", "")]
        public int Modified { get => _Modified; set { if (OnPropertyChanging("Modified", value)) { _Modified = value; OnPropertyChanged("Modified"); } } }

        private int _IsSend;
        /// <summary>更新者</summary>
        [DisplayName("更新者")]
        [Description("更新者")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("IsSend", "更新者", "")]
        public int IsSend { get => _IsSend; set { if (OnPropertyChanging("IsSend", value)) { _IsSend = value; OnPropertyChanged("IsSend"); } } }

        private string _ErrorMsg;
        /// <summary>错误原因</summary>
        [DisplayName("错误原因")]
        [Description("错误原因")]
        [DataObjectField(false, false, true, 200)]
        [BindColumn("ErrorMsg", "错误原因", "")]
        public string ErrorMsg { get => _ErrorMsg; set { if (OnPropertyChanging("ErrorMsg", value)) { _ErrorMsg = value; OnPropertyChanged("ErrorMsg"); } } }
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
                    case "NodeID": return _NodeID;
                    case "Tid": return _Tid;
                    case "Status": return _Status;
                    case "PayStatus": return _PayStatus;
                    case "ShipStatus": return _ShipStatus;
                    case "CreateIPReceiverPhone": return _CreateIPReceiverPhone;
                    case "ReceiverMobile": return _ReceiverMobile;
                    case "ReceiverState": return _ReceiverState;
                    case "ReceiverCity": return _ReceiverCity;
                    case "ReceiverDistrict": return _ReceiverDistrict;
                    case "ReceiverAddress": return _ReceiverAddress;
                    case "BuyerName": return _BuyerName;
                    case "Created": return _Created;
                    case "Modified": return _Modified;
                    case "IsSend": return _IsSend;
                    case "ErrorMsg": return _ErrorMsg;
                    default: return base[name];
                }
            }
            set
            {
                switch (name)
                {
                    case "ID": _ID = value.ToInt(); break;
                    case "NodeID": _NodeID = value.ToInt(); break;
                    case "Tid": _Tid = Convert.ToString(value); break;
                    case "Status": _Status = value.ToInt(); break;
                    case "PayStatus": _PayStatus = value.ToInt(); break;
                    case "ShipStatus": _ShipStatus = value.ToInt(); break;
                    case "CreateIPReceiverPhone": _CreateIPReceiverPhone = Convert.ToString(value); break;
                    case "ReceiverMobile": _ReceiverMobile = Convert.ToString(value); break;
                    case "ReceiverState": _ReceiverState = Convert.ToString(value); break;
                    case "ReceiverCity": _ReceiverCity = Convert.ToString(value); break;
                    case "ReceiverDistrict": _ReceiverDistrict = Convert.ToString(value); break;
                    case "ReceiverAddress": _ReceiverAddress = Convert.ToString(value); break;
                    case "BuyerName": _BuyerName = Convert.ToString(value); break;
                    case "Created": _Created = value.ToInt(); break;
                    case "Modified": _Modified = value.ToInt(); break;
                    case "IsSend": _IsSend = value.ToInt(); break;
                    case "ErrorMsg": _ErrorMsg = Convert.ToString(value); break;
                    default: base[name] = value; break;
                }
            }
        }
        #endregion

        #region 字段名
        /// <summary>取得交易字段信息的快捷方式</summary>
        public partial class _
        {
            /// <summary>订单编号</summary>
            public static readonly Field ID = FindByName("ID");

            /// <summary>节点号</summary>
            public static readonly Field NodeID = FindByName("NodeID");

            /// <summary>订单号</summary>
            public static readonly Field Tid = FindByName("Tid");

            /// <summary>状态</summary>
            public static readonly Field Status = FindByName("Status");

            /// <summary>是否支付</summary>
            public static readonly Field PayStatus = FindByName("PayStatus");

            /// <summary>是否发货</summary>
            public static readonly Field ShipStatus = FindByName("ShipStatus");

            /// <summary>收货人电话</summary>
            public static readonly Field CreateIPReceiverPhone = FindByName("CreateIPReceiverPhone");

            /// <summary>收货人手机号</summary>
            public static readonly Field ReceiverMobile = FindByName("ReceiverMobile");

            /// <summary>收货省</summary>
            public static readonly Field ReceiverState = FindByName("ReceiverState");

            /// <summary>收货人区</summary>
            public static readonly Field ReceiverCity = FindByName("ReceiverCity");

            /// <summary>收货区</summary>
            public static readonly Field ReceiverDistrict = FindByName("ReceiverDistrict");

            /// <summary>收货地址</summary>
            public static readonly Field ReceiverAddress = FindByName("ReceiverAddress");

            /// <summary>买家昵称</summary>
            public static readonly Field BuyerName = FindByName("BuyerName");

            /// <summary>创建时间</summary>
            public static readonly Field Created = FindByName("Created");

            /// <summary>是否发送过</summary>
            public static readonly Field Modified = FindByName("Modified");

            /// <summary>更新者</summary>
            public static readonly Field IsSend = FindByName("IsSend");

            /// <summary>错误原因</summary>
            public static readonly Field ErrorMsg = FindByName("ErrorMsg");

            private static Field FindByName(string name)
            {
                return Meta.Table.FindByName(name);
            }
        }

        /// <summary>取得交易字段名称的快捷方式</summary>
        public partial class __
        {
            /// <summary>订单编号</summary>
            public const string ID = "ID";

            /// <summary>节点号</summary>
            public const string NodeID = "NodeID";

            /// <summary>订单号</summary>
            public const string Tid = "Tid";

            /// <summary>状态</summary>
            public const string Status = "Status";

            /// <summary>是否支付</summary>
            public const string PayStatus = "PayStatus";

            /// <summary>是否发货</summary>
            public const string ShipStatus = "ShipStatus";

            /// <summary>收货人电话</summary>
            public const string CreateIPReceiverPhone = "CreateIPReceiverPhone";

            /// <summary>收货人手机号</summary>
            public const string ReceiverMobile = "ReceiverMobile";

            /// <summary>收货省</summary>
            public const string ReceiverState = "ReceiverState";

            /// <summary>收货人区</summary>
            public const string ReceiverCity = "ReceiverCity";

            /// <summary>收货区</summary>
            public const string ReceiverDistrict = "ReceiverDistrict";

            /// <summary>收货地址</summary>
            public const string ReceiverAddress = "ReceiverAddress";

            /// <summary>买家昵称</summary>
            public const string BuyerName = "BuyerName";

            /// <summary>创建时间</summary>
            public const string Created = "Created";

            /// <summary>是否发送过</summary>
            public const string Modified = "Modified";

            /// <summary>更新者</summary>
            public const string IsSend = "IsSend";

            /// <summary>错误原因</summary>
            public const string ErrorMsg = "ErrorMsg";
        }
        #endregion
    }
}