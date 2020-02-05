using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fuga.Model;
using Fuga.Repository.Infrasturecture;

namespace Fuga.Service
{
    public class StudentService : IStudentService
    {

        private IUnitOfWork _unitOfWork = null;

        public StudentService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }
        public void CreateStudent(Student student)
        {
            _unitOfWork.Repository<Student>().Insert(student);
            _unitOfWork.SaveChanges();
        }

        public void DeleteStudent(int studentID)
        {
            _unitOfWork.Repository<Student>().Delete(studentID);
            _unitOfWork.SaveChanges();
        }

        public List<Student> GetAllStudents()
        {
            return _unitOfWork.Student<Student>().GetStudentAll().ToList();
        }

        public Student GetStudentByID(int studentID)
        {
            return _unitOfWork.Repository<Student>().GetByID(studentID);
        }

        public void UpdateStudent(Student student)
        {
            _unitOfWork.Repository<Student>().Update(student);
        }
    }
}
