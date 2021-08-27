using TrackSeries.FanArtTV.Client.TV;

namespace TrackSeries.FanArtTV.Client
{
    public interface IFanArtTVClient
    {
        ITVClient TV { get; }
    }
}