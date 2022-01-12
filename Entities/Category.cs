using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Category:BaseEntity
    {
        [Required]
        [MaxLength(250)]
        public string Name { get; set; }

        [MaxLength(800)]
        public string CategoryPhoto { get; set; }
    }
}
