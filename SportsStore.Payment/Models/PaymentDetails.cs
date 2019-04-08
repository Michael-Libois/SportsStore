﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Payment.Models
{
    public class PaymentDetails
    {
        [Required]
        public string Firstname { get; set; }
        [Required]
        public string Lastname { get; set; }
        [Required]
        public DateTime ExpirationDate { get; set; }
        [Required]
        public int CardNumber { get; set; }
        [Required]
        public int SecurityNumber { get; set; }
    }
}