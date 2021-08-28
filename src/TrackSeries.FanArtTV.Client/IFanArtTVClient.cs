using TrackSeries.FanArtTV.Client.Movies;
using TrackSeries.FanArtTV.Client.Music;
using TrackSeries.FanArtTV.Client.TV;

namespace TrackSeries.FanArtTV.Client
{
    public interface IFanArtTVClient
    {
        /// <summary>
        /// TV related resources
        /// </summary>
        ITVClient TV { get; }
        /// <summary>
        /// Movie related resources
        /// </summary>
        IMoviesClient Movies { get; }
        /// <summary>
        /// Music related resources
        /// </summary>
        IMusicClient Music { get; }
    }
}