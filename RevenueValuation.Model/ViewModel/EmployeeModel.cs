using System;
using System.Collections.Generic;
using System.Text;

namespace RevenueValuation.Model.ViewModel
{
    public class EmployeeViewModel
    {
        public int EmployeeId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Title { get; set; }
        public String Name { get { return FirstName + " " + LastName; } }
    }
}
