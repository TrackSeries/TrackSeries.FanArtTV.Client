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
var gameOfThrones = await client.TV.GetShowAsync(121361, default);
var latestShows = await client.TV.GetLatestShowsAsync(DateTime.Now.AddDays(-7), default);

// Movies
var lordOfTheRings = await client.Movies.GetMovieAsync("120", default);
var latestMovies = await client.Movies.GetLatestMoviesAsync(DateTime.Now.AddDays(-7), default);

Console.WriteLine("Popcorn");
