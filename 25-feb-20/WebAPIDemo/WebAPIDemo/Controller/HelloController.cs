using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BusinessLayer;
using System.Web.Http.Results;
using Models;
namespace WebAPIDemo.Controller
{
    public class HelloController : ApiController
    {
        public List<Models.Student> Get()
        {
            StudentFactory objBusinessStudent = new StudentFactory();
            List<Models.Student> result = new List<Models.Student>();
            result = objBusinessStudent.GetStudents();
            return result;
        }
        //public List<Models.Student> Post(Student student)
        //{
        //   using( var ctx = new Student())
        //   {
        //       ctx.Student.Add(new Student()
        //   }

        //}

        //[HttpPut]
        //public bool UpdateStudent(Student student)
        //{
        //    Student objBusinessStudent = new Student();
        //    List<Models.Student> result = new List<Models.Student>();
        //    result = objBusinessStudent.Students();
        //    return result;
        //}
        [HttpGet]
        public Student Get(int id)
        {
            StudentFactory objBusinessStudent = new StudentFactory();
            Student result = new Student();
            result = objBusinessStudent.GetStudentById(id);
            return result;
        }

        [HttpPut]
        public void UpdateStudent(Student student)
        {
            StudentFactory objBusinessStudent = new StudentFactory();
            //List<Models.Student> result = new List<Models.Student>();
            objBusinessStudent.UpdateStudent(student);





        }
        [HttpDelete]
        public bool DeleteStudent(int id)
        {
            StudentFactory objBusinessStudent = new StudentFactory();
            //List<Models.Student> result = new List<Models.Student>();
            objBusinessStudent.DeleteStudent(id);


            return true;


        }
    }
}
