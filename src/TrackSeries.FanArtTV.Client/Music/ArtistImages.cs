using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TrackSeries.FanArtTV.Client.Music
{
    public class ArtistImages : ArtistInfo
    {
        [JsonPropertyName("artistbackground")]
        public List<MusicImage> ArtistBackground { get; set; }

        [JsonPropertyName("artistthumb")]
        public List<MusicImage> ArtistThumb { get; set; }

        [JsonPropertyName("musiclogo")]
        public List<MusicImage> MusicLogo { get; set; }

        [JsonPropertyName("hdmusiclogo")]
        public List<MusicImage> HDMusicLogo { get; set; }

        [JsonPropertyName("musicbanner")]
        public List<MusicImage> MusicBanner { get; set; }
    }
}
