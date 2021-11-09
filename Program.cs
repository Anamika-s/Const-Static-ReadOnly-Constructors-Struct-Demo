using System;

namespace EmpDemo
{
    class Program
    {
        static void Main(string[] args)
        {
        // Employee.companyName="NEW";
          // Console.WriteLine("COMPANY NAME IS " + Employee.companyName);
        // {  Employee.Department ="HR";
        //    Console.WriteLine("Department is " + Employee.Department);
          // Employee.DepartmentDetails();
           // Def Const will be invoked
           Employee employee1 = new Employee();
           employee1.GetDetails();
           employee1.DisplayDetails();
            // Def Const will be invoked
           Employee employee2 = new Employee();
           employee2.GetDetails();
           employee2.DisplayDetails();
            // Para Const will be invoked
           Employee emp3 = new  Employee("Himanshu Jain");
           //emp3.GetDetails();
           emp3.DisplayDetails();
            // Para Const will be invoked
           Employee emp4 = new  Employee(11,"Dhanashree");
           emp4.DisplayDetails();
            // Para Const will be invoked
           Employee emp5 = new Employee(12,"Lalit", 9000);
           emp5.DisplayDetails();
            // Copy Const will be invoked
           Employee emp6 = new  Employee(emp5);
           emp6.DisplayDetails();
           
           
           Record rec = new Record();
           rec.Get();
           rec.Display();

        }
    }
}
