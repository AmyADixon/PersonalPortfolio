using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonalPortfolio.Models {
    public class CommentDBHelper {

        internal static List<VisitorComments> getAllComments(CommentContext _db) {
            return (from c in _db.Response
                    select c).ToList();
        }

        internal static void addComment(CommentContext _db, VisitorComments comment) {
            _db.Response.Add(comment);
            _db.SaveChanges();
        }
    }
}