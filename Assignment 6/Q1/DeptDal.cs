using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace MVCDemo2.DAL
{
    public class DeptDal
    {
        public SqlDataReader GetDepartmentData()
        {
            SqlDataReader reader = null;
            try
            {
                SqlConnection conn = new SqlConnection("server=.;database=EmployeeDepartmentDB;trusted_connection=true");
                conn.Open();

                SqlCommand cmd = new SqlCommand("GetDepartmentData", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                reader=cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            return reader;
        }

        public SqlDataReader GetDeptUsingDeptno(int deptno)
        {
            SqlDataReader reader = null;
            try
            {
                SqlConnection conn = new SqlConnection("server=.;database=EmployeeDepartmentDB;trusted_connection=true");
                conn.Open();

                SqlCommand cmd = new SqlCommand("GetDeptUsingDeptno", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter param = new SqlParameter("deptno", deptno);
                cmd.Parameters.Add(param);
                reader = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            return reader;
        }

        public int InsertDepartment(int deptno, string dname, string location)
        {
            int res = 0;
            try
            {
                SqlConnection conn = new SqlConnection("server=.;database=EmployeeDepartmentDB;trusted_connection=true");
                conn.Open();

                SqlCommand cmd = new SqlCommand("InsertDepartment", conn);
                cmd.CommandType= CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("deptno", deptno);
                cmd.Parameters.AddWithValue("deptname", dname);
                cmd.Parameters.AddWithValue("location", location);

                res = cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            return res;
        }

        public int UpdateDepartment(int deptno, string dname, string location)
        {
            int res = 0;
            try
            {
                SqlConnection conn = new SqlConnection("server=.;database=EmployeeDepartmentDB;trusted_connection=true");
                conn.Open();

                SqlCommand cmd = new SqlCommand("UpdateDepartment", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("deptno", deptno);
                cmd.Parameters.AddWithValue("deptname", dname);
                cmd.Parameters.AddWithValue("location", location);

                res = cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            return res;
        }

        public int DeleteDepartment(int deptno)
        {
            int no = 0;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=.;Database=EmployeeDepartmentDB;trusted_connection=true";
                con.Open();

                SqlCommand cmd = new SqlCommand("DeleteDepartment", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("deptno", deptno);
                no = cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Exception " + ex.Message);
                throw;
            }
            return no;
        }
    }
}