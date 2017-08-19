using System;
using System.ComponentModel.DataAnnotations;

namespace PosAsp.Models
{
    public class Model
    {
        public int ModelID { get; set; }
        [Required, MaxLength(60)]
        public string ModelName { get; set; }
        
        public DateTime CreatedAt { get; set; }
        public DateTime UpdDate { get; set; }
        [Required, MaxLength(50)]
        public string UpdatedBy { get; set; }
    }
}