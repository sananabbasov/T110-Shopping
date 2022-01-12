namespace Entities
{
    public class ProductPhoto : BaseEntity
    {
        public string PhotoUrl { get; set; }

        public int ProductId { get; set; }

        public virtual Product Product { get; set; }
    }
}
