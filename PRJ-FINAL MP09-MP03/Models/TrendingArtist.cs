using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PRJ_FINAL_MP09_MP03.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class ChartItemArtis
    {
        public string _type { get; set; }
        public string type { get; set; }
        public ItemArtist item { get; set; }
    }

    public class ItemArtist
    {
        public string _type { get; set; }
        public string api_path { get; set; }
        public string header_image_url { get; set; }
        public int id { get; set; }
        public string image_url { get; set; }
        public string index_character { get; set; }
        public bool is_meme_verified { get; set; }
        public bool is_verified { get; set; }
        public string name { get; set; }
        public string slug { get; set; }
        public string url { get; set; }
        public int? iq { get; set; }
    }

    public class RootArtist
    {
        public List<ChartItemArtis> chart_items { get; set; }
        public int next_page { get; set; }
    }


}