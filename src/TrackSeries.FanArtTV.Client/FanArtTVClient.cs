using System.Net.Http;
using TrackSeries.FanArtTV.Client.Movies;
using TrackSeries.FanArtTV.Client.Music;
using TrackSeries.FanArtTV.Client.TV;

namespace TrackSeries.FanArtTV.Client
{
    public class FanArtTVClient : IFanArtTVClient
    {
        public FanArtTVClient(HttpClient client)
        {
            TV = new TVClient(client);
            Movies = new MoviesClient(client);
            Music = new MusicClient(client);
        }

        public ITVClient TV { get; }

        public IMoviesClient Movies { get; }

        public IMusicClient Music { get; }
    }
}
