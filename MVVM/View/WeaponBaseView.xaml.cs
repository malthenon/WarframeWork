using CommunityToolkit.Maui.Views;
using WarframeWork.MVVM.Model;

namespace WarframeWork.MVVM.View;

public partial class WeaponBaseView : Popup
{
	public WeaponBaseView()
	{
		InitializeComponent();
		BindingContext = new WeaponBaseView();
	}

	public WeaponBaseView(WeaponBase weapon)
	{
		InitializeComponent();
		BindingContext = new WeaponBaseView(weapon);
	}
}