using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TrackSeries.FanArtTV.Client.Music
{
    public class MusicLabelImages
    {
        public string Name { get; set; }
        public string Id { get; set; }

        [JsonPropertyName("musiclabel")]
        public List<MusicLabelImage> MusicLabel { get; set; }
    }
}
