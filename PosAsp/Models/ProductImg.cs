using System;
using System.ComponentModel.DataAnnotations;

namespace PosAsp.Models
{
    public class ProductImg
    {
        public int ProductImgID { get; set; }
        //public int ProductHdID { get; set; } foreign key
        [Required, MaxLength(5)]
        public string ImgExt { get; set; }
        [Required, MaxLength(100)]
        public string ImgName { get; set; }
        [Required, MaxLength(255)]
        public string ImgPath { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdDate { get; set; }

        [Required, MaxLength(50)]
        public string UpdatedBy { get; set; }

    }
}