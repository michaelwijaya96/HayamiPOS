﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PosAsp.Models
{
    public class Storage
    {
        public int StorageID { get; set; }
        [Required, MaxLength(60)]
        public string StorageName { get; set; }
        [Required]
        public int StorageCapacity { get; set; }
        public int StorageStock { get; set; }
        public int StoragePrior { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
        [Required]
        public DateTime UpdDate { get; set; }
        [Required, MaxLength(50)]
        public string UpdatedBy { get; set; }

        // Relationship definition
        public ICollection<ProductDt> ProductDts { get; set; }
    }
}