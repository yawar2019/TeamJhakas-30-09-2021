using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ADODotNetExample.Models
{
    public class EmployeeContext
    {
        SqlConnection con = new SqlConnection(@"Data Source=AZAM-PC\SQLEXPRESS;Initial Catalog=Employee;Integrated Security=true");//User Id=sa;Password=123
        public List<EmployeeModel> getEmployeesData()
        {
            List<EmployeeModel> listObj = new List<EmployeeModel>();
            SqlCommand cmd = new SqlCommand("uspgetEmployeeDetails_10pm", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            //SqlDataReader dr = cmd.ExecuteReader();
            //while (dr.Read())
            //{
            //    EmployeeModel emp = new EmployeeModel();
            //    emp.EmpId = Convert.ToInt32(dr[0]);
            //    emp.EmpName = Convert.ToString(dr[1]);
            //    emp.EmpSalary = Convert.ToInt32(dr[2]);
            //    listObj.Add(emp);
            //}
            //con.Close();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)//foreach(string a in v)string []v
            {
                EmployeeModel emp = new EmployeeModel();
                emp.EmpId = Convert.ToInt32(dr[0]);
                emp.EmpName = Convert.ToString(dr[1]);
                emp.EmpSalary = Convert.ToInt32(dr[2]);
                listObj.Add(emp);

            }
            return listObj;
        }

        public int Save(EmployeeModel emp)
        {
            SqlCommand cmd = new SqlCommand("sp_AddNeerjaEmployees", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();

            cmd.Parameters.AddWithValue("@EmpName", emp.EmpName);
            cmd.Parameters.AddWithValue("@EmpSalary", emp.EmpSalary);

            int result = cmd.ExecuteNonQuery();
            con.Close();
            return result;
        }



        public EmployeeModel getEmployeesDataById(int? id)
        {
            EmployeeModel emp = new EmployeeModel();

            SqlCommand cmd = new SqlCommand("spr_getEmployeeDetailsbyId", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@empid", id);


            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)//foreach(string a in v)string []v
            {
                emp.EmpId = Convert.ToInt32(dr[0]);
                emp.EmpName = Convert.ToString(dr[1]);
                emp.EmpSalary = Convert.ToInt32(dr[2]);
            }

            return emp;
        }

        public int UpdateEmployee(EmployeeModel emp)
        {
            SqlCommand cmd = new SqlCommand("spr_updateEmployeeDetails", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();

            cmd.Parameters.AddWithValue("@Empid", emp.EmpId);
            cmd.Parameters.AddWithValue("@EmpName", emp.EmpName);
            cmd.Parameters.AddWithValue("@EmpSalary", emp.EmpSalary);

            int result = cmd.ExecuteNonQuery();
            con.Close();
            return result;
        }

        public int DeleteEmployee(int? empid)
        {
            SqlCommand cmd = new SqlCommand("usp_DeleteEmployeeById", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();

            cmd.Parameters.AddWithValue("@EmpId", empid);

            int result = cmd.ExecuteNonQuery();

            con.Close();

            return result;
        }

    }
}