using ConsumoApiProject.Models;

namespace ConsumoApiProject.Services
{
    public class ApiService
    {
        private readonly HttpClient _httpClient;
        private const string URL_API = "https://rickandmortyapi.com/api/character";

        public ApiService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<Character> GetCharacter()
        {
            return await Get<Character>(URL_API);
        }

        public async Task<HttpResponseMessage> GetAsync(string url)
        {
            HttpRequestMessage getRequest = new HttpRequestMessage()
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(url)
            };

            return await _httpClient.SendAsync(getRequest);
        }

        public async Task<T> Get<T>(string url)
        {
            var listHttp = await GetAsync(url);

            if (!listHttp.IsSuccessStatusCode)
                return (T)(object)url;

            return await listHttp.Content.ReadFromJsonAsync<T>();
        }
    }
}
