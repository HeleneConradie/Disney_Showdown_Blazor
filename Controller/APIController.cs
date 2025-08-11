using DisneyShowdown.BAL;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace DisneyShowdown.Controller
{
    public class APIController
    {
        public static async Task<ApiResponse<Characters>> GetCharacters<T>(string endpoint)
        {
            string URL = $"https://api.disneyapi.dev/{endpoint}";

            using (HttpClient client = new HttpClient())
            {
                using (var response = await client.GetAsync(URL))
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var obj = JsonConvert.DeserializeObject<ApiResponse<Characters>>(content);
                    return obj;
                }
            }
        }
    }


    public class ApiResponse<T>
    {
        public List<T> data { get; set; }
    }
}
