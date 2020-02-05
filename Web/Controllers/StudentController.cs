using Fuga.Model;
using Fuga.Repository.Infrasturecture;
using Fuga.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.OData;

namespace Web.Controllers
{
    /// text, gives CS1591
    [EnableQuery]   
    public class StudentController : ApiController
    {
        /// text, gives CS1591
        public StudentController() { }

        private IUnitOfWork _unitOfWork = null;
        private IStudentService _studentService = null;
        /// text, gives CS1591
        public StudentController(IUnitOfWork unitOfWork, IStudentService studentService)
        {
            _unitOfWork = unitOfWork;
            _studentService = studentService;
        }
        /// text, gives CS1591 
        [HttpPost]       
        public void CreateStudent(Student student)
        {
            _studentService.CreateStudent(student);//(new Student { StudentGrade = "A", StudentName = "Pan" , Code="db1"});
        }
        /// text, gives CS1591
        [HttpGet]
        public IQueryable<Student> Getstudents()
        {
            return _studentService.GetAllStudents().AsQueryable();
        }

    }
}
