namespace StudentManagementGroupWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(1, "Aphar", "Magaramova", "ITIF", "Information Technology");
            student.AddSubject(new Subject("Programming", 60, 5));
            student.AddMidtermToSubject("Programming", 20);
            student.AddMidtermToSubject("Programming", 11);
            student.AddMidtermToSubject("Programming", 17);
            double finalMid = student.GetFinalMidtermScoreForSubject("Programming");
            Console.WriteLine($"Final Midterm Point is {finalMid}");

            student.AddLabToSubject("Programming", 9);
            student.AddLabToSubject("Programming", 5);
            student.AddLabToSubject("Programming", 7);
            student.AddLabToSubject("Programming", 10);
            student.AddLabToSubject("Programming", 7);
            double finalLab = student.GetFinalLabScoreForSubject("Programming");
            Console.WriteLine($"Final Labaratory Point is {finalLab}");

            student.AddActicityPointToSubject("Programming", 10);
            student.AddPresentationPointToSubject("Programming", 8);

            student.AddAbsentToSubject("Programming");
            student.AddAbsentToSubject("Programming");
            student.AddAbsentToSubject("Programming");

            double enterancePoint = student.GetEnterancePointForSubject("Programming");
            Console.WriteLine($"Enterance point is {enterancePoint}");
        }
    }
}