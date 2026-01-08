using System.Diagnostics;
using System.Text.Json;
using WarframeWork.MVVM.Model;
using WarframeWork.MVVM.ViewModel;

namespace WarframeWork.MVVM.View;

public partial class PlayerView : ContentPage
{
    HttpClient _client;
    JsonSerializerOptions _serializerOptions;

    public PlayerView()
    {
        _client = new HttpClient();
        _serializerOptions = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            WriteIndented = true
        };
        InitializeComponent();
        BindingContext = new PlayerViewModel();

    }

    private async void DataRetrievalClick(object sender, EventArgs e)
    {
        Uri uri = new Uri(string.Format($"https://api.warframestat.us/profile/{searchInput.Text}", string.Empty));
        string content = "no items recovered";

        try
        {
            HttpResponseMessage response = await _client.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                content = await response.Content.ReadAsStringAsync();
                Player? player = JsonSerializer.Deserialize<Player>(content, _serializerOptions);
                this.BindingContext = new PlayerViewModel(player);
            }
        }
        catch (Exception ex)
        {
            Debug.WriteLine(@"/tERROR {0}", ex.Message);
        }
    }
}
