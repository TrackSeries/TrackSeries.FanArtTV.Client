﻿using System.Text.Json.Serialization;

namespace TrackSeries.FanArtTV.Client.Music
{
    public class MusicImagesInfo
    {
        public string Id { get; set; }
        public string Name { get; set; }

        [JsonPropertyName("new_images")]
        public string NewImages { get; set; }

        [JsonPropertyName("total_images")]
        public string TotalImages { get; set; }
    }
}
