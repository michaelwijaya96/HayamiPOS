using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PosAsp.Models
{
    public class User
    {
        public int UserID { get; set; }
        [Required, MaxLength(50)]
        public string UserName { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
    }
}