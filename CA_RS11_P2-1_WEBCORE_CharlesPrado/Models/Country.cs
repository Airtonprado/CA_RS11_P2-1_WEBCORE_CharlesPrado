using System.ComponentModel.DataAnnotations;
namespace CA_RS11_P2_1_WEBCORE_CharlesPrado.Models
{
    public class Country
    {
        [Key]
        public int CountryId { get; set; }

        [Required]
        [MaxLength(50)]
        public string CountryName { get; set; } = null!;

        public virtual ICollection<City>? City { get; set; } = new HashSet<City>();
        // Coleção de Customers (se bidirecional)
        
    }
}