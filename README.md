TrackSeries FanArtTV .NET Client
===================
.NET Client for the [FanArt.TV](https://www.fanart.tv) API integrated with `IHttpClientFactory` best practices and `IServiceCollection`.

![Build](https://github.com/TrackSeries/TrackSeries.FanArtTV.Client/workflows/Build/badge.svg) [![NuGet](https://img.shields.io/nuget/v/TrackSeries.FanArtTV.Client.svg?maxAge=2592000?style=flat)](https://www.nuget.org/packages/TrackSeries.FanArtTV.Client/)

# Getting Started

The best way of using the client is adding the dependencies to the `ServiceCollection` and resolving `IFanArtTVClient` where you'd like to use it:

```C#
services.AddFanArtTVClient(options => 
{
    options.ApiKey = "Set here your API-KEY for FanArtTV";
});
```

The client comes automatically configured with an exponential Retry Policy and uses the `IHttpClientFactory` best practices.

[Example making use of all available endpoints](tests/BasicTest/Program.cs)

# References
- [FanArtTV V3 API Documentation](https://fanarttv.docs.apiary.io/)
- [Benefits of using IHttpClientFactory](https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#benefits-of-using-ihttpclientfactory)