using DatabaseLayer;
using Models;
using System;
using System.Collections.Generic;
using System.Data;
namespace BusinessLayer
{
    public class StudentFactory
    {
        public System.Collections.Generic.List<Models.Student> GetStudents()
        {
            List<Models.Student> result = new List<Models.Student>();

            var dbManager = new DBManager("DBConnection");
            var students = dbManager.GetDataTable("DAH_User1_GetAll", CommandType.StoredProcedure, null);
            Models.Student element;
            if (students != null)
            {
                for (int index = 0; index < students.Rows.Count; index++)
                {
                    element = new Models.Student();
                    element.Id = Convert.ToInt32(students.Rows[index]["studentId"].ToString());
                    element.studentFirst_name = students.Rows[index]["studentFirst_name"].ToString();
                    element.studentLast_name = students.Rows[index]["studentLast_name"].ToString();
                    element.student_gender = students.Rows[index]["student_gender"].ToString();

                    string s = Convert.ToString(students.Rows[index]["student_Dob"]);
                    DateTime DOB = Convert.ToDateTime(s);
                    element.student_Dob = DOB;

                    //element.student_Dob = Convert.ToDateTime(students.Rows[index]["student_Dob"].ToString());
                    element.Passsword = students.Rows[index]["Passsword"].ToString();
                    element.student_mobileno = Convert.ToInt64(students.Rows[index]["student_mobileno"].ToString());
                    element.student_address = students.Rows[index]["student_address"].ToString();
                    result.Add(element);
                }
            }
            return result;

        }
        public Student GetStudentById(int Id)
        {
            Student element = new Student();

            var dbManager = new DBManager("DBConnection");
            var parameters = new List<IDbDataParameter>();
            parameters.Add(dbManager.CreateParameter("@studentId", Id, DbType.Int32));
            var students = dbManager.GetDataTable("DAH_User1_GetById", CommandType.StoredProcedure, parameters.ToArray());

            element.Id = Convert.ToInt16(students.Rows[0]["studentId"].ToString());
            element.studentFirst_name = students.Rows[0]["studentFirst_name"].ToString();
            element.studentLast_name = students.Rows[0]["studentLast_name"].ToString();
            element.student_gender = students.Rows[0]["student_gender"].ToString();

            string s = Convert.ToString(students.Rows[0]["student_Dob"]);
            DateTime DOB = Convert.ToDateTime(s);
            element.student_Dob = DOB;

            //element.student_Dob = Convert.ToDateTime(students.Rows[index]["student_Dob"].ToString());
            element.Passsword = students.Rows[0]["Passsword"].ToString();
            element.student_mobileno = Convert.ToInt64(students.Rows[0]["student_mobileno"].ToString());
            element.student_address = students.Rows[0]["student_address"].ToString();



            return element;
        }

        public void UpdateStudent(Student student)
        {

            //Student result = new Student();
            var dbManager = new DBManager("DBConnection");
            var parameters = new List<IDbDataParameter>();
            parameters.Add(dbManager.CreateParameter("@studentId", student.Id, DbType.Int32));
            parameters.Add(dbManager.CreateParameter("@studentFirst_name", 50, student.studentFirst_name, DbType.String));
            parameters.Add(dbManager.CreateParameter("@studentLast_name", student.studentLast_name, DbType.String));
            parameters.Add(dbManager.CreateParameter("@student_gender", student.student_gender, DbType.String));
            parameters.Add(dbManager.CreateParameter("@student_Dob", student.student_Dob, DbType.DateTime));
            parameters.Add(dbManager.CreateParameter("@Passsword", student.Passsword, DbType.String));
            parameters.Add(dbManager.CreateParameter("@student_mobileno", student.student_mobileno, DbType.String));
            parameters.Add(dbManager.CreateParameter("@student_address", student.student_address, DbType.String));
            dbManager.Update("DAH_User1_Update", CommandType.StoredProcedure, parameters.ToArray());
        }

        public void DeleteStudent(int id)
        {

            Student result = new Student();
            var dbManager = new DBManager("DBConnection");
            var parameters = new List<IDbDataParameter>();
            parameters.Add(dbManager.CreateParameter("@studentId", id, DbType.Int32));
            dbManager.Delete("DAH_User1_Delete", CommandType.StoredProcedure, parameters.ToArray());
        }
    }
}
