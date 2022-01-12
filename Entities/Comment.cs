using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Comment: BaseEntity
    {
        [MaxLength(300)]
        public string Content { get; set; }
        public DateTime CreateDate { get; set; }

    }
}
