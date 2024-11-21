using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementGroupWork
{
    class Midterm : Exam
    {
        public Midterm() : base("Midterm", 20, 3)
        {
            examList = new List<int>(3);
        }
    }
}
