using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarframeWork.MVVM.Model
{
    public class ModBase : ItemBase
    {
        public int baseDrain { get; set; }
        public string compatName { get; set; }
        public int fusionLimit { get; set; }
        public object[] levelStats { get; set; }
        public string polarity { get; set; }
        public bool transmutable { get; set; }
    }
}
