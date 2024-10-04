using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework_Core.Model
{
    public class Employee
    {
        public int EmployeeId {  get; set; }
        public string? EmployeeName { get; set; }
        public String? Username {  get; set; }
        public string? Password { get; set; }
        public float Salary {  get; set; }
        public string? Phone {  get; set; }
        public string? Address {  get; set; }
        public DateTime? Created {  get; set; }
        public DateTime? Updated { get; set; }

        public void Display()
        {
            Console.WriteLine("id:{0}, name:{1},phone:{2},address:{3}",
                EmployeeId,EmployeeName,Phone,Address);
        }
    }
}
