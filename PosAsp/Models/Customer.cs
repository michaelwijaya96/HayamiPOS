using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PosAsp.Models
{
    public class Customer
    {
        public Customer()
        {
            Counters = new List<Counter>();
        }

        public int CustomerID { get; set; }
        [Required, MaxLength(40)]
        public string CustCode { get; set; }
        [Required, MaxLength(60)]
        public string CustName { get; set; }
        [MaxLength(255)]
        public string CustAddr { get; set; }
        [MaxLength(255)]
        public string CustCity { get; set; }
        [MaxLength(10)]
        public string CustPosCode { get; set; }
        [MaxLength(20)]
        public string CustPhone { get; set; }
        [MaxLength(50)]
        public string CustEmail { get; set; }
        [MaxLength(255)]
        public string CustExp { get; set; }
        [MaxLength(255)]
        public string CustDesc { get; set; }
        
        [Required]
        public DateTime CreatedAt { get; set; }
        [Required]
        public DateTime UpdDate { get; set; }
        [Required, MaxLength(50)]
        public string UpdatedBy { get; set; }

        public ICollection<Counter> Counters { get; set; }
    }
}