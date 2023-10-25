/*
Create enum dep having value[MKT = 1, ADV = 2, ADMN = 3]
Create a class Employee with instance member id, name, salary and enum dept d.
Create 5 object of class Employee and put them into different department.
Write a  sataic method which will display department wise total salary paid

E.g.
1, "Raj", 3000, dep.ADMN
2, "Reena", 2000, dep.ADMN
 3, "Geeta", 1000, dep.MKT

O/p ADMN department spend 5000 on salary
MKT department spend 1000 on salary
*/

using System.Diagnostics;
using System.Xml.Linq;
using Enum;

internal class main
{
    public static void Display(Employee[] arr)
    {
        double sum_1 = 0;
        double sum_2 = 0;
        double sum_3 = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].GetDep() == dep.MKT)
            {
                sum_1 += arr[i].GetSalary();
            }
            if (arr[i].GetDep() == dep.ADV)
            {
                sum_2 += arr[i].GetSalary();
            }
            if (arr[i].GetDep() == dep.ADMN)
            {
                sum_3 += arr[i].GetSalary();
            }
        }
        Console.WriteLine(sum_1);
        Console.WriteLine(sum_2);
        Console.WriteLine(sum_3);
    }
    private static void Main(string[] args)
    {
        Employee[] arr=new Employee[5] ;
       arr[0] = new Employee(01,3000,"Raj",dep.ADMN);
       arr[1] = new Employee(02,2000,"Reena",dep.ADMN);
       arr[2] = new Employee(03,1000,"Geeta", dep.MKT);
       arr[3] = new Employee(04,5000, "kiran", dep.ADV);
       arr[4] = new Employee(05,6000, "Abhishek", dep.MKT);
       Display(arr);

        Console.WriteLine(arr[1].PayTax(10));
        

    }
}