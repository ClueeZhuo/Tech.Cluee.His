using NewLife.Cube;

using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;

using Tech.Cluee.HisWeb.Areas.School.Model;

using XCode.Membership;

namespace Tech.Cluee.HisWeb.Areas.School.Controllers
{
    [SchoolArea]
    [DisplayName("班级")]
    public class ClassController : EntityController<Class>
    {
        protected override IDictionary<MethodInfo, int> ScanActionMenu(IMenu menu)
        {
            menu.Visible = true;
            return base.ScanActionMenu(menu);
        }
    }
}
