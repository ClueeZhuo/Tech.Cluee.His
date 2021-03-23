
using NewLife.Cube;

using Tech.Cluee.HisData.Model;

namespace Tech.Cluee.HisWeb.Areas.His.Controllers
{
    [HisArea]
    public class ZYYFQLDController : EntityController<ZYYFQLD>
    {
        static ZYYFQLDController()
        {
            MenuOrder = 200;
        }
    }
}
