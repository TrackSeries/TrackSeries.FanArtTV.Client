namespace TrackSeries.FanArtTV.Client
{
    public class FanArtTVClientOptions
    {
        public string BaseAddress { get; set; }
        /// <summary>
        /// FanArt.TV ApiKey. See <see href="https://fanart.tv/get-an-api-key/">FanArtTV docs</see>
        /// </summary>
        public string ApiKey { get; set; }
        /// <summary>
        /// FanArtTV User's personal Key. See <see href="https://fanart.tv/2015/01/personal-api-keys/">FanArtTV docs</see>
        /// </summary>
        public string ClientKey { get; set; }
    }
}