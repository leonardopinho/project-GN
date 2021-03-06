namespace project_gn.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CompanySize")]
    public class CompanySize
    {
        public int Id { get; set; }

        [StringLength(30)]
        public string Type { get; set; }

        public virtual ICollection<Customer> Customer { get; set; }
    }
}
