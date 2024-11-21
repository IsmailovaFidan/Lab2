using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementGroupWork
{
    internal class Subject
    {
        public int SubjectId { get; set; }
        public string Name { get; set; }
        public double SubjectHours { get; set; }

        private Exam midtermList;
        private Exam labaratoryList;
        private Exam presentationPoint;
        private Exam activityPoint;

        private int absentHours;
        private double enterancePoint;

        public Subject(string subjectName, double subjectHours, int labCount)
        {
            SubjectId++;
            Name = subjectName;
            SubjectHours = subjectHours;

            presentationPoint = new Exam("Presentation", 20, 1);
            activityPoint = new Exam("Activity", 10, 1);

            midtermList = new Midterm();
            labaratoryList = new Labaratory(labCount);
        }


        public void AddMidtermPoint(int point)
        {
            midtermList.AddPoint(point);
        }

        public double GetFinalMidtermScore()
        {
            return midtermList.GetFinalScoreForExamList();
        }

        public void AddLaboratoryPoint(int point)
        {
            labaratoryList.AddPoint(point);
        }

        public double GetFinalLaboratoryScore()
        {
            return labaratoryList.GetFinalScoreForExamList();
        }

        public void AddPresentationPoint(int value)
        {
            try
            {
                if (value >= 0 && value <= 10)
                {
                    presentationPoint.Point = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Invalid presentation point");
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

        public double GetPresentationPoint()
        {
            return presentationPoint.Point;
        }

        public void AddActivityPoint(int value)
        {
            try
            {
                if (value >= 0 && value <= 10)
                {
                    activityPoint.Point = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Invalid presentation point");
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

        public double GetActivityPoint()
        {
            return activityPoint.Point;
        }

        // absent count add
        public int IsAbsent()
        {
            absentHours += 2;

            return absentHours / 2;
        }

        private bool CheckLimit()
        {
            if ((SubjectHours / 2) * 0.25 <= absentHours)
            {
                return true;
            }
            return false;
        }

        public double EnterancePointCalculator()
        {
            try
            {
                enterancePoint = GetFinalMidtermScore() + GetFinalLaboratoryScore() + presentationPoint.Point + activityPoint.Point;

                if (CheckLimit())
                {
                    throw new Exception("Subject failed");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("You are on the limit. You cannot enter the exam!");
            }
            return enterancePoint;
        }
    }
}
