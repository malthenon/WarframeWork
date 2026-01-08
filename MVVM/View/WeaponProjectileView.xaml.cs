using CommunityToolkit.Maui.Views;
using WarframeWork.MVVM.Model;
using WarframeWork.MVVM.ViewModel;

namespace WarframeWork.MVVM.View;

public partial class WeaponProjectileView : Popup
{
    public WeaponProjectileView()
    {
        InitializeComponent();
        BindingContext = new WeaponProjectileViewModel();
    }

    public WeaponProjectileView(WeaponProjectile weapon)
    {
        InitializeComponent();
        BindingContext = new WeaponProjectileViewModel(weapon);
    }
}