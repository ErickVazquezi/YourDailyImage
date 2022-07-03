using System;
using System.Collections.Generic;
using System.Text;

namespace YourDailyPic.Models
{
    public class PexelsResponse
    {
        public string total_results { get; set; }
        public int page { get; set; }
        public int per_page { get; set; }
        public List<PexelsImage> photos { get; set; }
    }
}
