using System;
using System.Collections.Generic;
using dal;

namespace bll
{
    public partial class reminderModel
    {

        public int id { get; set; }

        public string name { get; set; }

        public string content_text { get; set; }
        public DateTime full_time { get; set; }

        public int user_id { get; set; }

        public reminderModel() { }

        public reminderModel(Reminder a)
        {
            this.id = a.reminder_id;
            this.name = a.name;
            this.content_text = a.content_text;
            this.full_time = a.full_time;
            this.user_id = a.user_id;
        }

    }
}
