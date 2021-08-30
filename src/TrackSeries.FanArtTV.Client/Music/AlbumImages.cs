using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TrackSeries.FanArtTV.Client.Music
{
    public class AlbumImages
    {
        [JsonPropertyName("albumcover")]
        public List<MusicImage> AlbumCover { get; set; }

        [JsonPropertyName("cdart")]
        public List<AlbumDiscImage> CdArt { get; set; }
    }
}
