using System;
using System.ComponentModel.DataAnnotations;

namespace PosAsp.Models
{
    public class ProductHd
    {
        public int ProductHdID { get; set; }
        [Required, MaxLength(40)]
        public string ProductCode { get; set; }
        [Required, MaxLength(60)]
        public string ProductName { get; set; }
        [Required, MaxLength(255)]
        public string ProductDesc { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
        [Required]
        public DateTime UpdDate { get; set; }
        [Required]
        public string UpdatedBy { get; set; }

        //Foreign key definition
        public virtual Type Type { get; set; }
        public virtual Model Model { get; set; }
    }
}