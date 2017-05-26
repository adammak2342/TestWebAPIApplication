﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace TestWebAPIApplication.Models
{
    public class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpAddress { get; set; }
        public string EmpDesig { get; set; }
        public string EmpDepartment { get; set; }
        public decimal EmpSalary { get; set; }
        public double SomeValue { get; set; }
    }
}