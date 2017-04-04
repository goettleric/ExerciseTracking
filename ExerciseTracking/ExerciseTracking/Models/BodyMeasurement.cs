using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExerciseTracking.Models
{
    public class BodyMeasurement
    {
        [Key]
        public int measurementNum { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime dateOfMeasurement { get; set; }
        [Required]
        [Range(1,800)]
        public double bodyWeight { get; set; }
        [Required]
        [Range(1, 108)]
        public double heightInches { get; set; }
        [Range(1, 120)]
        public double waistCircumInches { get; set; }
        [Range(1, 120)]
        public double upperLegCircumInches { get; set; }

    }
}