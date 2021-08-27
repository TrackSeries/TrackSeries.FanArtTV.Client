using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TrackSeries.FanArtTV.Client.TV
{
    public class ShowImages
    {
        public string Name { get; set; }
        [JsonPropertyName("thetvdb_id")]
        public string TheTVDBId { get; set; }
        [JsonPropertyName("seasonposter")]
        public List<SeasonImageInfo> SeasonPoster { get; set; }
        [JsonPropertyName("hdtvlogo")]
        public List<ImageInfo> HDTVLogo { get; set; }
        [JsonPropertyName("tvposter")]
        public List<ImageInfo> TVPoster { get; set; }

    }
}
