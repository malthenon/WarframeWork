using Microsoft.Maui.Handlers;
using WarframeWork.MVVM.Model;

namespace WarframeWork.MVVM.ViewModel
{
    public class ItemViewModel
    {
        public ItemBase ItemBase { get; set; }

        public ItemViewModel()
        {

        }
        public ItemViewModel(ItemBase item)
        {
            ItemBase = item;
        }
    }
}
