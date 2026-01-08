using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarframeWork.MVVM.Model;

namespace WarframeWork.MVVM.ViewModel
{
    internal class WeaponBaseViewModel
    {
        WeaponBase WeaponBase { get; set; }
        public WeaponBaseViewModel() 
        {

        }

        public WeaponBaseViewModel(WeaponBase weapon)
        {
            WeaponBase = weapon;
        }
    }
}
