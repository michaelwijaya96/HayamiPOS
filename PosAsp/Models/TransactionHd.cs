using System;
using System.ComponentModel.DataAnnotations;

namespace PosAsp.Models
{
    public class TransactionHd
    {
        public int TransHdID { get; set; }
        //public int CounterID { get; set; } foreign key
        [Required, MaxLength(25)]
        public string TransNo { get; set; }
        [Required]
        public DateTime TransDate { get; set; }
        [Required, MaxLength(1)]
        public string FgStatus { get; set; }

        public decimal TotalDiscount { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdDate { get; set; }

        [Required, MaxLength(50)]
        public string UpdatedBy { get; set; }
        
    }
}