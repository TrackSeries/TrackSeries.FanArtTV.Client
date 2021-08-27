using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TrackSeries.FanArtTV.Client.Movies
{
    public class MovieImages
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("tmdb_id")]
        public string TMDBId { get; set; }

        [JsonPropertyName("imdb_id")]
        public string IMDBId { get; set; }

        [JsonPropertyName("hdmovielogo")]
        public List<ImageInfo> HDMovieLogo { get; set; }

        [JsonPropertyName("moviedisc")]
        public List<MovieDiscImage> MovieDisc { get; set; }

        [JsonPropertyName("movielogo")]
        public List<ImageInfo> MovieLogo { get; set; }

        [JsonPropertyName("movieposter")]
        public List<ImageInfo> MoviePoster { get; set; }

        [JsonPropertyName("hdmovieclearart")]
        public List<ImageInfo> HDMovieClearArt { get; set; }

        [JsonPropertyName("movieart")]
        public List<ImageInfo> MovieArt { get; set; }

        [JsonPropertyName("moviebackground")]
        public List<ImageInfo> MovieBackground { get; set; }

        [JsonPropertyName("moviebanner")]
        public List<ImageInfo> MovieBanner { get; set; }

        [JsonPropertyName("moviethumb")]
        public List<ImageInfo> MovieThumb { get; set; }
    }
}
