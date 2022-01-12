using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Blog:BaseEntity
    {
        [Required]
        [MaxLength(250)]
        public string Header { get; set; }
        public string Description { get; set; }
        public string PhotoUrl { get; set; }
        public int BlogCategoryID { get; set; }
        public DateTime Createdate { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public virtual BlogCategory BlogCategory { get; set; }
    }
}
