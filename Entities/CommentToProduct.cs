using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class CommentToProduct :  BaseEntity
    {
        public int ProductID { get; set; }
        public virtual Product Product { get; set; }
        public int CommentID { get; set; }
        public virtual Comment Comment { get; set; }
        public string UserID { get; set; }
    }
}
