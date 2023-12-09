using System.Net.Http.Json;
namespace ExamenC_.clients
{
    public class HttpJsonClient<T> where T : class, new()
    {
        public static async Task<T> RequestCountryDataAsync(string baseAPI, string URI)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                T? myJsonResponse = await httpClient.GetFromJsonAsync<T>($"{baseAPI}{URI}");
                return myJsonResponse ?? new T();
            }
        }
    }
}
