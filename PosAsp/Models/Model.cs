using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PosAsp.Models
{
    public class Model
    {
        public int ModelID { get; set; }
        [Required, MaxLength(60)]
        public string ModelName { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
        [Required]
        public DateTime UpdDate { get; set; }
        [Required, MaxLength(50)]
        public string UpdatedBy { get; set; }

        // Relationship definition
        public ICollection<ProductHd> ProductHds { get; set; }
    }
}