using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Product:BaseEntity
    {
        [Required]
        [MaxLength(250)]
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal? Discount { get; set; }
        public string Description { get; set; }
        public decimal Rating { get; set; }
        public int Quantity { get; set; }
        public string SKU { get; set; }
        public int ThumbnailPictureId { get; set; }
        public int CategoryId { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public Category Category { get; set; }
    }
}
