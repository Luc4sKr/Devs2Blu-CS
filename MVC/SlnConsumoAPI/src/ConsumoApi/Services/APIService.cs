using ConsumoApi.Models;

namespace ConsumoApi.Services
{
    public class APIService
    {
        private readonly HttpClient _httpClient;

        private const string URL_API_CHARACTERS = "https://rickandmortyapi.com/api/character";
        private const string URL_API_LOCATIONS = "https://rickandmortyapi.com/api/location";
        private const string URL_API_EPISODES = "https://rickandmortyapi.com/api/episode";

        private const string URL_API_CHARACTER_BY_ID = "https://rickandmortyapi.com/api/character/";

        public APIService()
        {
            _httpClient = new HttpClient(); 
        }

        public async Task<Characters> GetCharacter()
        {
            return await Get<Characters>(URL_API_CHARACTERS);
        }

        public async Task<Locations> GetLocations()
        {
            return await Get<Locations>(URL_API_LOCATIONS);
        }

        public async Task<Episodes> GetEpisodes()
        {
            return await Get<Episodes>(URL_API_EPISODES);
        }

        public async Task<T> Get<T>(string url)
        {
            var listHttp = await GetAsync(url);

            if (!listHttp.IsSuccessStatusCode)
                return (T)(object)url;

            return await listHttp.Content.ReadFromJsonAsync<T>();
        }

        public async Task<List<T>> GetList<T>(string url)
        {
            var listHttp = await GetAsync(url);

            if (!listHttp.IsSuccessStatusCode)
                return new List<T>();

            return await listHttp.Content.ReadFromJsonAsync<List<T>>();

        }

        public async Task<HttpResponseMessage> GetAsync(string url)
        {
            var getRequest = new HttpRequestMessage()
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(url)
            };

            return await _httpClient.SendAsync(getRequest);
        }
    }
}
