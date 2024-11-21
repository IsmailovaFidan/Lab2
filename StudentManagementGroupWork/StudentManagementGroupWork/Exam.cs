using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementGroupWork
{
    class Exam
    {
        private int id;
        private string title;
        private int point;
        private int maxPoint;
        private int examCount;
        protected List<int> examList;

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }

        public int Point
        {
            get
            {
                return point;
            }
            set
            {
                try
                {
                    if (point >= 0 && point <= maxPoint)
                    {
                        point = value;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        public int MaxPoint
        {
            get
            {
                return maxPoint;
            }
            set
            {
                maxPoint = value;
            }
        }
        public int ExamCount
        {
            get
            {
                return examCount;
            }
            set
            {
                examCount = value;
            }
        }

        public Exam(string title, int maxPoint, int examCount)
        {
            id++;
            Title = title;
            MaxPoint = maxPoint;
            ExamCount = examCount;
        }

        public void AddPoint(int point)
        {
            if (examList.Count < examCount)
            {
                examList.Add(point);
            }
        }

        public double GetFinalScoreForExamList()
        {
            double sum = 0;
            for (int i = 0; i < examList.Count; i++)
            {
                sum += examList[i];
            }
            return sum / examCount;
        }
    }
}
