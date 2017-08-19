using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace PosAsp.Models
{
    public class Type
    {
        public int TypeID { get; set; }
        [Required, MaxLength(60)]
        public string TypeName { get; set; }
        [MaxLength(30)]
        public decimal TypePrice { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdDate { get; set; }
        [Required, MaxLength(50)]
        public string UpdatedBy { get; set; }
    }
}