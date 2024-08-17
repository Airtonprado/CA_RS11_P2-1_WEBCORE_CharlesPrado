using CA_RS11_P2_1_WEBCORE_CharlesPrado.Models;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;

namespace CA_RS11_P2_1_WEBCORE_CharlesPrado.Models
{
    public class City
    {
        //TODO ACP: TABLE City
        #region Properties
        

        [Key]
        public int CityId { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        // Foreign Key for Country
        public int? CountryId { get; set; }  // Permitir valores nulos
        public virtual Country? Country { get; set; }

        // Navigation property for Customers
        public virtual ICollection<Customer>? Customer { get; set; }
        #endregion
    }
}
