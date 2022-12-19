using System;
using System.Collections.Generic;
using dal;

namespace bll
{
    public partial class statModel
    {
        public int id { get; set; }

        public DateTime start_date { get; set; }

        public DateTime finish_date { get; set; }

        public string condition { get; set; }

        public statModel() { }

        public statModel(Stat stat)
        {
            this.id = stat.stat_id;
            this.start_date = stat.start_date;
            this.finish_date = stat.finish_date;
            this.condition = stat.condition;
        }
    }
}
