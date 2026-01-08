using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Text.Json;
using WarframeWork.MVVM.Model;

namespace WarframeWork.Helpers
{
    public class ApiHelpers
    {
        public static async Task<List<ItemBase>?> SearchApi(string searchtype, string searchtext, HttpClient client)
        {
            Uri uri = new Uri(string.Format($"https://api.warframestat.us/{searchtype}/search/{searchtext}", string.Empty));
            string content = "no items recovered";
            JsonSerializerOptions _serializerOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };

            try
            {
                HttpResponseMessage response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    content = await response.Content.ReadAsStringAsync();
                    return JsonSerializer.Deserialize<List<ItemBase>>(content, _serializerOptions);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"/tERROR {0}", ex.Message);
            }

            return null;
        }
    }
}
