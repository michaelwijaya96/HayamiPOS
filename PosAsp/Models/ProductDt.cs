using System;
using System.ComponentModel.DataAnnotations;

namespace PosAsp.Models
{
    public class ProductDt
    {
        public int ProductDtID { get; set; }

        //public int ProductHdID { get; set; } Foreign Key
        [Required, MaxLength(10)]
        public string ProductSize { get; set; }

        //public int StorageID { get; set; } Foreign Key
        [Required]
        public int ProductQty { get; set; }
        

        public DateTime CreatedAt { get; set; }
        public DateTime UpdDate { get; set; }

        [Required, MaxLength(50)]
        public string UpdatedBy { get; set; }
    }
}