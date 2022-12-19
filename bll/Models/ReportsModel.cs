using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bll
{
    public partial class ReportsModel
    {
        public class R2Result
        {
            public int deal_id { get; set; }
            public decimal price { get; set; }
            public DateTime date { get; set; }
        }

        public class R1Result
        {
            public string type { get; set; }

            public string location { get; set; }
        }
    }
}
