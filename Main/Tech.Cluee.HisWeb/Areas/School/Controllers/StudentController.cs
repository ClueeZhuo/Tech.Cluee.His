using NewLife.Cube;

using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;

using Tech.Cluee.HisWeb.Areas.School.Model;

using XCode.Membership;

namespace Tech.Cluee.HisWeb.Areas.School.Controllers
{
    [SchoolArea]
    [DisplayName("学生")]
    public class StudentController : EntityController<Student>
    {
        static StudentController()
        {
            ListFields.RemoveField("CreateUserID");
            ListFields.RemoveField("UpdateUserID");
            //FormFields
        }

        protected override IDictionary<MethodInfo, int> ScanActionMenu(IMenu menu)
        {
            menu.Visible = true;
            return base.ScanActionMenu(menu);
        }
    }
}
