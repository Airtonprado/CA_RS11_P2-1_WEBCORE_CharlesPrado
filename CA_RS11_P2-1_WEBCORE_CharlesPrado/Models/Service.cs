using System.ComponentModel.DataAnnotations;
using System.Net;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace CA_RS11_P2_1_WEBCORE_CharlesPrado.Models
{
    public class Service
    {

        //TODO ACP: TABLE Service
        #region Properties
        public Service()
        {
            Payments = new HashSet<Payment>();
        }

        [Key]
        public int ServiceId { get; set; }

        [Required]
        [MaxLength(50)]
        public string ServiceName { get; set; } = null!;

        [Required]
        public DateTime PaymentDate { get; set; }

        [Required]
        public decimal Value { get; set; }

        [Required]
        [MaxLength(10)]
        public string PaymentTerm { get; set; } = null!;

        [Required]
        public DateTime ExpiryDate { get; set; }

        public DateTime? EndDate { get; set; }

        /// Foreign Key for Plan
        public int? PlanId { get; set; }  // Permitir valores nulos
        public virtual Plan? Plan { get; set; }

        // Foreign Key for Status
        public int? StatusId { get; set; }  // Permitir valores nulos
        public virtual Status? Status { get; set; }

        // Navigation property for Payments
        public virtual ICollection<Payment>? Payments { get; set; }
        #endregion
        public Service(string serviceName, DateTime paymentDate, decimal value, string paymentTerm, DateTime expiryDate, int planId, int statusId)
        {
            ServiceName = serviceName;
            PaymentDate = paymentDate;
            Value = value;
            PaymentTerm = paymentTerm;
            ExpiryDate = expiryDate;
            PlanId = planId;
            StatusId = statusId;
            Payments = new HashSet<Payment>();
        }
    }
}
