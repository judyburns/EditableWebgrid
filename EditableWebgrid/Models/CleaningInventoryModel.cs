using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EditableWebgrid.Models
{
    public class CleaningInventoryModel
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public float Qty { get; set; }
        public string User { get; set; }
        public DateTime Update { get; set; }

        public static List<CleaningInventoryModel> GetItems()
        {
            List<CleaningInventoryModel> items = new List<CleaningInventoryModel>()
{
                new CleaningInventoryModel (){ ID=1, Description="Clorox Bleach", Qty=10, User="JB", Update=DateTime.Now }, 
                new CleaningInventoryModel (){ ID=2, Description="409 All Purpose Cleaner", Qty=5, User="JB", Update=DateTime.Now },
                new CleaningInventoryModel (){ ID=3, Description="Clorox Gel", Qty=20, User="JB", Update=DateTime.Now },
                new CleaningInventoryModel (){ ID=4, Description="Bounty Paper Towels", Qty=25, User="JB", Update=DateTime.Now },
                new CleaningInventoryModel (){ ID=5, Description="Comet Cleanser", Qty=6, User="JB", Update=DateTime.Now },
            };
            return items;
        }
    }
}