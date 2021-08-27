using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TrackSeries.FanArtTV.Client.Movies
{
    public class MoviesClient : IMoviesClient
    {
        private readonly HttpClient _client;

        public MoviesClient(HttpClient client)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));
        }

        public Task<List<MovieImagesInfo>> GetLatestMoviesAsync(DateTime since, CancellationToken cancellationToken)
            => GetLatestMoviesAsync(new DateTimeOffset(since).ToUnixTimeSeconds(), cancellationToken);

        public Task<List<MovieImagesInfo>> GetLatestMoviesAsync(long since, CancellationToken cancellationToken)
            => _client.GetFromJsonAsync<List<MovieImagesInfo>>($"movies/latest?date={since}", cancellationToken);

        public Task<MovieImages> GetMovieAsync(string id, CancellationToken cancellationToken)
            => _client.GetFromJsonAsync<MovieImages>($"movies/{id}", cancellationToken);
    }
}
