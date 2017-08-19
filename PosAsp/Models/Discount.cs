using System;
using System.ComponentModel.DataAnnotations;

namespace PosAsp.Models
{
    public class Discount
    {
        public int DiscountID { get; set; }
        //public int CustomerID { get; set; } foreign key
        [Required]
        public int DiscDivide { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdDate { get; set; }

        [Required, MaxLength(50)]
        public string UpdatedBy { get; set; }
        
    }
}