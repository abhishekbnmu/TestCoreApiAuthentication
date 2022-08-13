using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IDLS.Models
{
    public class OrderDetails
    {
        public string @event { get; set; }
        public int order_id { get; set; }
        public string order_nbr { get; set; }
        public DateTime del_date { get; set; }
        public string status { get; set; }
        public DateTime timestamp { get; set; }
        public string sku { get; set; }
        public DateTime receipt_date { get; set; }

        public DateTime start_time { get; set; }
        public DateTime end_time { get; set; }

        public string comment { get; set; }

        public string file_name { get; set; }
        public string image { get; set; }
    }
}
