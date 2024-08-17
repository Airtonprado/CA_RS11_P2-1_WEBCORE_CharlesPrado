using CA_RS11_P2_1_WEBCORE_CharlesPrado.Models;
using System.ComponentModel.DataAnnotations;

namespace CA_RS11_P2_1_WEBCORE_CharlesPrado.Models
{
    public class Plan
    {

        //TODO ACP: TABLE Plan
        #region Properties
        public Plan()
        {
            Customers = new HashSet<Customer>();
            Services = new HashSet<Service>();
        }

        [Key]
        public int PlanId { get; set; }

        [Required]
        [MaxLength(50)]
        public string PlanName { get; set; } = null!;

        // Navigation properties
        public virtual ICollection<Customer>? Customers { get; set; }
        public virtual ICollection<Service>? Services { get; set; }
        #endregion
    }
}
