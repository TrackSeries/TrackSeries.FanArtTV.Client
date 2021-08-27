using System.Text.Json.Serialization;

namespace TrackSeries.FanArtTV.Client.Movies
{
    public class MovieDiscImageInfo : ImageInfo
    {
        [JsonPropertyName("disc")]
        public string Disc { get; set; }

        [JsonPropertyName("disc_type")]
        public string DiscType { get; set; }
    }
}
