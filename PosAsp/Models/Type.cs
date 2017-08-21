using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PosAsp.Models
{
    public class Type
    {
        public int TypeID { get; set; }
        [Required, MaxLength(60)]
        public string TypeName { get; set; }
        public decimal TypePrice { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
        [Required]
        public DateTime UpdDate { get; set; }
        [Required, MaxLength(50)]
        public string UpdatedBy { get; set; }

        // Relationship definition
        public virtual ICollection<ProductHd> ProductHds { get; set; }
    }
}