using Newtonsoft.Json;

namespace MarvelComicsMMT.Models
{
    public class Comic
    {
        [JsonProperty("id")]
        public int IdComic { get; set; }

        [JsonProperty("title")]
        public string Titulo { get; set; }

        [JsonProperty("detailUrl")]
        public string Url { get; set; }

        [JsonProperty("seriesName")]
        public string Serie { get; set; }

        [JsonProperty("yearPage")]
        public int Year { get; set; }
    }
}
