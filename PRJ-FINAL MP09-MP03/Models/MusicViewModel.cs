using System.Collections.Generic;

namespace PRJ_FINAL_MP09_MP03.Models
{
    public class MusicViewModel
    {
        public List<Recommendation> Recommendations { get; set; }
        public List<ChartItem> Trending { get; set; }
        public List<ChartItemArtis> TrendingArtists { get; set; }
        public List<ChartItemAlbum> TrendingAlbums { get; set; }

    }
}
