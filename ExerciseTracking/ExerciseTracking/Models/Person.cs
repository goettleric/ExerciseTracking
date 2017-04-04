using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExerciseTracking.Models
{
    public class Person
    {
        [Key]
        public int personalID { get; set; }
        [Required]
        [StringLength(25, MinimumLength = 1, ErrorMessage ="Must be between 1 and 25 characters.")]
        public string FName { get; set; }
        [StringLength(4, MinimumLength = 1)]
        public string MInitial { get; set; }
        [Required]
        [StringLength(25, MinimumLength = 1, ErrorMessage = "Must be between 1 and 25 characters.")]
        public string LName { get; set; }
    }
}