using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class BlogCategory : BaseEntity
    {
        [Required]
        [MaxLength(200)]
        public string Name { get; set; }
    }
}
