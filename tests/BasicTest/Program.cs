using System.Reflection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using TrackSeries.FanArtTV.Client;

var services = new ServiceCollection();
var configuration = new ConfigurationBuilder()
    .AddUserSecrets(assembly: Assembly.GetExecutingAssembly())
    .Build();

services.AddLogging(configure =>
{
    configure.AddConsole();
});

services.AddSingleton<IConfiguration>(configuration);

services.AddFanArtTVClient(options =>
{
    options.ApiKey = configuration["ApiKey"];
});

var provider = services.BuildServiceProvider();
var fanarttv = provider.GetRequiredService<IFanArtTVClient>();

// Shows
var gameOfThrones = await fanarttv.TV.GetShowAsync(121361);
var latestShows = await fanarttv.TV.GetLatestShowsAsync(DateTime.Now.AddDays(-7));

// Movies
var lordOfTheRings = await fanarttv.Movies.GetMovieAsync("120");
var latestMovies = await fanarttv.Movies.GetLatestMoviesAsync(DateTime.Now.AddDays(-7));

// Music
var evanescense = await fanarttv.Music.GetArtistAsync(Guid.Parse("f4a31f0a-51dd-4fa7-986d-3095c40c5ed9"));
var album = await fanarttv.Music.GetAlbumAsync(Guid.Parse("9ba659df-5814-32f6-b95f-02b738698e7c"));
var label = await fanarttv.Music.GetLabelAsync(Guid.Parse("e832b688-546b-45e3-83e5-9f8db5dcde1d"));
var latestArtists = await fanarttv.Music.GetLatestArtistsAsync(DateTime.Now.AddDays(-7));

evanescense = await fanarttv.Music.GetArtistAsync("f4a31f0a-51dd-4fa7-986d-3095c40c5ed9");
album = await fanarttv.Music.GetAlbumAsync("9ba659df-5814-32f6-b95f-02b738698e7c");
label = await fanarttv.Music.GetLabelAsync("e832b688-546b-45e3-83e5-9f8db5dcde1d");
