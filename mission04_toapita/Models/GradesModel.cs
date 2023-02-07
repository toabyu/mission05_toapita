using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace mission04_toapita.Models
{
    //I didn't think it would be a good practice to name my view and model the same thing so I renamed this one
    public class GradesModel
    {
        //All fields are required and need to be between 0 and 100.
        //(I guess that means no extra credit. Hopefully this isn't an accurate representaion of the class)
        //Because I LOVE extra credit
        // All fields are doubles since decimal places are technically legal grades

        [Required]
        [Range(0, 100)]
        public double Assignments { get; set; }
        [Required]
        [Range(0, 100)]
        public double Group_Project { get; set; }
        [Required]
        [Range(0, 100)]
        public double Quizzes { get; set; }
        [Required]
        [Range(0, 100)]
        public double Midterm_Exam { get; set; }
        [Required]
        [Range(0, 100)]
        public double Final_Exam { get; set; }
        [Required]
        [Range(0, 100)]
        public double Intex { get; set; }

        //Thanks ASP.NET for doing my getters and setters for me!
    }
}
