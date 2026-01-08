using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarframeWork.MVVM.Model
{
    public class WeaponMelee : WeaponBase
    {
        public int blockingAngle { get; set; }
        public int comboDuration { get; set; }
        public float[] damagePerShot { get; set; }
        public float followThrough { get; set; }
        public int heavyAttackDamage { get; set; }
        public int heavySlamAttack { get; set; }
        public int heavySlamRadialDamage { get; set; }
        public int heavySlamRadius { get; set; }
        public float range { get; set; }
        public int slamAttack { get; set; }
        public int slamRadialDamage { get; set; }
        public int slamRadius { get; set; }
        public int slideAttack { get; set; }
        public string stancePolarity { get; set; }
        public float windUp { get; set; }
    }
}
