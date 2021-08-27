using System.Net.Http;
using TrackSeries.FanArtTV.Client.TV;

namespace TrackSeries.FanArtTV.Client
{
    public class FanArtTVClient : IFanArtTVClient
    {
        public FanArtTVClient(HttpClient client)
        {
            TV = new TVClient(client);
        }

        public ITVClient TV { get; }
    }
}
