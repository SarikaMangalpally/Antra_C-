using Assignment3.Repository;
using Assignment3.Services;

namespace Assignment3.Presentation;

public class ManagePerson
{
            IStudentRepository studentService = new StudentService();
            IInstructorRepository instructorService = new InstructorService();
            CourseService courseService = new CourseService();
            DepartmentService departmentService = new DepartmentService();

            
    
            Instructor instructor = new Instructor
            {
                FirstName = "Jane",
                LastName = "Smith",
                DateOfBirth = new DateTime(1980, 5, 15),
                EmployeeId = "E67890",
                Salary = 50000,
                JoinDate = new DateTime(2010, 1, 1)
            };

            public void AddStudent()
            {
                Student student = new Student
                {
                    FirstName = "John",
                    LastName = "Doe",
                    DateOfBirth = new DateTime(2000, 1, 1),
                    StudentId = "S12345"
                };

            }
            
            public void PrintAllCustomers()
            {
                List<Student> _students = new List<Student>();
                _students = StudentService.GetAll();
                foreach (var student in _students)
                {
                    Console.WriteLine(student);
                }
            }

}