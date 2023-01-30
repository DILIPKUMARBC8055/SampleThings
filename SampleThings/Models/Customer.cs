﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace SampleThings.Models
{
    public class Customer
    {
        [Key]
        public int CustId { get; set; }

        public string? CustName { get; set; }

        public string? CustAddress { get; set; }
        [Range(1000000000, 9999999999,
            ErrorMessage = "Mobile no should be 10 digits")]
        public string CustPhNo { get; set; }
        [Required]
        [EmailAddress]
        public string CustEmail { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [DefaultValue("Cust@123")]
        public string CustPassword { get; set; }
    }
}
