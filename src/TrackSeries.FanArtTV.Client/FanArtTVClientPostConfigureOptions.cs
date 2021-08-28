using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace TrackSeries.FanArtTV.Client
{
    internal class FanArtTVClientPostConfigureOptions : IPostConfigureOptions<FanArtTVClientOptions>
    {
        private readonly IConfiguration _configuration;

        public FanArtTVClientPostConfigureOptions(IConfiguration configuration)
        {
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }

        public void PostConfigure(string name, FanArtTVClientOptions options)
        {
            Initialize(options);

            if (string.IsNullOrEmpty(options.ApiKey))
            {
                throw new InvalidOperationException("ApiKey must be configured.");
            }

            if (!Uri.TryCreate(options.BaseAddress, UriKind.Absolute, out var _))
            {
                options.BaseAddress = "https://webservice.fanart.tv/v3/";
            }
        }

        private void Initialize(FanArtTVClientOptions options)
        {
            //If there's no ApiKey let's try to read values from Configuration
            if (string.IsNullOrEmpty(options.ApiKey))
            {
                var newOptions = _configuration.GetSection(nameof(FanArtTVClientOptions)).Get<FanArtTVClientOptions>();
                options.ApiKey = newOptions.ApiKey;
                options.ClientKey = newOptions.ClientKey;
            }
        }
    }
}
