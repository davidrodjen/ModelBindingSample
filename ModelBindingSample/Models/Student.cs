using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModelBindingSample.Models
{
    public class Student
    {
        //Prop is keyword to auto
        public int StudentId { get; set; }

        public string FullName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public int FavoriteNumber { get; set; }

    }
}
