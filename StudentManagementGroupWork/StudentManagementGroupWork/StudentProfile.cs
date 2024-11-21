using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementGroupWork
{
    class StudentProfile
    {
        public StudentProfile(int id, string name, string surname, string faculty, string speciality)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Faculty = faculty;
            Speciality = speciality;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string GroupNumber { get; set; }
        public int Age { get; set; }
        public DateTime AdmissionDate { get; set; }
        public DateTime GraduationDate { get; set; }
        public string Faculty { get; set; }
        public string Speciality { get; set; }
    }
}
