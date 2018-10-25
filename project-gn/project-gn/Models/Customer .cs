using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace project_gn.Models
{
    [Table("Customer")]
    public class Customer
    {
        [Key]
        [Column("Id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "Informar o nome do cliente.")]
        public string Name { get; set; }

        [Required]
        [Column("id_company_size")]
        public int IdCompanySize { get; set; }

        [ForeignKey("IdCompanySize")]
        public virtual CompanySize CompanySize { get; set; }
    }
}