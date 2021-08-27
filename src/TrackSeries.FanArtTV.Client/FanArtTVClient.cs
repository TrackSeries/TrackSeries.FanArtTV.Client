using System.Net.Http;
using TrackSeries.FanArtTV.Client.Movies;
using TrackSeries.FanArtTV.Client.TV;

namespace TrackSeries.FanArtTV.Client
{
    public class FanArtTVClient : IFanArtTVClient
    {
        public FanArtTVClient(HttpClient client)
        {
            TV = new TVClient(client);
            Movies = new MoviesClient(client);
        }

        public ITVClient TV { get; }

        public IMoviesClient Movies { get; }
    }
}
