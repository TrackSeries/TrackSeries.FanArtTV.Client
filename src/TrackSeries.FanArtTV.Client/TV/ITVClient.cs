using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace TrackSeries.FanArtTV.Client.TV
{
    public interface ITVClient
    {
        Task<ShowImages> GetShow(int showId, CancellationToken cancellationToken);
        Task<ShowImages> GetShow(string showId, CancellationToken cancellationToken);
        /// <summary>
        /// Returns the list of shows that has been updated since the time specified.
        /// </summary>
        /// <param name="since"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<List<ShowImagesInfo>> GetLatestShows(DateTime since, CancellationToken cancellationToken);
        /// <summary>
        /// Returns the list of shows that has been updated since the time specified as unix timestamp.
        /// </summary>
        /// <param name="since">The unix timestamp</param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<List<ShowImagesInfo>> GetLatestShows(long since, CancellationToken cancellationToken);
    }
}
