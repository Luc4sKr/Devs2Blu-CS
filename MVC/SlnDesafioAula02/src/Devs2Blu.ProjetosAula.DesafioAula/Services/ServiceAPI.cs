namespace Devs2Blu.ProjetosAula.DesafioAula.Services
{
    public class ServiceAPI
    {
        private readonly HttpClient _httpClient;

        #region CONSTS
        private const string URL_API_AGENTS_BR = "https://valorant-api.com/v1/agents?language=pt-BR";
        #endregion



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
