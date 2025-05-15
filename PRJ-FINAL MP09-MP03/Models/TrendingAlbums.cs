using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PRJ_FINAL_MP09_MP03.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Artist
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

    public class ChartItemAlbum
    {
        public string _type { get; set; }
        public string type { get; set; }
        public ItemAlbum item { get; set; }
    }

    public class ItemAlbum
    {
        public string _type { get; set; }
        public string api_path { get; set; }
        public string cover_art_thumbnail_url { get; set; }
        public string cover_art_url { get; set; }
        public string full_title { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public string name_with_artist { get; set; }
        public string primary_artist_names { get; set; }
        public ReleaseDateComponents release_date_components { get; set; }
        public string release_date_for_display { get; set; }
        public string url { get; set; }
        public Artist artist { get; set; }
        public List<PrimaryArtist> primary_artists { get; set; }
    }

    public class PrimaryArtistAlbum
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

    public class ReleaseDateComponentsAlbum
    {
        public int year { get; set; }
        public int? month { get; set; }
        public int? day { get; set; }
    }

    public class RootAlbum
    {
        public List<ChartItemAlbum> chart_items { get; set; }
        public int next_page { get; set; }
    }


}