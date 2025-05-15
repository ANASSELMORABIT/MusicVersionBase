using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PRJ_FINAL_MP09_MP03.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class FeaturedArtist
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
    }

    public class PrimaryArtist
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
        public int iq { get; set; }
    }

    public class PrimaryArtist2
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
        public int iq { get; set; }
    }

    public class Recommendation
    {
        public string _type { get; set; }
        public int unique_common_viewers { get; set; }
        public RecommendedSong recommended_song { get; set; }
    }

    public class RecommendedSong
    {
        public string _type { get; set; }
        public int annotation_count { get; set; }
        public string api_path { get; set; }
        public string artist_names { get; set; }
        public string full_title { get; set; }
        public string header_image_thumbnail_url { get; set; }
        public string header_image_url { get; set; }
        public int id { get; set; }
        public bool instrumental { get; set; }
        public int lyrics_owner_id { get; set; }
        public string lyrics_state { get; set; }
        public int lyrics_updated_at { get; set; }
        public string path { get; set; }
        public string primary_artist_names { get; set; }
        public int pyongs_count { get; set; }
        public string relationships_index_url { get; set; }
        public ReleaseDateComponents release_date_components { get; set; }
        public string release_date_for_display { get; set; }
        public string release_date_with_abbreviated_month_for_display { get; set; }
        public string song_art_image_thumbnail_url { get; set; }
        public string song_art_image_url { get; set; }
        public Stats stats { get; set; }
        public string title { get; set; }
        public string title_with_featured { get; set; }
        public int updated_by_human_at { get; set; }
        public string url { get; set; }
        public List<FeaturedArtist> featured_artists { get; set; }
        public PrimaryArtist primary_artist { get; set; }
        public List<PrimaryArtist> primary_artists { get; set; }
    }

    public class ReleaseDateComponents
    {
        public int year { get; set; }
        public int month { get; set; }
        public int day { get; set; }
    }

    public class Root
    {
        public SongRecommendations song_recommendations { get; set; }
    }

    public class SongRecommendations
    {
        public string _type { get; set; }
        public string api_path { get; set; }
        public string recommendation_strategy { get; set; }
        public List<Recommendation> recommendations { get; set; }
    }

    public class Stats
    {
        public int unreviewed_annotations { get; set; }
        public bool hot { get; set; }
        public int pageviews { get; set; }
    }


}