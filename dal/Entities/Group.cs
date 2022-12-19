using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dal
{

    [Table("Group")]
    public partial class Group
    {

        [Key]
        public int group_id { get; set; }

        [Required]
        [StringLength(50)]
        public string name { get; set; }

        public string content_text { get; set; }

        [Required]
        //[ForeignKey(nameof(User))]
        public int user_id { get; set; }

        public string color { set; get; }

        [Required]
        virtual public User user { get; set; }

    }
}
