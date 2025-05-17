using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PRJ_FINAL_MP09_MP03.Models
{
    public class SongDetaille
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
            public class AcceptedBy
            {
                public string _type { get; set; }
                public string about_me_summary { get; set; }
                public string api_path { get; set; }
                public Avatar avatar { get; set; }
                public string header_image_url { get; set; }
                public string human_readable_role_for_display { get; set; }
                public int id { get; set; }
                public int iq { get; set; }
                public bool is_meme_verified { get; set; }
                public bool is_verified { get; set; }
                public string login { get; set; }
                public string name { get; set; }
                public string role_for_display { get; set; }
                public string url { get; set; }
                public CurrentUserMetadata current_user_metadata { get; set; }
            }

            public class Album
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

            public class Album2
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

            public class Annotatable
            {
                public string _type { get; set; }
                public string api_path { get; set; }
                public ClientTimestamps client_timestamps { get; set; }
                public string context { get; set; }
                public int id { get; set; }
                public string image_url { get; set; }
                public string link_title { get; set; }
                public string title { get; set; }
                public string type { get; set; }
                public string url { get; set; }
            }

            public class Annotation
            {
                public string _type { get; set; }
                public string api_path { get; set; }
                public bool being_created { get; set; }
                public Body body { get; set; }
                public int comment_count { get; set; }
                public bool community { get; set; }
                public int created_at { get; set; }
                public object custom_preview { get; set; }
                public bool deleted { get; set; }
                public string embed_content { get; set; }
                public bool has_voters { get; set; }
                public int id { get; set; }
                public bool needs_exegesis { get; set; }
                public bool pinned { get; set; }
                public int proposed_edit_count { get; set; }
                public object pyongs_count { get; set; }
                public int referent_id { get; set; }
                public string share_url { get; set; }
                public object source { get; set; }
                public string state { get; set; }
                public string twitter_share_message { get; set; }
                public string url { get; set; }
                public bool verified { get; set; }
                public int votes_total { get; set; }
                public CurrentUserMetadata current_user_metadata { get; set; }
                public AcceptedBy accepted_by { get; set; }
                public List<Author> authors { get; set; }
                public List<object> cosigned_by { get; set; }
                public CreatedBy created_by { get; set; }
                public object rejection_comment { get; set; }
                public TopComment top_comment { get; set; }
                public object verified_by { get; set; }
            }

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
                public int iq { get; set; }
            }

            public class Artist3
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

            public class Author
            {
                public string _type { get; set; }
                public double attribution { get; set; }
                public object pinned_role { get; set; }
                public User user { get; set; }
            }

            public class Author2
            {
                public string _type { get; set; }
                public string about_me_summary { get; set; }
                public string api_path { get; set; }
                public Avatar avatar { get; set; }
                public string header_image_url { get; set; }
                public string human_readable_role_for_display { get; set; }
                public int id { get; set; }
                public int iq { get; set; }
                public bool is_meme_verified { get; set; }
                public bool is_verified { get; set; }
                public string login { get; set; }
                public string name { get; set; }
                public string role_for_display { get; set; }
                public string url { get; set; }
                public CurrentUserMetadata current_user_metadata { get; set; }
            }

            public class Avatar
            {
                public Tiny tiny { get; set; }
                public Thumb thumb { get; set; }
                public Small small { get; set; }
                public Medium medium { get; set; }
            }

            public class Body
            {
                public string html { get; set; }
            }

            public class BoundingBox
            {
                public int width { get; set; }
                public int height { get; set; }
            }

            public class ClientTimestamps
            {
                public int updated_by_human_at { get; set; }
                public int lyrics_updated_at { get; set; }
            }

            public class CreatedBy
            {
                public string _type { get; set; }
                public string about_me_summary { get; set; }
                public string api_path { get; set; }
                public Avatar avatar { get; set; }
                public string header_image_url { get; set; }
                public string human_readable_role_for_display { get; set; }
                public int id { get; set; }
                public int iq { get; set; }
                public bool is_meme_verified { get; set; }
                public bool is_verified { get; set; }
                public string login { get; set; }
                public string name { get; set; }
                public string role_for_display { get; set; }
                public string url { get; set; }
                public CurrentUserMetadata current_user_metadata { get; set; }
            }

            public class CurrentUserMetadata
            {
                public List<string> permissions { get; set; }
                public List<string> excluded_permissions { get; set; }
                public Interactions interactions { get; set; }
                public Relationships relationships { get; set; }
                public IqByAction iq_by_action { get; set; }
            }

            public class CustomPerformance
            {
                public string label { get; set; }
                public List<Artist> artists { get; set; }
            }

            public class Description
            {
                public string html { get; set; }
            }

            public class DescriptionAnnotation
            {
                public string _type { get; set; }
                public int annotator_id { get; set; }
                public string annotator_login { get; set; }
                public string api_path { get; set; }
                public string classification { get; set; }
                public string fragment { get; set; }
                public int id { get; set; }
                public string ios_app_url { get; set; }
                public bool is_description { get; set; }
                public bool is_image { get; set; }
                public string path { get; set; }
                public Range range { get; set; }
                public int song_id { get; set; }
                public string url { get; set; }
                public List<object> verified_annotator_ids { get; set; }
                public CurrentUserMetadata current_user_metadata { get; set; }
                public TrackingPaths tracking_paths { get; set; }
                public string twitter_share_message { get; set; }
                public Annotatable annotatable { get; set; }
                public List<Annotation> annotations { get; set; }
            }

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
                public int iq { get; set; }
            }

            public class Interactions
            {
                public bool pyong { get; set; }
                public bool following { get; set; }
                public bool cosign { get; set; }
                public object vote { get; set; }
            }

            public class IqByAction
            {
            }

            public class LyricsMarkedStaffApprovedBy
            {
                public string _type { get; set; }
                public string about_me_summary { get; set; }
                public string api_path { get; set; }
                public Avatar avatar { get; set; }
                public string header_image_url { get; set; }
                public string human_readable_role_for_display { get; set; }
                public int id { get; set; }
                public int iq { get; set; }
                public bool is_meme_verified { get; set; }
                public bool is_verified { get; set; }
                public string login { get; set; }
                public string name { get; set; }
                public string role_for_display { get; set; }
                public string url { get; set; }
                public CurrentUserMetadata current_user_metadata { get; set; }
            }

            public class Medium
            {
                public string url { get; set; }
                public BoundingBox bounding_box { get; set; }
            }

            public class Medium6
            {
                public string provider { get; set; }
                public int start { get; set; }
                public string type { get; set; }
                public string url { get; set; }
                public string native_uri { get; set; }
            }

            public class MetadataFieldsNa
            {
                public bool albums { get; set; }
                public bool song_meaning { get; set; }
            }

            public class NextSong
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
                public object pyongs_count { get; set; }
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

            public class PrimaryArtist3
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

            public class PrimaryTag
            {
                public string _type { get; set; }
                public int id { get; set; }
                public string name { get; set; }
                public bool primary { get; set; }
                public string url { get; set; }
            }

            public class ProducerArtist
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

            public class Range
            {
                public string content { get; set; }
            }

            public class Relationships
            {
            }

            public class ReleaseDateComponents
            {
                public int year { get; set; }
                public int month { get; set; }
                public int day { get; set; }
            }

            public class Root
            {
                public Song song { get; set; }
            }

            public class Small
            {
                public string url { get; set; }
                public BoundingBox bounding_box { get; set; }
            }

            public class Song
            {
                public string _type { get; set; }
                public int annotation_count { get; set; }
                public string api_path { get; set; }
                public string apple_music_id { get; set; }
                public string apple_music_player_url { get; set; }
                public string artist_names { get; set; }
                public int comment_count { get; set; }
                public object custom_header_image_url { get; set; }
                public string custom_song_art_image_url { get; set; }
                public Description description { get; set; }
                public string description_preview { get; set; }
                public string embed_content { get; set; }
                public bool @explicit { get; set; }
                public string facebook_share_message_without_url { get; set; }
                public bool featured_video { get; set; }
                public string full_title { get; set; }
                public object has_instagram_reel_annotations { get; set; }
                public string header_image_thumbnail_url { get; set; }
                public string header_image_url { get; set; }
                public bool hidden { get; set; }
                public int id { get; set; }
                public bool instrumental { get; set; }
                public bool is_music { get; set; }
                public string language { get; set; }
                public int lyrics_owner_id { get; set; }
                public string lyrics_state { get; set; }
                public int lyrics_updated_at { get; set; }
                public bool lyrics_verified { get; set; }
                public MetadataFieldsNa metadata_fields_na { get; set; }
                public string next_song_source { get; set; }
                public string path { get; set; }
                public int pending_lyrics_edits_count { get; set; }
                public string primary_artist_names { get; set; }
                public bool published { get; set; }
                public string pusher_channel { get; set; }
                public object pyongs_count { get; set; }
                public string recording_location { get; set; }
                public string relationships_index_url { get; set; }
                public string release_date { get; set; }
                public ReleaseDateComponents release_date_components { get; set; }
                public string release_date_for_display { get; set; }
                public string release_date_with_abbreviated_month_for_display { get; set; }
                public string share_url { get; set; }
                public string song_art_image_thumbnail_url { get; set; }
                public string song_art_image_url { get; set; }
                public object soundcloud_url { get; set; }
                public string spotify_uuid { get; set; }
                public Stats stats { get; set; }
                public string title { get; set; }
                public string title_with_featured { get; set; }
                public List<TrackingDatum> tracking_data { get; set; }
                public TrackingPaths tracking_paths { get; set; }
                public string transcription_priority { get; set; }
                public string twitter_share_message { get; set; }
                public string twitter_share_message_without_url { get; set; }
                public int updated_by_human_at { get; set; }
                public string url { get; set; }
                public List<object> viewable_by_roles { get; set; }
                public object vttp_id { get; set; }
                public string youtube_start { get; set; }
                public string youtube_url { get; set; }
                public CurrentUserMetadata current_user_metadata { get; set; }
                public string song_art_primary_color { get; set; }
                public string song_art_secondary_color { get; set; }
                public string song_art_text_color { get; set; }
                public Album album { get; set; }
                public List<Album> albums { get; set; }
                public List<CustomPerformance> custom_performances { get; set; }
                public DescriptionAnnotation description_annotation { get; set; }
                public List<object> featured_artists { get; set; }
                public object lyrics_marked_complete_by { get; set; }
                public LyricsMarkedStaffApprovedBy lyrics_marked_staff_approved_by { get; set; }
                public List<Medium> media { get; set; }
                public NextSong next_song { get; set; }
                public PrimaryArtist primary_artist { get; set; }
                public List<PrimaryArtist> primary_artists { get; set; }
                public PrimaryTag primary_tag { get; set; }
                public List<ProducerArtist> producer_artists { get; set; }
                public List<SongRelationship> song_relationships { get; set; }
                public List<Tag> tags { get; set; }
                public TopScholar top_scholar { get; set; }
                public List<TranslationSong> translation_songs { get; set; }
                public List<VerifiedAnnotationsBy> verified_annotations_by { get; set; }
                public List<VerifiedContributor> verified_contributors { get; set; }
                public List<VerifiedLyricsBy> verified_lyrics_by { get; set; }
                public List<WriterArtist> writer_artists { get; set; }
            }

            public class Song2
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
                public int? lyrics_updated_at { get; set; }
                public string path { get; set; }
                public string primary_artist_names { get; set; }
                public object pyongs_count { get; set; }
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

            public class SongRelationship
            {
                public string _type { get; set; }
                public string relationship_type { get; set; }
                public string type { get; set; }
                public string url { get; set; }
                public List<Song> songs { get; set; }
            }

            public class Stats
            {
                public int accepted_annotations { get; set; }
                public int contributors { get; set; }
                public int iq_earners { get; set; }
                public int transcribers { get; set; }
                public int unreviewed_annotations { get; set; }
                public int verified_annotations { get; set; }
                public int concurrents { get; set; }
                public bool hot { get; set; }
                public int pageviews { get; set; }
            }

            public class Tag
            {
                public string _type { get; set; }
                public int id { get; set; }
                public string name { get; set; }
                public bool primary { get; set; }
                public string url { get; set; }
            }

            public class Thumb
            {
                public string url { get; set; }
                public BoundingBox bounding_box { get; set; }
            }

            public class Tiny
            {
                public string url { get; set; }
                public BoundingBox bounding_box { get; set; }
            }

            public class TopComment
            {
                public string _type { get; set; }
                public string api_path { get; set; }
                public Body body { get; set; }
                public int commentable_id { get; set; }
                public string commentable_type { get; set; }
                public int created_at { get; set; }
                public bool has_voters { get; set; }
                public int id { get; set; }
                public object pinned_role { get; set; }
                public int votes_total { get; set; }
                public CurrentUserMetadata current_user_metadata { get; set; }
                public object anonymous_author { get; set; }
                public Author author { get; set; }
                public object reason { get; set; }
            }

            public class TopScholar
            {
                public string _type { get; set; }
                public double attribution_value { get; set; }
                public object pinned_role { get; set; }
                public User user { get; set; }
            }

            public class TrackingDatum
            {
                public string key { get; set; }
                public object value { get; set; }
            }

            public class TrackingPaths
            {
                public string aggregate { get; set; }
                public string concurrent { get; set; }
            }

            public class TranslationSong
            {
                public string _type { get; set; }
                public string api_path { get; set; }
                public int id { get; set; }
                public string language { get; set; }
                public string lyrics_state { get; set; }
                public string path { get; set; }
                public string title { get; set; }
                public string url { get; set; }
            }

            public class User
            {
                public string _type { get; set; }
                public string about_me_summary { get; set; }
                public string api_path { get; set; }
                public Avatar avatar { get; set; }
                public string header_image_url { get; set; }
                public string human_readable_role_for_display { get; set; }
                public int id { get; set; }
                public int iq { get; set; }
                public bool is_meme_verified { get; set; }
                public bool is_verified { get; set; }
                public string login { get; set; }
                public string name { get; set; }
                public string role_for_display { get; set; }
                public string url { get; set; }
                public CurrentUserMetadata current_user_metadata { get; set; }
            }

            public class VerifiedAnnotationsBy
            {
                public string _type { get; set; }
                public string about_me_summary { get; set; }
                public string api_path { get; set; }
                public Avatar avatar { get; set; }
                public string header_image_url { get; set; }
                public string human_readable_role_for_display { get; set; }
                public int id { get; set; }
                public int iq { get; set; }
                public bool is_meme_verified { get; set; }
                public bool is_verified { get; set; }
                public string login { get; set; }
                public string name { get; set; }
                public string role_for_display { get; set; }
                public string url { get; set; }
                public CurrentUserMetadata current_user_metadata { get; set; }
            }

            public class VerifiedContributor
            {
                public List<string> contributions { get; set; }
                public Artist artist { get; set; }
                public User user { get; set; }
            }

            public class VerifiedLyricsBy
            {
                public string _type { get; set; }
                public string about_me_summary { get; set; }
                public string api_path { get; set; }
                public Avatar avatar { get; set; }
                public string header_image_url { get; set; }
                public string human_readable_role_for_display { get; set; }
                public int id { get; set; }
                public int iq { get; set; }
                public bool is_meme_verified { get; set; }
                public bool is_verified { get; set; }
                public string login { get; set; }
                public string name { get; set; }
                public string role_for_display { get; set; }
                public string url { get; set; }
                public CurrentUserMetadata current_user_metadata { get; set; }
            }

            public class WriterArtist
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


    }
}