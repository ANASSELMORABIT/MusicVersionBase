using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PRJ_FINAL_MP09_MP03.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class RootYoutubeMp
    {
        public string link { get; set; }
        public string title { get; set; }
        public int filesize { get; set; }
        public int progress { get; set; }
        public double duration { get; set; }
        public string status { get; set; }
        public string msg { get; set; }
    }


}