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
        public List<SeasonImage> SeasonPoster { get; set; }
        [JsonPropertyName("hdtvlogo")]
        public List<Image> HDTVLogo { get; set; }
        [JsonPropertyName("tvposter")]
        public List<Image> TVPoster { get; set; }
        [JsonPropertyName("characterart")]
        public List<Image> CharacterArt { get; set; }
        [JsonPropertyName("clearlogo")]
        public List<Image> ClearLogo { get; set; }
        [JsonPropertyName("seasonthumb")]
        public List<SeasonImage> SeasonThumb { get; set; }
        [JsonPropertyName("hdclearart")]
        public List<Image> HDClearArt { get; set; }
        [JsonPropertyName("showbackground")]
        public List<SeasonImage> ShowBackground { get; set; }
        [JsonPropertyName("tvthumb")]
        public List<Image> TVThumb { get; set; }
        [JsonPropertyName("clearart")]
        public List<Image> ClearArt { get; set; }
        [JsonPropertyName("tvbanner")]
        public List<Image> TVBanner { get; set; }
        [JsonPropertyName("seasonbanner")]
        public List<SeasonImage> SeasonBanner { get; set; }
    }
}
