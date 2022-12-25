using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayrollService
{
    public class Program
    {
        static void Main(string[] args)
        {
            Payroll payroll = new Payroll();
            bool flag = true;
            while (flag)
            {
                Console.Write("1. Display\n2. Add\n3. Update\n4. Delete\n5. Exit\n");
                int option = Convert.ToInt16(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        EmployeeRepository employeeRepositoryDisplay = new EmployeeRepository();
                        employeeRepositoryDisplay.GetAllEmployes();
                        break;
                    case 2:
                        Console.Write("Enter new name : ");
                        payroll.EmpName = Console.ReadLine();
                        Console.Write("Enter New Department name : ");
                        payroll.EmpDept = Console.ReadLine();
                        Console.Write("Enter new salary : ");
                        payroll.EmpSalary = Convert.ToInt64(Console.ReadLine());
                        EmployeeRepository employeeRepositoryAdd = new EmployeeRepository();
                        employeeRepositoryAdd.AddEmployee(payroll);
                        break;
                    case 3:
                        Console.Write("Enter Id : ");
                        payroll.EmpId = Convert.ToInt16(Console.ReadLine());
                        Console.Write("Enter upadted name : ");
                        payroll.EmpName = Console.ReadLine();
                        Console.Write("Enter updated Department name : ");
                        payroll.EmpDept = Console.ReadLine();
                        Console.Write("Enter updated salary : ");
                        payroll.EmpSalary = Convert.ToInt64(Console.ReadLine());
                        EmployeeRepository employeeRepositoryUpdate = new EmployeeRepository();
                        employeeRepositoryUpdate.UpdateEmployee(payroll);
                        break;
                    case 4:
                        Console.Write("Enter Employee Id to delte : ");
                        int employeeIdForDelete = Convert.ToInt16(Console.ReadLine());
                        EmployeeRepository employeeRepositoryDelete = new EmployeeRepository();
                        employeeRepositoryDelete.DeleteEmployee(employeeIdForDelete);
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}
