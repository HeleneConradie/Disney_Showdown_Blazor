using DisneyShowdown.BAL;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace DisneyShowdown.Controller
{
    public class APIController
    {
        public static async Task<ApiResponseList<Characters>> GetCharacters<T>()
        {
            string URL = $"https://api.disneyapi.dev/character";

            using (HttpClient client = new HttpClient())
            {
                using (var response = await client.GetAsync(URL))
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var obj = JsonConvert.DeserializeObject < ApiResponseList<Characters>>(content);
                    return obj;
                }
            }
        }

        public static async Task<ApiResponse<Characters>> GetCharacter<T>(string endpoint)
        {
            string URL = $"https://api.disneyapi.dev/character/{endpoint}";

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


    public class ApiResponseList<T>
    {
        public List<T> data { get; set; }
    }

    public class ApiResponse<T>
    {
        public T data { get; set; }
    }
}
