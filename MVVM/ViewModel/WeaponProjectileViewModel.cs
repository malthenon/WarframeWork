using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarframeWork.MVVM.Model;

namespace WarframeWork.MVVM.ViewModel
{
    internal class WeaponProjectileViewModel
    {
        WeaponProjectile WeaponProjectile { get; set; }

        public WeaponProjectileViewModel()
        {

        }

        public WeaponProjectileViewModel(WeaponProjectile weapon)
        {
            WeaponProjectile = weapon;
        }
    }
}
