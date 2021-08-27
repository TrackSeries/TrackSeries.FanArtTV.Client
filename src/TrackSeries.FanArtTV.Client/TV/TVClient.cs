using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading;
using System.Threading.Tasks;

namespace TrackSeries.FanArtTV.Client.TV
{
    internal class TVClient : ITVClient
    {
        private readonly HttpClient _client;

        public TVClient(HttpClient client)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));
        }

        public Task<List<ShowImagesInfo>> GetLatestShows(DateTime since, CancellationToken cancellationToken)
            => GetLatestShows(new DateTimeOffset(since).ToUnixTimeSeconds(), cancellationToken);

        public Task<List<ShowImagesInfo>> GetLatestShows(long since, CancellationToken cancellationToken) 
            => _client.GetFromJsonAsync<List<ShowImagesInfo>>($"tv/latest?date={since}", cancellationToken);

        public Task<ShowImages> GetShow(int showId, CancellationToken cancellationToken) => GetShow(showId.ToString(), cancellationToken);

        public Task<ShowImages> GetShow(string showId, CancellationToken cancellationToken) 
            => _client.GetFromJsonAsync<ShowImages>($"tv/{showId}", cancellationToken);
    }
}
