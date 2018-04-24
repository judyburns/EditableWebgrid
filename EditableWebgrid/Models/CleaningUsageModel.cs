using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EditableWebgrid.Models
{
    public class CleaningUsageModel
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public float Qty { get; set; }
        public int UserQty { get; set; }
        public string User { get; set; }
        public DateTime Update { get; set; }

        public static List<CleaningUsageModel> GetItems()
        {
            List<CleaningUsageModel> items = new List<CleaningUsageModel>()
            {
                new CleaningUsageModel (){ ID=1, Description="Clorox Bleach", Qty=10, User="JB", Update=DateTime.Now },
                new CleaningUsageModel (){ ID=2, Description="409 All Purpose Cleaner", Qty=5, User="JB", Update=DateTime.Now },
                new CleaningUsageModel (){ ID=3, Description="Clorox Gel", Qty=20, User="JB", Update=DateTime.Now },
                new CleaningUsageModel (){ ID=4, Description="Bounty Paper Towels", Qty=25, User="JB", Update=DateTime.Now },
                new CleaningUsageModel (){ ID=5, Description="Comet Cleanser", Qty=6, User="JB", Update=DateTime.Now },
            };
            return items;
        }
    }
}