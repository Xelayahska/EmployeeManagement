﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmployeeManagement.ServiceLayer;
using EmployeeManagement.ViewModels;

namespace EmployeeManagement.Controllers
{
    public class LeaveController : Controller
    {
        // GET: Leave
        ILeaveService il;
        public LeaveController(ILeaveService il)
        {
            this.il = il;
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetLeaveRequests()
        {
            List<LeaveViewModel> lvm = new List<LeaveViewModel>();
            lvm = il.GetLeaveRequests();
            return View(lvm);
        }
        [HttpPost]
        public ActionResult ApproveLeave(LeaveViewModel lvm)
        {
            
            il.ApproveLeave(lvm);
            return RedirectToAction("GetLeaveRequests");
            
        }
    }
}