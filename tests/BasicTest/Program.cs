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

var gameOfThrones = await client.TV.GetShow(121361, default);
