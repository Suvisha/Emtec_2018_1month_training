//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DemoWebApp1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Department { get; set; }
        public Nullable<int> EmployeeTypeId { get; set; }
        public int HourlyPay { get; set; }
        public int Bonusinc { get; set; }
    
        public virtual EmployeeType EmployeeType { get; set; }
    }
}
