using dal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bll
{
    public partial class activityModel
    {

        public int activity_id { get; set; }

        public int user_id { get; set; }


        public string task_name { get; set; }


        public DateTime finish_date { get; set; }


        public string event_name { get; set; }


        public activityModel() { }

        public activityModel(Activity a)
        {
            this.activity_id = a.activity_id;
            this.user_id = a.user_id;
            this.task_name = a.task_name;
            this.finish_date = a.finish_date;
            this.event_name = a.event_name;
        }
    }
}
