using WarframeWork.MVVM.Model;

namespace WarframeWork.MVVM.ViewModel
{
    internal class WarframeViewModel
    {
        WarframeBase WarframeBase { get; set; }
        public WarframeViewModel()
        {

        }

        public WarframeViewModel(WarframeBase warframe)
        {
            WarframeBase = warframe;
        }
    }
}
