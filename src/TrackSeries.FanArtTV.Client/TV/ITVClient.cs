using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace TrackSeries.FanArtTV.Client.TV
{
    public interface ITVClient
    {
        Task<ShowImages> GetShowAsync(int showId, CancellationToken cancellationToken = default);
        Task<ShowImages> GetShowAsync(string showId, CancellationToken cancellationToken);
        /// <summary>
        /// Returns the list of shows that has been updated since the time specified.
        /// </summary>
        /// <param name="since"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<List<ShowImagesInfo>> GetLatestShowsAsync(DateTime since, CancellationToken cancellationToken = default);
        /// <summary>
        /// Returns the list of shows that has been updated since the time specified as unix timestamp.
        /// </summary>
        /// <param name="since">The unix timestamp</param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<List<ShowImagesInfo>> GetLatestShowsAsync(long since, CancellationToken cancellationToken = default);
    }
}
