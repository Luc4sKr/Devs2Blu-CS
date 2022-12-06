using Devs2Blu.ProjetosAula.DesafioAula.Models.API;
using System.Numerics;

namespace Devs2Blu.ProjetosAula.DesafioAula.Services
{
    public class ServiceApi
    {
        private readonly HttpClient _httpClient;
        private Random Random;

        #region CONSTS
        private const string URL_API_CHARACTER = "https://rickandmortyapi.com/api/character";
        private const string URL_API_LOCATIONS = "https://rickandmortyapi.com/api/location";
        private const string URL_API_EPISODES = "https://rickandmortyapi.com/api/episode";
        #endregion

        public ServiceApi()
        {
            _httpClient = new HttpClient();
            Random = new Random();
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

        public async Task<CharacterResults> GetCharactersByPage(int page)
        {
            string url = $"{URL_API_CHARACTER}?page={page}";
            return await Get<CharacterResults>(url);
        }

        public async Task<List<Character>> GetRandomCharacters()
        {
            List<int> randNumList = new List<int>();
            for (int i=0; i<8; i++)
            {
                int num = Random.Next(1, 800);
                randNumList.Add(num);
            }
            
            string randomNumsString = "";
            foreach (int num in randNumList)
            {
                randomNumsString += $",{num}";
            }

            string url = $"{URL_API_CHARACTER}/{randomNumsString}";
            return await GetList<Character>(url);
        }

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
