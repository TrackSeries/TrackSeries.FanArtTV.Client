using System.Threading;
using System.Threading.Tasks;

namespace TrackSeries.FanArtTV.Client.TV
{
    public interface ITVClient
    {
        Task<ShowImages> GetShow(int showId, CancellationToken cancellationToken);
        Task<ShowImages> GetShow(string showId, CancellationToken cancellationToken);
    }
}
