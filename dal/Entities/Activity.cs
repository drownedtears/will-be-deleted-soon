using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dal
{
    [Table("UserActivity")]
    public partial class Activity
    {
        [Key]
        public int activity_id { get; set; }

        [Required]
        public int user_id { get; set; }

        [Required]
        public string task_name { get; set; }

        [Required]
        public DateTime finish_date { get; set; }

        [Required]
        public string event_name { get; set; }

        [Required]
        public virtual User user { get; set; }
    }
}
