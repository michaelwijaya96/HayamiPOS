using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [Required, MaxLength(50)]
        public string UpdatedBy { get; set; }

        // Foreign key definition
        public int ModelID { get; set; }
        public int TypeID { get; set; }

        // Relationship definition
        [ForeignKey("TypeID")]
        public virtual Type Type { get; set; }
        [ForeignKey("ModelID")]
        public virtual Model Model { get; set; }
        public ICollection<ProductImg> ProductImgs { get; set; }
    }
}