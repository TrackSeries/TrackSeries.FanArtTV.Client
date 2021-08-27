using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TrackSeries.FanArtTV.Client.Music
{
    public class ArtistInfo
    {
        public string Name { get; set; }
        [JsonPropertyName("mbid_id")]
        public string MBID { get; set; }

        public Dictionary<Guid, AlbumImages> Albums { get; set; }
    }
}