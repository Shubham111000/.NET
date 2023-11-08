
/*
create a poco class employee with member id,name,salary,department departmentid
create another class department with member id,deptname
create a context class which will derived from Dbcontext
set connection string in on configuring method
put Dbset department ,employee
download four DLL file
add-migration update database
1st task=display all employee who is in department 1
2nd task=display all employee 
3rd task=(*)enter data first in department table then add in employee table
4th task=add employee record through entity
5th task=delete employee where employee id is 3
6th task=display dept name and employee withn it
7th task=display all employee whos salary is greater than 80000
8th task=display all employee whose name starting with 's'
*/

using Microsoft.Identity.Client;

namespace EmployeeEntity
{

    internal class Program
    {
        static void Main(string[] args)
        {
            DbServices dbServices = new DbServices();
            dbServices.DisplayAll();
            Console.WriteLine("___________________");
            dbServices.addData(new Employee { Name = "Mayur Patil" ,});
            dbServices.DisplayAll();


        }
    }

}