using Latest_Assignment;
public delegate void Hellodelegate(string message);

public  class Program
{
    private static void Main(string[] args)//method
    {
        List<Students> studentslist = new List<Students>();

        studentslist.Add(new Students() { StudentId = 1, StudentName = "Johnson", StudentAge = 15, StudentSchoolfees = 80000 });
        studentslist.Add(new Students() { StudentId = 2, StudentName = "Mary", StudentAge = 13, StudentSchoolfees = 50000 });
        studentslist.Add(new Students() { StudentId = 3, StudentName = "Jamal", StudentAge = 5, StudentSchoolfees = 60000 });
        studentslist.Add(new Students() { StudentId = 4, StudentName = "Precious", StudentAge = 7, StudentSchoolfees = 10000 });
        studentslist.Add(new Students() { StudentId = 5, StudentName = "Ngozi", StudentAge = 18, StudentSchoolfees = 70000 });
        studentslist.Add(new Students() { StudentId = 6, StudentName = "Jenevieve", StudentAge = 17, StudentSchoolfees = 30000 });
        studentslist.Add(new Students() { StudentId = 7, StudentName = "Sarah", StudentAge = 10, StudentSchoolfees = 40000 });
        studentslist.Add(new Students() { StudentId = 8, StudentName = "Samuel", StudentAge = 16, StudentSchoolfees = 65000 });
        studentslist.Add(new Students() { StudentId = 9, StudentName = "Best", StudentAge = 14, StudentSchoolfees = 78000 });
        studentslist.Add(new Students() { StudentId = 10, StudentName = "Praise", StudentAge = 12, StudentSchoolfees = 87000 });
  
        foreach (var student in studentslist) 
        {
            Console.WriteLine(student.StudentName + student.StudentAge);
        }
    }
   
 

}