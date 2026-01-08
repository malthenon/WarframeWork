using CommunityToolkit.Maui.Views;
using WarframeWork.MVVM.Model;
using WarframeWork.MVVM.ViewModel;

namespace WarframeWork.MVVM.View;

public partial class WeaponMeleeView : Popup
{
	public WeaponMeleeView()
	{
		InitializeComponent();
		BindingContext = new WeaponMeleeViewModel();
	}

	public WeaponMeleeView(WeaponMelee weapon)
	{
		InitializeComponent();
		BindingContext = new WeaponMeleeViewModel(weapon);
	}
}