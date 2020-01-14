using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ModelBindingSample.Models
{
    public class Student
    {
        //Prop is keyword to auto
        public int StudentId { get; set; }

        [Display(Name = "Full Name")] //have to add using System.ComponentModel.DataAnnotations
        [Required(ErrorMessage = "Full Name is required")] //If not passing anything, don't have to have ()
        public string FullName { get; set; }

        [Display(Name = "DOB")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Display(Name = "Favorite Number")] //These are all Data Annotations
        [Range(1, 100, ErrorMessage = "Choose between 1 and 100")]
        [Required] // int is always required because it is a value type
        public int FavoriteNumber { get; set; } //ints are required by default

    }
}
