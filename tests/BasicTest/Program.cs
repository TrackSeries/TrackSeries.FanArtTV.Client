using System.Reflection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TrackSeries.FanArtTV.Client;

var services = new ServiceCollection();
var configuration = new ConfigurationBuilder()
    .AddUserSecrets(assembly: Assembly.GetExecutingAssembly())
    .Build();

services.AddSingleton<IConfiguration>(configuration);

services.AddFanArtTVClient(options =>
{
    options.ApiKey = configuration["ApiKey"];
});

var provider = services.BuildServiceProvider();

var client = provider.GetRequiredService<IFanArtTVClient>();

// Shows
var gameOfThrones = await client.TV.GetShowAsync(121361);
var latestShows = await client.TV.GetLatestShowsAsync(DateTime.Now.AddDays(-7));

// Movies
var lordOfTheRings = await client.Movies.GetMovieAsync("120");
var latestMovies = await client.Movies.GetLatestMoviesAsync(DateTime.Now.AddDays(-7));

// Music
var evanescense = await client.Music.GetArtistAsync(Guid.Parse("f4a31f0a-51dd-4fa7-986d-3095c40c5ed9"));
var album = await client.Music.GetAlbumAsync(Guid.Parse("9ba659df-5814-32f6-b95f-02b738698e7c"));
var label = await client.Music.GetLabelAsync(Guid.Parse("e832b688-546b-45e3-83e5-9f8db5dcde1d"));
var latestArtists = await client.Music.GetLatestArtistsAsync(DateTime.Now.AddDays(-7));

Console.WriteLine("Popcorn");
