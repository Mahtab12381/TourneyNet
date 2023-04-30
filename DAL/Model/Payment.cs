using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Payment
    {
        [Key]
        public int payment_id { get; set; }
        public float amount_paid { get; set; }
        public DateTime payment_date { get; set; }
    }
}
