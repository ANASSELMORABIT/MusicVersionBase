using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PRJ_FINAL_MP09_MP03.Models
{
    public class TopTracks
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Album
    {
        public string album_type { get; set; }
        public List<Artist> artists { get; set; }
        public ExternalUrls external_urls { get; set; }
        public string id { get; set; }
        public List<Image> images { get; set; }
        public bool is_playable { get; set; }
        public string name { get; set; }
        public string release_date { get; set; }
        public string release_date_precision { get; set; }
        public int total_tracks { get; set; }
        public string type { get; set; }
        public string uri { get; set; }
    }

    public class Artist
    {
        public ExternalUrls external_urls { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string uri { get; set; }
    }

    public class Data
    {
        public List<Track> tracks { get; set; }
    }

    public class ExternalIds
    {
        public string isrc { get; set; }
    }

    public class ExternalUrls
    {
        public string spotify { get; set; }
    }

    public class Image
    {
        public string url { get; set; }
        public int height { get; set; }
        public int width { get; set; }
    }

    public class Root
    {
        public bool success { get; set; }
        public Data data { get; set; }
        public long generatedTimeStamp { get; set; }
    }

    public class Track
    {
        public Album album { get; set; }
        public List<Artist> artists { get; set; }
        public int disc_number { get; set; }
        public int duration_ms { get; set; }
        public bool @explicit { get; set; }
        public ExternalIds external_ids { get; set; }
        public ExternalUrls external_urls { get; set; }
        public string id { get; set; }
        public bool is_local { get; set; }
        public bool is_playable { get; set; }
        public string name { get; set; }
        public int popularity { get; set; }
        public string preview_url { get; set; }
        public int track_number { get; set; }
        public string type { get; set; }
        public string uri { get; set; }
    }


    }
}