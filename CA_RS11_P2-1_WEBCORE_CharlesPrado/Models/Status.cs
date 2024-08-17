using System.ComponentModel.DataAnnotations;

namespace CA_RS11_P2_1_WEBCORE_CharlesPrado.Models
{
    public class Status
    {

        //TODO ACP: TABLE Status
        #region Properties
        public Status()
        {
            Services = new HashSet<Service>();
        }

        [Key]
        public int StatusId { get; set; }

        [Required]
        [MaxLength(20)]
        public string StatusName { get; set; } = null!;

        // Navigation property for Services
        public virtual ICollection<Service>? Services { get; set; }
        #endregion
    }
}
