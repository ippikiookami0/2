﻿using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace FizzBuzzWeb.Forms
{
    public class FizzBuzzForm
    {
        [Display(Name = "Twój szczęśliwy numerek")]
        [Required (ErrorMessage = "Pole jest obowiązkowe"), Range(1, 1000, ErrorMessage = "Oczekiwana wartość {0} z zakresu {1} i {2}.")]
        public int? Number { get; set; }
    }
}
