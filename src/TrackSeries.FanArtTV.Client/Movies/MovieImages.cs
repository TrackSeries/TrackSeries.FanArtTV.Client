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
        public List<Image> HDMovieLogo { get; set; }

        [JsonPropertyName("moviedisc")]
        public List<MovieDiscImageInfo> MovieDisc { get; set; }

        [JsonPropertyName("movielogo")]
        public List<Image> MovieLogo { get; set; }

        [JsonPropertyName("movieposter")]
        public List<Image> MoviePoster { get; set; }

        [JsonPropertyName("hdmovieclearart")]
        public List<Image> HDMovieClearArt { get; set; }

        [JsonPropertyName("movieart")]
        public List<Image> MovieArt { get; set; }

        [JsonPropertyName("moviebackground")]
        public List<Image> MovieBackground { get; set; }

        [JsonPropertyName("moviebanner")]
        public List<Image> MovieBanner { get; set; }

        [JsonPropertyName("moviethumb")]
        public List<Image> MovieThumb { get; set; }
    }
}
