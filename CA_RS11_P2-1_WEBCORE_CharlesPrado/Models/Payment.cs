using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CA_RS11_P2_1_WEBCORE_CharlesPrado.Models
{

    public class Payment
    {
        [Key]
        public int PaymentId { get; set; } 
        public DateTime PaymentDate { get; set; } 
        public decimal AmountPaid { get; set; } 
        public string PaymentMethod { get; set; } = string.Empty;

        public int? CustomerId { get; set; } = null!; // Permitir nulos
        public Customer? Customer { get; set; } = null!;

        public int? ServiceId { get; set; } = null!; // Permitir nulos
        public Service? Service { get; set; } = null!;
        
    }




}
