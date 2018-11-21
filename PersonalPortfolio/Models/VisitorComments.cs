using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PersonalPortfolio.Models {
    public class VisitorComments {
        [Key]
        public int CommentID { get; set; }

        [StringLength(40)]
        public string Name { get; set; }

        [StringLength(280)]
        public string Comment { get; set; }

        public IEnumerable<VisitorComments> GetAllComments() {
            // TO DO: return a list of comment objects from the DB
            // QUESTION: Should this method be private?

            return new List<VisitorComments>();
        }

        public void Add(int id) {
            // TO DO: Finish method so that item can be added to DB by visitors
            // TO DO: Since comments cannot be altered and only deleted by authorized,
            // produce popup tht warns visitor to double check their work
            // QUESTION: Should this method be private?
        }

        public void Delete(int id) {
            // TO DO: Finish method so that item can be deleted from DB by authorized
            // QUESTION: Should this method be private?
        }
    }
}