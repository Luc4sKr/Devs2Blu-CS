using Devs2Blu.ProjetosAula.DesafioAula.Models.API;

namespace Devs2Blu.ProjetosAula.DesafioAula.Services
{
    public class ServiceApi
    {
        private readonly HttpClient _httpClient;

        #region CONSTS
        private const string URL_API_CHARACTER = "https://rickandmortyapi.com/api/character";
        private const string URL_API_LOCATIONS = "https://rickandmortyapi.com/api/location";
        private const string URL_API_EPISODES = "https://rickandmortyapi.com/api/episode";
        #endregion

        public ServiceApi()
        {
            _httpClient = new HttpClient();
        }

        public async Task<CharacterResults> GetCharacters()
        {
            return await Get<CharacterResults>($"{URL_API_CHARACTER}?page=1");
        }

        public async Task<CharacterResults> GetCharacterByName(string name)
        {
            string urlSearch = $"{URL_API_CHARACTER}?name={name}";
            var objJSONResponse = await Get<CharacterResults>(urlSearch);
            return objJSONResponse;
        }


        // Em desenvolvimento ----------------------------------------
        public async Task<List<Character>> GetRandomCharacters()
        {
            string url = $"{URL_API_CHARACTER}/1,2,3";
            return await Get<List<Character>>(url);
        }
        // -----------------------------------------------------------

        public async Task<LocationResults> GetLocations()
        {
            return await Get<LocationResults>($"{URL_API_LOCATIONS}?page=1");
        }

        #region BaseMethods
        public async Task<T> Get<T>(string url)
        {
            var objHttp = await GetAsync(url);

            if (!objHttp.IsSuccessStatusCode)
                return (T)(object)url;

            return await objHttp.Content.ReadFromJsonAsync<T>();

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
        #endregion
    }
}
