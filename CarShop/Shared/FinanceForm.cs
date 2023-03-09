using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop.Shared.Forms
{
    public class FinanceForm
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? HouseNo { get; set; }
        public string? Street { get; set; }
        public string? City { get; set; }
        public string? Region { get; set; } 
        public string? PostalCode { get; set; }
        public string? Country { get; set; }
        public string? Occupation { get; set; }
        public string? JobName { get; set; }
        public string? JobAddress { get; set; }
        public string? JobPhone { get; set; }
        public string? JobSalary { get; set; }
        public string? Make { get; set; }
        public string? Model { get; set; }
        public string? Reg { get; set; }
        public string? Mileage { get; set; }
        public string? Deposit { get; set; }
        public string? MonthlyFinance { get; set; }
        public string? TotalPrice { get; set; }

    }
}
