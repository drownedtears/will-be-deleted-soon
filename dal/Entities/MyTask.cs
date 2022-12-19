using dal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dal
{
    [Table("MyTask")]
    public partial class MyTask
    {
        [Key]
        public int task_id { get; set; }

        [Required]
        [StringLength(50)]
        public string type { get; set; }

        [Required]
        [StringLength(50)]
        public string header { get; set; }

        public string content_text { get; set; }

        [Required]
        [StringLength(50)]
        public string condition { get; set; }

        [Required]
        public DateTime cre_date { get; set; }

        public DateTime? finish_date { get; set; }

        [Required]
        public int user_id { get; set; }

        public DateTime? dead_line { get; set; }

        public int? days_to_finish { get; set; }

        public int? sleep { get; set; }
       
        public int? stat_id { get; set; }

        public int? group_id { get; set; }

        public int? reminder_id { get; set; }

        public virtual Stat stat { get; set; }
        public virtual Group group { get; set; }
        [Required]
        public virtual User user { get; set; }

        public virtual Reminder reminder { get; set; }
    }
}
