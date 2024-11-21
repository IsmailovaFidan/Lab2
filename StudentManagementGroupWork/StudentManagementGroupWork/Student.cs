using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StudentManagementGroupWork
{
    internal class Student
    {
        public StudentProfile StudentProfile { get; set; }
        private List<Subject> Subjects;

        public Student(int id, string name, string surname, string faculty, string speciality)
        {
            StudentProfile = new StudentProfile(id, name, surname, faculty, speciality);

            Subjects = new List<Subject>();
        }

        public void AddSubject(Subject newSubject)
        {
            Subjects.Add(newSubject);
        }

        public void RemoveSubject(Subject deleteSubject)
        {
            foreach (Subject subject in Subjects)
            {
                if (subject.SubjectId == deleteSubject.SubjectId)
                {
                    Subjects.Remove(subject);
                    break;
                }
            }
        }

        private Subject FindSubject(string subjectName)
        {
            foreach (Subject subject in Subjects)
            {
                if (subject.Name == subjectName)
                {
                    return subject;
                }
            }
            return null;
        }

        // show subjects method 

        public void AddMidtermToSubject(string subjectName, int score)
        {
            Subject subject = FindSubject(subjectName);
            if (subject != null)
            {
                subject.AddMidtermPoint(score);
            }
        }

        public double GetFinalMidtermScoreForSubject(string subjectName)
        {
            Subject subject = FindSubject(subjectName);
            if (subject != null)
            {
                return subject.GetFinalMidtermScore();
            }

            return 0;
        }

        public void AddLabToSubject(string subjectName, int score)
        {
            Subject subject = FindSubject(subjectName);
            if (subject != null)
            {
                subject.AddLaboratoryPoint(score);
            }
        }

        public double GetFinalLabScoreForSubject(string subjectName)
        {
            Subject subject = FindSubject(subjectName);
            if (subject != null)
            {
                return subject.GetFinalLaboratoryScore();
            }

            return 0;
        }

        //presentation and activity
        public void AddPresentationPointToSubject(string subjectName, int score)
        {
            Subject subject = FindSubject(subjectName);
            if (subject != null)
            {
                subject.AddPresentationPoint(score);
            }
        }

        public double GetPresentationPointForSubject(string subjectName)
        {
            Subject subject = FindSubject(subjectName);
            if (subject != null)
            {
                return subject.GetPresentationPoint();
            }

            return 0;
        }

        public void AddActicityPointToSubject(string subjectName, int score)
        {
            Subject subject = FindSubject(subjectName);
            if (subject != null)
            {
                subject.AddActivityPoint(score);
            }
        }

        public double GetActivityPointForSubject(string subjectName)
        {
            Subject subject = FindSubject(subjectName);
            if (subject != null)
            {
                return subject.GetActivityPoint();
            }

            return 0;
        }

        public double GetEnterancePointForSubject(string subjectName)
        {
            Subject subject = FindSubject(subjectName);
            if (subject != null)
            {
                return subject.EnterancePointCalculator();
            }

            return 0;
        }

        // absent or not 
        public int AddAbsentToSubject(string subjectName)
        {
            Subject subject = FindSubject(subjectName);
            if (subject != null)
            {
                return subject.IsAbsent();
            }
            return 0;
        }

    }
}