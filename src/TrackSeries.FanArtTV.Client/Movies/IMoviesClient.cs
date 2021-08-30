using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace TrackSeries.FanArtTV.Client.Movies
{
    public interface IMoviesClient
    {
        /// <summary>
        /// Get images for a movie
        /// </summary>
        /// <param name="id">The TMDB Id or IMDB Id</param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<MovieImages> GetMovieAsync(string id, CancellationToken cancellationToken = default);

        /// <summary>
        /// Returns the list of movies that has been updated since the time specified.
        /// </summary>
        /// <param name="since"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<List<MovieImagesInfo>> GetLatestMoviesAsync(DateTime since, CancellationToken cancellationToken = default);

        /// <summary>
        /// Returns the list of movies that has been updated since the time specified as unix timestamp.
        /// </summary>
        /// <param name="since">The unix timestamp</param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<List<MovieImagesInfo>> GetLatestMoviesAsync(long since, CancellationToken cancellationToken = default);
    }
}
