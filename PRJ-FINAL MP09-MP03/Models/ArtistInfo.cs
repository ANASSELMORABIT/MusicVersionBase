using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PRJ_FINAL_MP09_MP03.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class ArtistsInfo
    {
        public int totalCount { get; set; }
        public List<ItemArtistInfo> items { get; set; }
        public PagingInfoArtistInfo pagingInfo { get; set; }
    }

    public class AvatarImageArtistInfo
    {
        public List<SourceArtistInfo> sources { get; set; }
    }

    public class DataArtistInfo
    {
        public string uri { get; set; }
        public ProfileArtistInfo profile { get; set; }
        public VisualsArtistInfo visuals { get; set; }
    }

    public class ItemArtistInfo
    {
        public DataArtistInfo data { get; set; }
    }

    public class PagingInfoArtistInfo
    {
        public int nextOffset { get; set; }
        public int limit { get; set; }
    }

    public class ProfileArtistInfo
    {
        public string name { get; set; }
    }

    public class RootArtistInfo
    {
        public string query { get; set; }
        public ArtistsInfo artists { get; set; }
    }

    public class SourceArtistInfo
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public class VisualsArtistInfo
    {
        public AvatarImageArtistInfo avatarImage { get; set; }
    }


}