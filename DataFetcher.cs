using System;
using System.Threading.Tasks;

namespace CsharpApi
{
    public class DataFetcher
    {
        private readonly ApiService _ApiService;

        public DataFetcher()
        {
            _ApiService = new ApiService();
        }

        public async Task FetchdataAsync(string url )
        {
            string? data = await _ApiService.GetAsync(url);

            if(!string.IsNullOrEmpty(data))
            {
                Console.WriteLine("Data fetched succesfully:");
                Console.WriteLine(data);
            }
            else
            {
                Console.WriteLine("Failed to fetch data");
            }
        }
    }
}