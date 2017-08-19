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

        //public int TypeID { get; set; } Foreign Key
        //public int ModelID { get; set; } Foreign Key
        
        public DateTime CreatedAt { get; set; }
        public DateTime UpdDate { get; set; }

        [Required, MaxLength(50)]
        public string UpdatedBy { get; set; }
    }
}