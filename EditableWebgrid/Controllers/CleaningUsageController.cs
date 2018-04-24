using EditableWebgrid.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EditableWebgrid.Controllers
{
    public class CleaningUsageController : Controller
    {
        //
        // GET: /CleaningUsage/

        public ActionResult Index()
        {
            List<CleaningUsageModel> items = CleaningUsageModel.GetItems();

            return View(items);

        }

        public JsonResult IncreaseQty(CleaningUsageModel model)
        {
            // Update model to your db
            //  foreach (var item in model) {
            //      model.ID = item.ID;
            //      model.Description = item.Description;
            //      model.Qty = item.Qty;
            //      model.UserQty = item.UserQty;
            //  }

            string message = "Success - Increase Quantity - Save Usage";
            return Json(message, JsonRequestBehavior.AllowGet);
        }

        public JsonResult DecreaseQty(CleaningUsageModel model)
        {
            // Update model to your db
            //  foreach (var item in model) {
            //      model.ID = item.ID;
            //      model.Description = item.Description;
            //      model.Qty = item.Qty;
            //      model.UserQty = item.UserQty * -1;
            //  }

            string message = "Success - Decrease Quantity - Usage";
            return Json(message, JsonRequestBehavior.AllowGet);
        }

    }
}
