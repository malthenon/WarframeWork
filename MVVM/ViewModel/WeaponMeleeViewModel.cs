using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarframeWork.MVVM.Model;

namespace WarframeWork.MVVM.ViewModel
{
    internal class WeaponMeleeViewModel
    {
        WeaponMelee WeaponMelee { get; set; }
        public WeaponMeleeViewModel() 
        {

        }

        public WeaponMeleeViewModel(WeaponMelee weapon)
        {
            WeaponMelee = weapon;
        }
    }
}
