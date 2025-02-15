﻿using Nqn.lab04._2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nqn.lab04._2.Controllers
{
    public class NqnCustomerController : Controller
    {
        // GET: NqnCustomer
        public ActionResult Index()
        {
            return View();
        }
        static CustomerRepository listCustomer;
        public NqnCustomerController()
        {
            listCustomer = new CustomerRepository();
        }
        // GET: /Customer/GetCustomers
        public ActionResult GetCustomers()
        {
            return View(listCustomer.GetCustomers());
        }
        //POST: /Customer/GetCustomers
        [HttpPost]
        public ActionResult GetCustomers(string name)
        {
            return View(listCustomer.SearchCustomer(name));
        }
        // GET: /Customer/Details/5
        public ActionResult Details(string id)
        {
            return View(listCustomer.GetCustomer(id));
        }
        // GET: /Customer/Create
        public ActionResult Create()
        {
            return View();
        }
        // POST: /Customer/Create
        [HttpPost]
        public ActionResult Create(Customer cus)
        {
            listCustomer.AddCustomer(cus);
            return RedirectToAction("GetCustomers");
        }
        // GET: /Customer/Edit/5
        public ActionResult Edit(string id)
        {
            return View(listCustomer.GetCustomer(id));
        }
        public ActionResult Edit(Customer cus)
        {
            listCustomer.UpdateCustomer(cus);
            return RedirectToAction("GetCustomers");
        }
        // GET: /Customer/Delete/5
        public ActionResult Delete(string id)
        {
            listCustomer.DeleteCustomer(listCustomer.GetCustomer(id));
            return RedirectToAction("GetCustomers");
        }
    }
}