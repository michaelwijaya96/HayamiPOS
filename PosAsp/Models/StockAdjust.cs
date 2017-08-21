using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PosAsp.Models
{
    public class StockAdjust
    {
        public int StockAdjustID { get; set; }
        [Required]
        public int AdjustQty { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
        [Required]
        public DateTime UpdDate { get; set; }
        [Required, MaxLength(50)]
        public string UpdatedBy { get; set; }

        // Foreign Key
        public int ProductDtID { get; set; }

        // Relationship definition
        [ForeignKey("ProductDtID")]
        public virtual ProductHd ProductHd { get; set; }
    }
}