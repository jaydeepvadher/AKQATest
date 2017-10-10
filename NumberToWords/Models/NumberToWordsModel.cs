using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NumberToWords.Models
{
    public class NumberToWordsModel
    {
        [Required(ErrorMessage = "Name is required.")]
        public string inputName { get; set; }

        [Required(ErrorMessage = "Input Number is required.")]
        [Range(1, double.MaxValue, ErrorMessage = "Only floating numbers are allowed greater than Zero.")]
        [DisplayName("Number")]    
        public double inputNumber { get; set; }
    }
}