using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace TrackSeries.FanArtTV.Client.Music
{
    public interface IMusicClient
    {
        /// <summary>
        /// Get images for an Artist
        /// </summary>
        /// <param name="id">The MBID (MusicBrainz)</param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<ArtistImages> GetArtistAsync(string id, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get images for an Artist
        /// </summary>
        /// <param name="id">The MBID (MusicBrainz)</param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<ArtistImages> GetArtistAsync(Guid id, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get images for an Album
        /// </summary>
        /// <param name="albumId">The AlbumId from MB (MusicBrainz)</param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<ArtistInfo> GetAlbumAsync(Guid albumId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get images for an Album
        /// </summary>
        /// <param name="albumId">The AlbumId from MB (MusicBrainz)</param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<ArtistInfo> GetAlbumAsync(string albumId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get images for a Label
        /// </summary>
        /// <param name="labelId">The LabelId from MB (MusicBrainz)</param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<MusicLabelImages> GetLabelAsync(Guid labelId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get images for a Label
        /// </summary>
        /// <param name="labelId">The LabelId from MB (MusicBrainz)</param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
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
