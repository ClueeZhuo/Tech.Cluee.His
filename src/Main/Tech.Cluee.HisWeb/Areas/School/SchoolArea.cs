using NewLife;
using NewLife.Cube;

using System;
using System.ComponentModel;

namespace Tech.Cluee.HisWeb.Areas.School
{
    [DisplayName("教务管理")]
    public class SchoolArea : AreaBase
    {
        public SchoolArea() : base(nameof(SchoolArea).TrimEnd("Area")) { }

        static SchoolArea()
        {
            RegisterArea<SchoolArea>();
        }
    }
}
