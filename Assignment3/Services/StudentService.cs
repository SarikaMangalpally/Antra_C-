using Assignment3.Repository;

namespace Assignment3.Services;

public class StudentService : PersonService, IStudentRepository
{
    private static List<Student> _students = new List<Student>();
   
    public static List<Student> GetAll()
    {
        return _students;
    }
}