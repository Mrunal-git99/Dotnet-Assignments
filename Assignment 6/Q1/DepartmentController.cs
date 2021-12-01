using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDemo2.Models;
using MVCDemo2.BAL;

namespace MVCDemo2.Controllers
{
    public class DepartmentController : Controller
    {
        // GET: Department
        DeptBal bal = new DeptBal();
        public ActionResult Index()
        {
            List<DepartmentModel> dlist= bal.DeptList();
            return View(dlist);
        }

        [HttpGet]
        public ActionResult InsertDept()
        {
            return View();
        }

        [HttpPost]
        public ActionResult InsertDept(FormCollection collection)
        {
            try
            {
                DepartmentModel model = new DepartmentModel();
                model.deptno = Convert.ToInt32(collection["deptno"].ToString());
                model.dname = collection["dname"].ToString();
                model.location = collection["location"].ToString();

                bal.InsertDepartment(model);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["err"] = ex.Message;
                TempData["backpage"] = "InsertDept";
                return RedirectToAction("ErrorPage");
            }
        }

        [HttpGet]
        public ActionResult UpdateDept(int id)
        {
            DepartmentModel dm = bal.GetDeptUsingDeptno(id);
            return View(dm);
        }

        [HttpPost]
        public ActionResult UpdateDept(FormCollection collection)
        {
            try
            {
                DepartmentModel model = new DepartmentModel();
                model.deptno = Convert.ToInt32(collection["deptno"].ToString());
                model.dname = collection["dname"].ToString();
                model.location = collection["location"].ToString();

                bal.UpdateDepartment(model);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["err"] = ex.Message;
                TempData["backpage"] = "InsertDept";
                return RedirectToAction("ErrorPage");
            }
        }
        [HttpGet]
        public ActionResult DeleteDept(int id)
        {
            try
            {
                bal.DeleteDepartment(id);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["err"] = ex.Message;
                TempData["backpage"] = "Index";
                return RedirectToAction("ErrorPage");
            }
        }

        [HttpGet]
        public ActionResult DetailsDept(int id)
        {
            DepartmentModel dm = bal.GetDeptUsingDeptno(id);
            return View(dm);
        }

        [HttpGet]
        public ActionResult ErrorPage()
        {
            TempData.Keep("err");
            TempData.Keep("InsertDept");
            return View();
        }
    }

}