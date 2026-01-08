using CommunityToolkit.Maui.Core;
using CommunityToolkit.Maui.Views;
using System.Diagnostics;
using System.Drawing;
using System.Text.Json;
using WarframeWork.MVVM.Model;
using WarframeWork.MVVM.View;
using WarframeWork.MVVM.ViewModel;
using Color = Microsoft.Maui.Graphics.Color;
using WarframeWork.Helpers;

namespace WarframeWork.Pages;

public partial class UtilityPage : ContentPage
{
    HttpClient _client;
    JsonSerializerOptions _serializerOptions;

    public List<ItemBase> ?Items { get; private set; }

    public UtilityPage()
    {
        _client = new HttpClient();
        _serializerOptions = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            WriteIndented = true
        };

        InitializeComponent();
    }

    private async void DataRetrievalClick(object sender, EventArgs e)
    {
        Items = new List<ItemBase>();

        string searchtype = (string)(RadioButtonGroup.GetSelectedValue(searchlayout) ?? "items");

        Items = await ApiHelpers.SearchApi(searchtype, searchInput.Text, _client);

        retrievedCollection.ItemsSource = Items;
    }

    public void itemSelected(object sender, EventArgs e)
    {
        ItemBase item = (ItemBase)retrievedCollection.SelectedItem;

        var popup = new ItemView(item);
        
        this.ShowPopup(popup);

    }
}