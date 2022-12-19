using System;
using System.Collections.Generic;
using dal;

namespace bll
{
    public partial class groupModel
    {

        public int id { get; set; }

        public string name { get; set; }

        public string content_text { get; set; }

        public int user_id { get; set; }

        public string color { get; set; }

        public groupModel() { }

        public groupModel(Group a)
        {
            this.id = a.group_id;
            this.name = a.name;
            this.content_text = a.content_text;
            this.user_id = a.user_id;
            this.color = a.color;
        }

    }
}
