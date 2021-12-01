using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using MVCDemo2.Models;
using MVCDemo2.DAL;

namespace MVCDemo2.BAL
{
    public class DeptBal
    {
        DeptDal dal = new DeptDal();

        public List<DepartmentModel> DeptList()
        {
            SqlDataReader reader = dal.GetDepartmentData();
            List<DepartmentModel> dlist = new List<DepartmentModel>();
            while (reader.Read())
            {
                DepartmentModel d = new DepartmentModel();
                d.deptno = Convert.ToInt32(reader["deptno"].ToString());
                d.dname = reader["deptname"].ToString();
                d.location = reader["location"].ToString();
                dlist.Add(d);
            }
            return dlist;
        }

        public DepartmentModel GetDeptUsingDeptno(int deptno)
        {
            SqlDataReader reader = dal.GetDeptUsingDeptno(deptno);
            DepartmentModel dlist = null;
            while (reader.Read())
            {
                 dlist = new DepartmentModel();
                dlist.deptno = Convert.ToInt32(reader["deptno"].ToString());
                dlist.dname = reader["deptname"].ToString();
                dlist.location = reader["location"].ToString();
            }
            return dlist;
        }

        public int InsertDepartment (DepartmentModel dm)
        {
            int res = dal.InsertDepartment(dm.deptno,dm.dname,dm.location);
            return res;
        }

        public int UpdateDepartment(DepartmentModel dm)
        {
            int res = dal.UpdateDepartment(dm.deptno, dm.dname, dm.location);
            return res;
        }
        public int DeleteDepartment(int deptno)
        {
            int res = dal.DeleteDepartment(deptno);
            return res;
        }
    }
}