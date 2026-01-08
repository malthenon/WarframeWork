using CommunityToolkit.Maui.Views;
using WarframeWork.MVVM.Model;
using WarframeWork.MVVM.ViewModel;

namespace WarframeWork.MVVM.View;

public partial class ItemView : Popup
{
	public ItemView()
	{
		InitializeComponent();
		BindingContext = new ItemViewModel();
	}

	public ItemView(ItemBase item)
	{
		InitializeComponent();
		BindingContext = new ItemViewModel(item);

		retrievedCollection.ItemsSource = item.components;
	}

	public void itemSelected(object sender, EventArgs e) 
	{
        ItemBase item = (ItemBase)retrievedCollection.SelectedItem;

        var popup = new ItemView(item);

        PopupExtensions.ShowPopup((Page)Parent, popup);
    }

    private void closeClicked(object sender, EventArgs e)
    {
        Close();
    }
}