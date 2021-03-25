
using NewLife.Cube;

using Tech.Cluee.HisData.Model;

namespace Tech.Cluee.HisWeb.Areas.His.Controllers
{
    [HisArea]
    public class ZDSFController : EntityController<ZDSF>
    {
        static ZDSFController()
        {
            MenuOrder = 500;
        }
    }
}
