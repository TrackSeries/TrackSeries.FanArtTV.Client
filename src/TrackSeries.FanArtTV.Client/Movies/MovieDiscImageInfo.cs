using System.Text.Json.Serialization;

namespace TrackSeries.FanArtTV.Client.Movies
{
    public class MovieDiscImageInfo : Image
    {
        [JsonPropertyName("disc")]
        public string Disc { get; set; }

        [JsonPropertyName("disc_type")]
        public string DiscType { get; set; }
    }
}
