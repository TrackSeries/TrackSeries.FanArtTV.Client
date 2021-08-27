using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading;
using System.Threading.Tasks;

namespace TrackSeries.FanArtTV.Client.Music
{
    public class MusicClient : IMusicClient
    {
        private readonly HttpClient _client;

        public MusicClient(HttpClient client)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));
        }

        public Task<ArtistInfo> GetAlbumAsync(Guid albumId, CancellationToken cancellationToken)
            => GetAlbumAsync(albumId.ToString(), cancellationToken);

        public Task<ArtistInfo> GetAlbumAsync(string albumId, CancellationToken cancellationToken)
            => _client.GetFromJsonAsync<ArtistInfo>($"music/albums/{albumId}", cancellationToken);

        public Task<ArtistImages> GetArtistAsync(string id, CancellationToken cancellationToken)
            => _client.GetFromJsonAsync<ArtistImages>($"music/{id}", cancellationToken);

        public Task<ArtistImages> GetArtistAsync(Guid id, CancellationToken cancellationToken)
            => GetArtistAsync(id.ToString(), cancellationToken);

        public Task<MusicLabelImages> GetLabelAsync(Guid labelId, CancellationToken cancellationToken)
            => GetLabelAsync(labelId.ToString(), cancellationToken);

        public Task<MusicLabelImages> GetLabelAsync(string labelId, CancellationToken cancellationToken)
            => _client.GetFromJsonAsync<MusicLabelImages>($"music/labels/{labelId}", cancellationToken);

        public Task<List<MusicImagesInfo>> GetLatestArtistsAsync(DateTime since, CancellationToken cancellationToken)
            => GetLatestArtistsAsync(new DateTimeOffset(since).ToUnixTimeSeconds(), cancellationToken);

        public Task<List<MusicImagesInfo>> GetLatestArtistsAsync(long since, CancellationToken cancellationToken)
            => _client.GetFromJsonAsync<List<MusicImagesInfo>>($"music/latest?date={since}");
    }
}
