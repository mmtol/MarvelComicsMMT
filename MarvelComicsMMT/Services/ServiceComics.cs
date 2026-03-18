using MarvelComicsMMT.Models;
using Newtonsoft.Json;
using System.Net;

namespace MarvelComicsMMT.Services
{
    public class ServiceComics
    {
        public async Task<ComicsList> GetComicsAsync(string query)
        {
            WebClient client = new WebClient();
            client.Headers["content-type"] = "application/json";
            string url = "https://marvel.emreparker.com/v1/search/issues?q=" + query + "&limit=10";
            string data = await client.DownloadStringTaskAsync(url);
            ComicsList comics = JsonConvert.DeserializeObject<ComicsList>(data);
            return comics;
        }
    }
}
