using CommunityToolkit.Maui.Views;
using WarframeWork.MVVM.Model;
using WarframeWork.MVVM.ViewModel;

namespace WarframeWork.MVVM.View;

public partial class ModView : Popup
{
	public ModView()
	{
		InitializeComponent();
		BindingContext = new ModViewModel();
	}

	public ModView(ModBase modBase)
	{
		InitializeComponent();
		BindingContext = new ModViewModel(modBase);
	}
}