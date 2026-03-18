using Newtonsoft.Json;

namespace MarvelComicsMMT.Models
{
    public class ComicsList
    {
        [JsonProperty("items")]
        public List<Comic> Comics { get; set; }
    }
}
