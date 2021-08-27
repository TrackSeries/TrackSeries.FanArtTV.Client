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
        [JsonPropertyName("characterart")]
        public List<ImageInfo> CharacterArt { get; set; }
        [JsonPropertyName("clearlogo")]
        public List<ImageInfo> ClearLogo { get; set; }
        [JsonPropertyName("seasonthumb")]
        public List<SeasonImageInfo> SeasonThumb { get; set; }
        [JsonPropertyName("hdclearart")]
        public List<ImageInfo> HDClearArt { get; set; }
        [JsonPropertyName("showbackground")]
        public List<SeasonImageInfo> ShowBackground { get; set; }
        [JsonPropertyName("tvthumb")]
        public List<ImageInfo> TVThumb { get; set; }
        [JsonPropertyName("clearart")]
        public List<ImageInfo> ClearArt { get; set; }
        [JsonPropertyName("tvbanner")]
        public List<ImageInfo> TVBanner { get; set; }
        [JsonPropertyName("seasonbanner")]
        public List<SeasonImageInfo> SeasonBanner { get; set; }
    }
}
