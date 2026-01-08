using CommunityToolkit.Maui.Views;
using WarframeWork.MVVM.Model;
using WarframeWork.MVVM.ViewModel;

namespace WarframeWork.MVVM.View;

public partial class WarframeView : Popup
{
	public WarframeView()
	{
		InitializeComponent();
		BindingContext = new WarframeViewModel();
	}

	public WarframeView(WarframeBase warframe)
	{
		InitializeComponent();
		BindingContext = new WarframeViewModel(warframe);
	}
}