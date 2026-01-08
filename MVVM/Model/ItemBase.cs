using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarframeWork.MVVM.Model
{
    public class ItemBase
    {
        public string name { get; set; }
        public string uniqueName { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public bool tradable { get; set; }
        public string category { get; set; }
        public string productCategory { get; set; }
        public object[] patchlogs { get; set; }
        public ItemBase[] components { get; set; }
        public object introduced { get; set; }
        public string estimatedVaultDate { get; set; }
    }
}
