using NewLife;
using NewLife.Cube;

using System.ComponentModel;

namespace Tech.Cluee.HisWeb.Areas.His
{
    [DisplayName("医院管理")]
    public class HisArea : AreaBase
    {
        public HisArea() : base(nameof(HisArea).TrimEnd("Area")) { }

        static HisArea()
        {
            RegisterArea<HisArea>();
        }
    }
}
