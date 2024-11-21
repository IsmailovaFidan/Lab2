using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementGroupWork
{
    class Labaratory : Exam
    {
        public Labaratory(int labCount) : base("Laboratory", 10, labCount)
        {
            if (labCount > 1)
            {
                examList = new List<int>(labCount);
            }
        }
    }
}
