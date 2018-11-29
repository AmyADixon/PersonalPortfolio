using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PersonalPortfolio.Models {
    public class VisitorComments {
        [Key]
        public int CommentID { get; set; }

        [Required]
        [StringLength(40)]
        public string Name { get; set; }

        [Required]
        [StringLength(280)] // Same length as new twitter posts
        public string Comment { get; set; }
    }
}