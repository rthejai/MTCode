using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Student : Person
    {
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }

		public int? CreditsEarned { get; set; }
	
		[Range(0.70, 4.00)]
		[DisplayFormat(DataFormatString = "{0:#.##}", ApplyFormatInEditMode = true)]
		public double? Gpa { get; set; } 
    }
}