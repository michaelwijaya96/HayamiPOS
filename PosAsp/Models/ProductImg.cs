using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PosAsp.Models
{
    public class ProductImg
    {
        public int ProductImgID { get; set; }
        [Required, MaxLength(5)]
        public string ImgExt { get; set; }
        [Required, MaxLength(100)]
        public string ImgName { get; set; }
        [Required, MaxLength(255)]
        public string ImgPath { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
        [Required]
        public DateTime UpdDate { get; set; }
        [Required, MaxLength(50)]
        public string UpdatedBy { get; set; }

        // Foreign Key definition
        public int ProductHdID { get; set; }

        // Relationship definition
        [ForeignKey("ProductHdID")]
        public virtual ProductHd ProductHd { get; set; }
    }
}