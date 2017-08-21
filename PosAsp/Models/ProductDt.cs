using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PosAsp.Models
{
    public class ProductDt
    {
        public int ProductDtID { get; set; }
        [Required, MaxLength(10)]
        public string ProductSize { get; set; }
        [Required]
        public int ProductQty { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
        [Required]
        public DateTime UpdDate { get; set; }
        [Required]
        public string UpdatedBy { get; set; }

        // Foreign Key definition
        public int ProductHdID { get; set; }
        public int StorageID { get; set; }

        // Relationship definition
        [ForeignKey("ProductHdID")]
        public ProductHd ProductHd { get; set; }
        [ForeignKey("StorageID")]
        public Storage Storage { get; set; }
        public ICollection<StockAdjust> StockAdjusts { get; set; }
    }
}