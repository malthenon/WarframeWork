using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarframeWork.MVVM.Model
{
    public class WeaponProjectile : WeaponBase
    {
        public double accuracy { get; set; }
        public double ammo { get; set; }
        public int magazineSize { get; set; }
        public float multishot { get; set; }
        public string noise { get; set; }
        public string trigger { get; set; }
    }
}
