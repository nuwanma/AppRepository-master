using Fuga.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuga.Service
{
    public interface IStudentService
    {
        List<Student> GetAllStudents();
        Student GetStudentByID(int studentID);
        void CreateStudent(Student student);
        void UpdateStudent(Student student);
        void DeleteStudent(int studentID);
    }
}
