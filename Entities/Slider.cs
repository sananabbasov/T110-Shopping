using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Slider:BaseEntity
    {
        [Required]
        [MaxLength(200)]
        public string Header { get; set; }
        [MaxLength(200)]
        public string SubHeader { get; set; }
        [MaxLength(300)]
        public string Description { get; set; }
        public string PhotoUrl { get; set; }
        public string SliderLink { get; set; }

    }
}
