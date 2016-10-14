using System;
using System.Collections.Generic;
using Microsoft.Win32;

namespace EFTutorial
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public byte[] Image { get; set; }
        public decimal? Height { get; set; }
        public float? Weight { get; set; }

        public int? StandardId { get; set; }
        public Standard Standard { get; set; }
        public int? TeacherId { get; set; }
        public Teacher Teacher { get; set; }

        public virtual StudentAddress Address { get; set; }

        public ICollection<Course> Courses { get; set; }
    }
}