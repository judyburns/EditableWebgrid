using EditableWebgrid.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace EditableWebgrid.Controllers
{
    public class CleaningInventoryController : Controller
    {
        public ActionResult Index()
        {
            List<CleaningInventoryModel> items = CleaningInventoryModel.GetItems();

            return View(items);

            //CleaningSupplies.Web.Controllers.CleaningInventoryController
            //Using CleaningSupplies.Database.Models;
            //Returns IQueryable to view
            //
            //DataAccess db = new DataAccess();
            //var result = db.GetAllInventory();
            //return view(result);

            // CleaningSupplies.Business.Models.DataAccess
            //public class DataAccess()
            //  {
            //      public IQueryable GetAllInventory(){
            //          var context = new DataAccess();
            //          var result = context.CleaningInventoryModel.OrderByDescending(x => x.ID);
            //          return(result);
            //      }
            //  }
            //*********************************************************************
            //  List<CleaningInventoryModel> inventory = db.CleaningInventoryModel
            //   .OrderByDescending(x => x.ID)
            //   .ToList<CleaningInventoryModel>();
            //  return View(inventory);
            //}

        }

        public JsonResult CreateItem(CleaningInventoryModel model)
        {
            // Update model to your db
            //  foreach (var item in model) {
            //      model.ID = item.ID;
            //      model.Description = item.Description;
            //      model.Qty = item.Qty;
            //  }

            string message = "Success - Create Inventory";
            return Json(message, JsonRequestBehavior.AllowGet);

            // CleaningSupplies.Web.Controllers.CleaningInventoryController
            //Using CleaningSupplies.Database.Models;
            //Returns IQueryable to view
            //
            //DataAccess db = new DataAccess();
            //var result = db.GetAllInventory();
            //return view(result);

            // CleaningSupplies.Business.Models.DataAccess
            //public class DataAccess()
            //  {
            //      public IQueryable GetAllInventory(){
            //          var context = new DataAccess();
            //          var result = context.CleaningInventoryModel.OrderByDescending(x => x.ID);
            //          return(result);
            //      }
            //  }
            //*********************************************************************
            //  List<CleaningInventoryModel> inventory = db.CleaningInventoryModel
            //   .OrderByDescending(x => x.ID)
            //   .ToList<CleaningInventoryModel>();
            //  return View(inventory);
            //}
        }

        public JsonResult SaveItem(CleaningInventoryModel model)
        {
            // Update model to your db
            //  foreach (var item in model) {
            //      model.ID = item.ID;
            //      model.Description = item.Description;
            //      model.Qty = item.Qty;
            //  }

            string message = "Success - Save Inventory";
            return Json(message, JsonRequestBehavior.AllowGet);

            // CleaningSupplies.Web.Controllers.CleaningInventoryController
            //Using CleaningSupplies.Database.Models;
            //Returns IQueryable to view
            //
            //DataAccess db = new DataAccess();
            //var result = db.GetAllInventory();
            //return view(result);

            // CleaningSupplies.Business.Models.DataAccess
            //public class DataAccess()
            //  {
            //      public IQueryable GetAllInventory(){
            //          var context = new DataAccess();
            //          var result = context.CleaningInventoryModel.OrderByDescending(x => x.ID);
            //          return(result);
            //      }
            //  }
            //*********************************************************************
            //  List<CleaningInventoryModel> inventory = db.CleaningInventoryModel
            //   .OrderByDescending(x => x.ID)
            //   .ToList<CleaningInventoryModel>();
            //  return View(inventory);
            //}
        }

    }
}
