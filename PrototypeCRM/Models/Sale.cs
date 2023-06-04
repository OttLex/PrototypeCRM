using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeCRM.Models
{
    public class Sale
    {
        [Key]
        public int Id { get; set; }

        public int? ProductId { get; set; }
        [Required]
        public Product Product { get; set; }

        public int? ClientId { get; set; }
        [Required]
        public Client Client { get; set; }

        public int? EmployerId { get; set; }
        [Required]
        public Employer Employer{ get; set; }
    }
}
