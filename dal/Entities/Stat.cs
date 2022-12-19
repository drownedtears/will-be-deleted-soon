using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dal
{
    [Table("Stat")]
    public partial class Stat
    {

        [Key]
        public int stat_id { get; set; }

        [Required]
        public DateTime start_date { get; set; }

        [Required]
        public DateTime finish_date { get; set; }

        [Required]
        [StringLength(50)]
        public string condition { get; set; }

        [Required]
        public virtual MyTask task { get; set; }
        
    }
}
