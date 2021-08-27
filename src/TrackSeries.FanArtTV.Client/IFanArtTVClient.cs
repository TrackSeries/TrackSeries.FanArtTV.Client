using TrackSeries.FanArtTV.Client.Movies;
using TrackSeries.FanArtTV.Client.TV;

namespace TrackSeries.FanArtTV.Client
{
    public interface IFanArtTVClient
    {
        ITVClient TV { get; }
        IMoviesClient Movies { get; }
    }
}