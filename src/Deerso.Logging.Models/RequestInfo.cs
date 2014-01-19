using System;

namespace Deerso.Logging.Models
{
    public class RequestInfo
    {
        public DateTime RequestTime { get; set; }
        public string UserAgent { get; set; }
        public bool IsCrawler { get; set; }
        public string Url { get; set; }
        public string RefererUrl { get; set; } 
        public string IpAddress { get; set; }
        public string OriginRefererUrl { get; set; }
    }
}