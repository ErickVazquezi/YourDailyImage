using System;
using System.Collections.Generic;
using System.Text;

namespace YourDailyPic.Models
{
    public class PexelsImage
    {
        public int id { get; set; }
        public double width { get; set; }
        public double height { get; set; }
        public string url { get; set; }
        public string photographer { get; set; }
        public string photographer_url { get; set; }
        public int photographer_id { get; set; }
        public string avg_color { get; set; }
        public PexelsImageSource src { get; set; }
        public string alt { get; set; }
    }
}
