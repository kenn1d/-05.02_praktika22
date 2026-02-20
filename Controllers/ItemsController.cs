using Microsoft.AspNetCore.Mvc;
using praktika22.Data.Interfaces;
using System.Net.WebSockets;

namespace praktika22.Controllers
{
    public class ItemsController : Controller
    {
        private IItems IAllItems;
        private ICategorys IAllCategorys;

        public ItemsController(IItems iAllItems, ICategorys iAllCategorys)
        {
            IAllItems = iAllItems;
            IAllCategorys = iAllCategorys;
        }

        public ActionResult List()
        {
            ViewBag.Title = "Страница с предметами";
            var Items = IAllItems;
            return Json(Items);
        }
    }
}
