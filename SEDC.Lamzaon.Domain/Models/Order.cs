using SEDC.Lamzaon.Domain.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SEDC.Lamzaon.Domain.Models
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public StatusType Status { get; set; }

        public bool Paid { get; set; }

        public int UserId { get; set; }

        public virtual User User  { get; set; }

        public virtual IEnumerable <OrderProduct> ProductOrders { get; set; }
        
    }
}
