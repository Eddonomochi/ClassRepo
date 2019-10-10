using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace MVCValidationAHBCJuly2019.Models
{
    public class TaxCalculatorViewModel
    {
        [Range(1_000, 2_000)]
        public double SubTotal { get; set; }

        [StringLength(1)]
        [RegularExpression(@"\w{1,10}\s+\w{1,10}")]
        public string Name { get; set; }
    }
}
