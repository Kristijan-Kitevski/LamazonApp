using SEDC.Lamzaon.Domain.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SEDC.Lamzaon.Domain.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public string Descriptiopn { get; set; }
        [Required]
        public double Price { get; set; }

        public CategoryType Category { get; set; }

        public virtual IEnumerable<OrderProduct> OrderProduct { get; set; }
    }
}
