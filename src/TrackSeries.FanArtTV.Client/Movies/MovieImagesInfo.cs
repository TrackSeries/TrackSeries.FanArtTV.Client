using System.Text.Json.Serialization;

namespace TrackSeries.FanArtTV.Client.Movies
{
    public class MovieImagesInfo
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("tmdb_id")]
        public string TMDBId { get; set; }

        [JsonPropertyName("imdb_id")]
        public string IMDBId { get; set; }

        [JsonPropertyName("new_images")]
        public int? NewImages { get; set; }

        [JsonPropertyName("total_images")]
        public int? TotalImages { get; set; }
    }
}
