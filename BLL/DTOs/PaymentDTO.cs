using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class PaymentDTO
    {
        public int payment_id { get; set; }
        public float amount_paid { get; set; }
        public DateTime payment_date { get; set; }
    }
}
