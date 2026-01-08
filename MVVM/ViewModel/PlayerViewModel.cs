using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarframeWork.MVVM.Model;

namespace WarframeWork.MVVM.ViewModel
{
    public class PlayerViewModel
    {
        public Player player {  get; set; }

        public PlayerViewModel()
        {

            player = new Player()
            {
            };
        }

        public PlayerViewModel(Player player)
        {
            this.player = player;
        }
    }
}
