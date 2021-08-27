using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace TrackSeries.FanArtTV.Client.Music
{
    public interface IMusicClient
    {
        Task<ArtistImages> GetArtistAsync(string id, CancellationToken cancellationToken = default);
        Task<ArtistImages> GetArtistAsync(Guid id, CancellationToken cancellationToken = default);
        Task<ArtistInfo> GetAlbumAsync(Guid albumId, CancellationToken cancellationToken = default);
        Task<ArtistInfo> GetAlbumAsync(string albumId, CancellationToken cancellationToken = default);
        Task<MusicLabelImages> GetLabelAsync(Guid labelId, CancellationToken cancellationToken = default);
        Task<MusicLabelImages> GetLabelAsync(string labelId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Returns the list of artists that has been updated since the time specified.
        /// </summary>
        /// <param name="since"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<List<MusicImagesInfo>> GetLatestArtistsAsync(DateTime since, CancellationToken cancellationToken = default);
        /// <summary>
        /// Returns the list of artists that has been updated since the time specified as unix timestamp.
        /// </summary>
        /// <param name="since">The unix timestamp</param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<List<MusicImagesInfo>> GetLatestArtistsAsync(long since, CancellationToken cancellationToken = default);
    }
}
