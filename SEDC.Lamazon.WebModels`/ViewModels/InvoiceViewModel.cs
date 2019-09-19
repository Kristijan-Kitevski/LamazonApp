using SEDC.Lamazon.WebModels_.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Lamazon.WebModels_.ViewModels
{
    public class InvoiceViewModel
    {
        public int Id { get; set; }

        public StatusTypeViewModel OrderStatus { get; set; }

        public int OrderPrice { get; set; }

        public PaymentTypeViewModel PaymentType { get; set; }



    }
}
