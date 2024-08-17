using System.ComponentModel.DataAnnotations;
using System.Net;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace CA_RS11_P2_1_WEBCORE_CharlesPrado.Models
{

    public partial class Customer
    { //TODO ACP: TABLE CUSTOMERS
  
        #region Properties
        public Customer()
        {
            Payments = new HashSet<Payment>();
        }

        [Key]
        public int CustomerId { get; set; }

        [Required(ErrorMessage = "First name is required")]
        [StringLength(30, ErrorMessage = "First name max 30 characters")]
        [Column(TypeName = "nvarchar")]
        [Display(Name = "First name")]
        public string FirstName { get; set; } = null!;

        [StringLength(30, ErrorMessage = "First name max 30 characters")]
        [Column(TypeName = "nvarchar")]
        [Display(Name = "Last name")]
        public string LastName { get; set; } = null!;

        [Required]
        [DataType(DataType.Date)]
        public DateTime DateRegistration { get; set; }

        [Required]
        [MaxLength(100)]
        public string Address { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Nif { get; set; }

        [Required]
        [DataType(DataType.Date)]
        //Todo ACP: BirdDate automatic
        public DateTime Birthdate { get; set; }
        public int Age
        {
            get
            {
                return DateTime.Now.Year - Birthdate.Year;
            }
        }

        // Foreign Key for City
        public int? CityId { get; set; }  // Permitir valores nulos
        public virtual City? City { get; set; }

        // Foreign Key for Plan
        public int? PlanId { get; set; }  // Permitir valores nulos
        public virtual Plan? Plan { get; set; }

        // Navigation property for Payments
        public virtual ICollection<Payment>? Payments { get; set; }
        
       
        #endregion

        #region Constructor

        // Construtor parametrizado para inicializar um cliente
        public Customer(string firstName, string lastName, DateTime dateRegistration, string address, string email, string nif, DateTime birthdate, int cityId, int planId)
        {
            FirstName = firstName;
            LastName = lastName;
            DateRegistration = dateRegistration;
            Address = address;
            Email = email;
            Nif = nif;
            Birthdate = birthdate;
            CityId = cityId;
            PlanId = planId;
            Payments = new HashSet<Payment>();
        }

        // Construtor completo: Cliente, Plano, Serviço e Pagamento
        public Customer(string firstName, string lastName, DateTime dateRegistration, string address, string email, string nif, DateTime birthdate, City city, Plan plan, List<Service> services, DateTime paymentDate, decimal paymentValue)
        {
            // Inicializando propriedades do cliente
            FirstName = firstName;
            LastName = lastName;
            DateRegistration = dateRegistration;
            Address = address;
            Email = email;
            Nif = nif;
            Birthdate = birthdate;
            City = city;
            Plan = plan;

            // Definindo os IDs de chaves estrangeiras
            CityId = city.CityId;
            PlanId = plan.PlanId;


        }
       
        #endregion
    }

}

