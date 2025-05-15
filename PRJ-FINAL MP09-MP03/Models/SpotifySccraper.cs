using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PRJ_FINAL_MP09_MP03.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class AlbumScraper
    {
        public string type { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public string shareUrl { get; set; }
        public List<CoverScraper> cover { get; set; }
    }

    public class ArtistScraper
    {
        public string type { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public string shareUrl { get; set; }
    }

    public class CoverScraper
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public class RootScraper
    {
        public bool status { get; set; }
        public string errorId { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public string shareUrl { get; set; }
        public bool @explicit { get; set; }
        public int durationMs { get; set; }
        public string durationText { get; set; }
        public List<ArtistScraper> artists { get; set; }
        public AlbumScraper album { get; set; }
    }


}