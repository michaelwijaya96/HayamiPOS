using System;
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
        [Required]
        public string UpdatedBy { get; set; }
    }
}