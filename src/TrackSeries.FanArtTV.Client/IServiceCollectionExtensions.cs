using System;
using System.Net.Http;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Options;
using Polly;
using Polly.Contrib.WaitAndRetry;
using Polly.Extensions.Http;
using TrackSeries.FanArtTV.Client;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class IServiceCollectionExtensions
    {
        public static IHttpClientBuilder AddFanArtTVClient(this IServiceCollection services, Action<FanArtTVClientOptions> configureOptions = null)
        {
            if (services is null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            services.AddOptions();

            if (configureOptions != null)
            {
                services.Configure(configureOptions);
            }

            var builder = services.AddHttpClient<IFanArtTVClient, FanArtTVClient>((provider, client) =>
            {
                var options = provider.GetService<IOptions<FanArtTVClientOptions>>().Value;
                client.BaseAddress = new Uri(options.BaseAddress);
                client.DefaultRequestHeaders.Add("api-key", options.ApiKey);
                if (string.IsNullOrEmpty(options.ClientKey))
                {
                    client.DefaultRequestHeaders.Add("client-key", options.ClientKey);
                }
            })
            .AddPolicyHandler(GetRetryPolicy());

            services.TryAddEnumerable(ServiceDescriptor.Singleton<IPostConfigureOptions<FanArtTVClientOptions>, FanArtTVClientPostConfigureOptions>());

            return builder;
        }

        private static IAsyncPolicy<HttpResponseMessage> GetRetryPolicy()
        {
            var delay = Backoff.DecorrelatedJitterBackoffV2(medianFirstRetryDelay: TimeSpan.FromSeconds(1), retryCount: 5);
            return HttpPolicyExtensions
                .HandleTransientHttpError()
                .WaitAndRetryAsync(delay);
        }
    }
}