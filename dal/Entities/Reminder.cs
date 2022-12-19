using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dal
{
    [Table("Reminder")]
    public partial class Reminder
    {

        [Key]
        public int reminder_id { get; set; }

        public string name { get; set; }

        public string content_text { get; set; }

        [Required]
        public DateTime full_time { get; set; }

        [Required]
        public int user_id { set; get; }

        [Required]
        virtual public User user { get; set; }
    }
}
