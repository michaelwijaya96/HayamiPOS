using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PosAsp.Models
{
    public class User
    {
        public int UserID { get; set; }

        [Required, MaxLength(50), Display(Name = "User Name")]
        public string UserName { get; set; }

        [Required, MaxLength(100), Display(Name = "Password")]
        public string UserPassword { get; set; }

        [Index(IsUnique = true)]
        [Required, MaxLength(50), Display(Name = "Email")]
        public string UserEmail { get; set; }

        [MaxLength(1)]
        public string UserRole { get; set; }

        [MaxLength(100)]
        public string UserImg { get; set; }

        [MaxLength(30)]
        public string UserToken { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdDate { get; set; }
    }
}