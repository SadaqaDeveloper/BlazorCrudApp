using System.ComponentModel.DataAnnotations;

namespace BlazorCrudApp.Data.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required, StringLength(120)]
        public string Name { get; set; } = string.Empty;

        [Range(0, 1000000)]
        public decimal Price { get; set; }

        public int Stock {  get; set; }

        public DateTime CreatedAtUtc { get; set; } = DateTime.UtcNow;
    }
}
