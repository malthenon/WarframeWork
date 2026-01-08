using WarframeWork.MVVM.Model;

namespace WarframeWork.MVVM.ViewModel
{

    public class ModViewModel
    {
        public ModBase modbase { get; set; }
        public ModViewModel()
        {

        }

        public ModViewModel(ModBase mod)
        {
            modbase = mod;
        }
    }
}
