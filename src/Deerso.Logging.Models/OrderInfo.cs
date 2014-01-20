using System;

namespace Deerso.Logging.Models
{
    public class OrderInfo
    {
        public DateTime TimeOrdered { get; set; } 
        public int OrderNumber { get; set; }
        public decimal OrderAmount { get; set; }
        public string IpAddress { get; set; }
        public string OriginRefererUrl { get; set; }
    }
}