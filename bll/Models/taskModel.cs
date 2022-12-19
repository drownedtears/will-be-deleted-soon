using System;
using System.Collections.Generic;
using dal;

namespace bll
{
    public partial class taskModel
    {
        public int id { get; set; }

        public string type { get; set; }

        public string header { get; set; }

        public string content_text { get; set; }

        public string condition { get; set; }

        public DateTime cre_date { get; set; }

        public DateTime finish_date { get; set; }

        public int user_id { get; set; }

        public DateTime dead_line { get; set; }

        public int days_to_finish { get; set; }

        public int sleep { get; set; }

        public int stat_id { get; set; }

        public int group_id { get; set; }

        public int reminder_id { get; set; }

        public taskModel() { }

        public taskModel(MyTask a)
        {
            this.id = a.task_id;
            this.type = a.type;
            this.header = a.header;
            this.content_text = a.content_text;
            this.condition = a.condition;
            this.cre_date = a.cre_date;
            this.finish_date = a.finish_date == null ? DateTime.Now : (DateTime)a.finish_date;
            this.user_id = a.user_id;
            this.dead_line = a.dead_line == null ? DateTime.Now : (DateTime)a.dead_line;      
            this.days_to_finish = a.days_to_finish == null ? 0 : (int)a.days_to_finish;      
            this.sleep = a.sleep == null ? 0 : (int)a.sleep;      
            this.stat_id = a.stat_id == null ? 0 : (int)a.stat_id;      
            this.group_id = a.group_id == null ? 0 : (int)a.group_id;
            this.reminder_id = a.reminder_id == null ? 0 : (int)a.reminder_id;
        }
    }
}
