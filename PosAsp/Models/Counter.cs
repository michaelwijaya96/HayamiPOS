using System;
using System.ComponentModel.DataAnnotations;

namespace PosAsp.Models
{
    public class Counter
    {
        public int CounterID { get; set; }
        [Required, MaxLength(50)]
        public string CounterName { get; set; }
        [MaxLength(255)]
        public string CounterAddr { get; set; }
        [MaxLength(255)]
        public string CounterCity { get; set; }
        [MaxLength(255)]
        public string CounterPosCode { get; set; }
        [MaxLength(20)]
        public string CounterPhone { get; set; }
        [MaxLength(50)]
        public string CounterEmail { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
        [Required]
        public DateTime UpdDate { get; set; }
        [Required, MaxLength(50)]
        public string UpdatedBy { get; set; }
    }
}