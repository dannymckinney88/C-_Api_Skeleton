using System;
using System.Net.Http;
using System.Threading.Tasks;

public class ApiService : IDisposable
{
      private readonly HttpClient _httpClient;
    public ApiService()
    {
         _httpClient = new HttpClient();
    }

    public async Task<string?> GetAsync(string url)
    {
        try
        {
            HttpResponseMessage response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
        catch(HttpRequestException e)
        {
            Console.WriteLine($"Request erorr : {e.Message}");
            return null;
        }
    }

    public void Dispose()
    {
        _httpClient.Dispose();
    }
}
