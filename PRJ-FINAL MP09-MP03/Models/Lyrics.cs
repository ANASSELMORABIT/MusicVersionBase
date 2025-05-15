using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PRJ_FINAL_MP09_MP03.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class ColorsLyrics
    {
        public int background { get; set; }
        public int text { get; set; }
        public int highlightText { get; set; }
    }

    public class Line
    {
        public string startTimeMs { get; set; }
        public string words { get; set; }
        public List<object> syllables { get; set; }
        public string endTimeMs { get; set; }
    }

    public class Lyrics
    {
        public string syncType { get; set; }
        public List<Line> lines { get; set; }
        public string provider { get; set; }
        public string providerLyricsId { get; set; }
        public string providerDisplayName { get; set; }
        public string syncLyricsUri { get; set; }
        public bool isDenseTypeface { get; set; }
        public List<object> alternatives { get; set; }
        public string language { get; set; }
        public bool isRtlLanguage { get; set; }
        public string capStatus { get; set; }
        public List<PreviewLineLyrics> previewLines { get; set; }
    }

    public class PreviewLineLyrics
    {
        public string startTimeMs { get; set; }
        public string words { get; set; }
        public List<object> syllables { get; set; }
        public string endTimeMs { get; set; }
    }

    public class RootLyrics
    {
        public Lyrics lyrics { get; set; }
        public ColorsLyrics colors { get; set; }
        public bool hasVocalRemoval { get; set; }
    }


}