using DisneyShowdown.Controller;

namespace DisneyShowdown.BAL
{
    public class Characters
    {
        public int _id { get; set; }
        public List<string> films { get; set; }
        public List<string> shortFilms { get; set; }
        public List<string> tvShows { get; set; }
        public List<string> videoGames { get; set; }
        public List<string> parkAttractions { get; set; }
        public List<string> allies { get; set; }
        public List<string> enemies { get; set; }
        public string name { get; set; }
        public string imageUrl { get; set; }
        public string url { get; set; }

        public static async Task<ApiResponseList<Characters>> GetAllCharacters()
        {
            return await APIController.GetCharacters<Characters>();
        }
        public static async Task<ApiResponse<Characters>> GetCharacter(int ID)
        {
            return await APIController.GetCharacter<Characters>(ID.ToString());
        }
    }
}
