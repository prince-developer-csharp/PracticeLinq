using System;
using System.Collections.Generic;
using System.Linq;
namespace PracticeLinq
{
    class Program
    {
        private static int choice;
        private static readonly List<Employee> employees = new List<Employee>()
            {
                new Employee()
                {
                    EmployeeId = 1,
                    FirstName = "John",
                    LastName = "Abharam",
                    Salary = 1000000,
                    JoiningDate = new DateTime(2013, 01, 01),
                    Department = "Banking"
                },
                new Employee()
                {
                    EmployeeId = 2,
                    FirstName = "Michael",
                    LastName = "Clarke",
                    Salary = 800000,
                    JoiningDate = new DateTime(2013, 01, 01),
                    Department = "Insurance"
                },
                 new Employee()
                {
                    EmployeeId = 3,
                    FirstName = "Roy",
                    LastName = "thomas",
                    Salary = 700000,
                    JoiningDate = new DateTime(2013, 02, 01),
                    Department = "Banking"
                },
                 new Employee()
                {
                    EmployeeId = 4,
                    FirstName = "Tom",
                    LastName = "Jose",
                    Salary = 600000,
                    JoiningDate = new DateTime(2013, 02, 01),
                    Department = "Insurance"
                },
                 new Employee()
                {
                    EmployeeId = 5,
                    FirstName = "Jerry",
                    LastName = "Pinto",
                    Salary = 650000,
                    JoiningDate = new DateTime(2013, 02, 01),
                    Department = "Insurance"
                },
                 new Employee()
                {
                    EmployeeId = 6,
                    FirstName = "Phillip",
                    LastName = "Mathew ",
                    Salary = 750000,
                    JoiningDate = new DateTime(2013, 01, 01),
                    Department = "Services"
                },
                  new Employee()
                {
                    EmployeeId = 7,
                    FirstName = "Prince",
                    LastName = "Rathore%",
                    Salary = 750000,
                    JoiningDate = new DateTime(2014, 01, 01),
                    Department = "Developer"
                }
        };

        static void Main(string[] args)
        {

            bool loop = true;
            while (loop)
            {
                Console.WriteLine("1.Get all Employee Details");
                Console.WriteLine("2.Get first name and last name from employee table");
                Console.WriteLine("5.Get First_Name from employee table in upper case");
                Console.WriteLine("6.Get First_Name from employee table in lower case");
                Console.WriteLine("7.Get unique DEPARTMENT from employee table");
                Console.WriteLine("12.Get length of FIRST_NAME from employee table");
                Console.WriteLine("15.Get FIRST_NAME ,Joining year,Joining Month and Joining Date from employee table");
                Console.WriteLine("16.Get all employee details from the employee table order by First_Name Ascending");
                Console.WriteLine("17.Get all employee details from the employee table order by First_Name descending");
                Console.WriteLine("18.Get all employee details from the employee table order by First_Name Ascending and Salary descending");
                Console.WriteLine("19.Get employee details from employee table whose employee name is “John”");
                Console.WriteLine("20.Get employee details from employee table whose employee name are “John” and “Roy”");
                Console.WriteLine("21.Get employee details from employee table whose employee name are not “John” and “Roy”");
                Console.WriteLine("22.Get employee details from employee table whose first name starts with 'J'");
                Console.WriteLine("23.Get employee details from employee table whose first name contains 'o'");
                Console.WriteLine("24.Get employee details from employee table whose first name ends with 'n'");
                Console.WriteLine("25. Get employee details from employee table whose first name ends with 'n' and name contains 4 letters");
                Console.WriteLine("26.Get employee details from employee table whose first name starts with 'J' and name contains 4 letters");
                Console.WriteLine("27.Get employee details from employee table whose Salary greater than 600000");
                Console.WriteLine("28.Get employee details from employee table whose Salary less than 800000");
                Console.WriteLine("29.Get employee details from employee table whose Salary between 500000 and 800000");
                Console.WriteLine("30.Get employee details from employee table whose name is 'John' and 'Michael'");
                Console.WriteLine("31.Get employee details from employee table whose joining year is “2013”");
                Console.WriteLine("32.Get employee details from employee table whose joining month is “January”");
                Console.WriteLine("33.Get employee details from employee table who joined before January 31st 2013");
                Console.WriteLine("34.Get employee details from employee table who joined after January 31st 2013");
                Console.WriteLine("35.Get Joining Date and Time from employee table");
                Console.WriteLine("36.Get Joining Date,Time including milliseconds from employee table");
                Console.WriteLine("39.Get names of employees from employee table who has '%' in Last_Name");
                Console.WriteLine("41.Get department,total salary with respect to a department from employee table.");
                Console.WriteLine("42.Get department,total salary with respect to a department from employee table order by total salary descending");
                Console.WriteLine("43.Get department,no of employees in a department,total salary with respect to a department from employee table order by total salary descending");
                Console.WriteLine("44.Get department wise average salary from employee table order by salary ascending");
                Console.WriteLine("45.Get department wise maximum salary from employee table order by salary ascending");
                Console.WriteLine("46.Get department wise minimum salary from employee table order by salary ascending");
                Console.WriteLine("47.Select no of employees joined with respect to year and month from employee table");
                Console.WriteLine("65.Exit");
                Console.WriteLine("Enter your choice:");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        showEmployeeDetails();
                        break;
                    case 2:
                        getFullName();
                        break;
                    case 5:
                        getFirstNameUpperCase();
                        break;
                    case 6:
                        getFirstNameLowerCase();
                        break;
                    case 7:
                        getDifferentDepartment();
                        break;
                    case 12:
                        getFirstNameLength();
                        break;
                    case 15:
                        getFirstNameAndDOJ();
                        break;
                    case 16:
                        getFirstNameAscending();
                        break;
                    case 17:
                        getFirstNameDescending();
                        break;
                    case 18:
                        getFirstNameAscAndSalaryDes();
                        break;
                    case 19:
                        getEmployeeByName();
                        break;
                    case 20:
                        getEmployeeByBothName();
                        break;
                    case 21:
                        //doubt
                        getEmployeeNotInclude();
                        break;
                    case 22:
                        getEmployeeStartWithJ();
                        break;
                    case 23:
                        getEmployeeContainsO();
                        break;
                    case 24:
                        getEmployeeEndsWithN();
                        break;
                    case 25:
                        getEmployeeEndsNContain4();
                        break;
                    case 26:
                        getEmployeeStartJContains4();
                        break;
                    case 27:
                        getEmpSalaryGreaterThan600000();
                        break;
                    case 28:
                        getEmpSalaryLessThan800000();
                        break;
                    case 29:
                        getEmpBetweenSalary();
                        break;
                    case 30:
                        getEmpByFirstName();
                        break;
                    case 31:
                        getEmpByJoiningYear();
                        break;
                    case 32:
                        getEmpByMonth();
                        break;
                    case 33:
                        getEmpBefore31Jan2013();
                        break;
                    case 34:
                        getEmpAfter31Jan2013();
                        break;
                    case 35:
                        getEmpDateAndTime();
                        break;
                    case 36:
                        //doubt
                        getEmpDateAndTimeInMs();
                        break;
                    case 39:
                        getEmployeeContainsPercent();
                        break;
                    case 41:
                        getSalaryWithDepartMent();
                        break;
                    case 42:
                        getDepartmentWithSalaryDes();
                        break;
                    case 43:
                        getDeptNumberOfEmpWithSalaryDes();
                        break;
                    case 44:
                        getAverageSalaryDepartmentwise();
                        break;
                    case 45:
                        getMaxSalaryDepartmentwise();
                        break;
                    case 46:
                        getMinSalaryDepartmentwise();
                        break;
                    case 47:
                        getNumOfEmpWithRespectDate();
                        break;
                }
            }
        }

        private static void getNumOfEmpWithRespectDate()
        {
            var employeeData = (from employee in employees
                                group employee by employee.JoiningDate into date
                                select new
                                {
                                    JoiningDate = date.Key,
                                    EmployeeId = date.Count()
                                });
            foreach (var employee in employeeData)
            {
                Console.WriteLine("Joining Date : " + employee.JoiningDate);
                Console.WriteLine("Number of employees : " + employee.EmployeeId);
                Console.WriteLine("\n");
            }
        }

        private static void getMinSalaryDepartmentwise()
        {
            var employeeData = (from employee in employees
                                group employee by employee.Department into dep
                                select new
                                {
                                    Department = dep.Key,
                                    Salary = dep.Min(t => t.Salary)
                                }).OrderBy(t => t.Salary);

            foreach (var employee in employeeData)
            {
                Console.WriteLine("Department : " + employee.Department);
                Console.WriteLine("Max Salary : " + employee.Salary);
                Console.WriteLine("\n");
            }
        }

        private static void getMaxSalaryDepartmentwise()
        {
            var employeeData = (from employee in employees
                                group employee by employee.Department into dep
                                select new
                                {
                                    Department = dep.Key,
                                    Salary = dep.Max(t => t.Salary)
                                }).OrderBy(t => t.Salary);

            foreach (var employee in employeeData)
            {
                Console.WriteLine("Department : " + employee.Department);
                Console.WriteLine("Max Salary : " + employee.Salary);
                Console.WriteLine("\n");
            }
        }

        private static void getAverageSalaryDepartmentwise()
        {
            var employeeData = (from employee in employees
                                group employee by employee.Department into dep
                                select new
                                {
                                    Department = dep.Key,
                                    Salary = dep.Average(t => t.Salary)
                                }).OrderBy(t => t.Salary);

            foreach (var employee in employeeData)
            {
                Console.WriteLine("Department : " + employee.Department);
                Console.WriteLine("Average Salary : " + employee.Salary);
                Console.WriteLine("\n");
            }
        }

        private static void getDeptNumberOfEmpWithSalaryDes()
        {
            var employeeData = (from employee in employees
                                group employee by employee.Department into dep
                                select new
                                {
                                    Department = dep.Key,
                                    EmployeeId = dep.Count(),
                                    Salary = dep.Sum(t => t.Salary)
                                }).OrderByDescending(t => t.Salary);

            foreach (var employee in employeeData)
            {
                Console.WriteLine("Department : " + employee.Department);
                Console.WriteLine("Number of Employee : " + employee.EmployeeId);
                Console.WriteLine("Salary : " + employee.Salary);
                Console.WriteLine("\n");
            }
        }

        private static void getDepartmentWithSalaryDes()
        {
            var employeeData = (from employee in employees
                               group employee by employee.Department into dep
                               select new
                               {
                                   Department = dep.Key,
                                   Salary = dep.Sum(t => t.Salary)
                               }).OrderByDescending(t => t.Salary);

            foreach (var employee in employeeData)
            {
                Console.WriteLine("Department : " + employee.Department);
                Console.WriteLine("Salary : " + employee.Salary);
                Console.WriteLine("\n");
            }
        }

        private static void getSalaryWithDepartMent()
        {              
            var employeeDepartmentData = from employee in employees select new { employee.Department };
            var employeeDifferentDept = employeeDepartmentData.Distinct();
            foreach (var dept in employeeDifferentDept)
            {
                var employeeData = employees.Where(t => t.Department == dept.Department);
                var sum = employeeData.Sum(t => t.Salary);
                Console.WriteLine("Department Name : " + dept.Department);
                Console.WriteLine("Salary : " + sum);
            }
        }

        private static void getEmployeeContainsPercent()
        {
            var employeeData = employees.Where(t => t.LastName.Contains("%"));
            foreach (var employee in employeeData)
            {
                Console.WriteLine("FullName : " + employee.FirstName + " " + employee.LastName);
                Console.WriteLine("Salary : " + employee.Salary);
                Console.WriteLine("Joining Date : " + employee.JoiningDate);
                Console.WriteLine("Department : " + employee.Department);
                Console.WriteLine("\n");
            }
        }

        private static void getEmpDateAndTimeInMs()
        {
            var employeeData = from employee in employees select new { employee.JoiningDate };
            foreach (var employee in employeeData)
            {
                Console.WriteLine("Joining Date : " + employee.JoiningDate);
                Console.WriteLine("Time in ms : " + employee.JoiningDate.Hour);
            }
        }

        private static void getEmpDateAndTime()
        {
            var employeeData = from employee in employees select new { employee.JoiningDate };
            foreach (var employee in employeeData)
            {
                Console.WriteLine("Joining Date : " + employee.JoiningDate);
            }

        }

        private static void getEmpAfter31Jan2013()
        {
            var employeeData = employees.Where(t => t.JoiningDate > new DateTime(2013, 01, 31));
            foreach (var employee in employeeData)
            {
                Console.WriteLine("FullName : " + employee.FirstName + " " + employee.LastName);
                Console.WriteLine("Salary : " + employee.Salary);
                Console.WriteLine("Joining Date : " + employee.JoiningDate);
                Console.WriteLine("Department : " + employee.Department);
                Console.WriteLine("\n");
            }
        }

        private static void getEmpBefore31Jan2013()
        {
            var employeeData = employees.Where(t => t.JoiningDate < new DateTime(2013, 01, 31));
            foreach (var employee in employeeData)
            {
                Console.WriteLine("FullName : " + employee.FirstName + " " + employee.LastName);
                Console.WriteLine("Salary : " + employee.Salary);
                Console.WriteLine("Joining Date : " + employee.JoiningDate);
                Console.WriteLine("Department : " + employee.Department);
                Console.WriteLine("\n");
            }
        }

        private static void getEmpByMonth()
        {
            var employeeData = employees.Where(t => t.JoiningDate.Month == 1);
            foreach (var employee in employeeData)
            {
                Console.WriteLine("FullName : " + employee.FirstName + " " + employee.LastName);
                Console.WriteLine("Salary : " + employee.Salary);
                Console.WriteLine("Joining Date : " + employee.JoiningDate);
                Console.WriteLine("Department : " + employee.Department);
                Console.WriteLine("\n");
            }
        }

        private static void getEmpByJoiningYear()
        {
            var employeeData = employees.Where(t => t.JoiningDate.Year == 2013);
            foreach (var employee in employeeData)
            {
                Console.WriteLine("FullName : " + employee.FirstName + " " + employee.LastName);
                Console.WriteLine("Salary : " + employee.Salary);
                Console.WriteLine("Joining Date : " + employee.JoiningDate);
                Console.WriteLine("Department : " + employee.Department);
                Console.WriteLine("\n");
            }
        }

        private static void getEmpByFirstName()
        {
            var employeeData = employees.Where(t => t.FirstName == "John" || t.FirstName == "Michael");
            foreach (var employee in employeeData)
            {
                Console.WriteLine("FullName : " + employee.FirstName + " " + employee.LastName);
                Console.WriteLine("Salary : " + employee.Salary);
                Console.WriteLine("Joining Date : " + employee.JoiningDate);
                Console.WriteLine("Department : " + employee.Department);
                Console.WriteLine("\n");
            }
        }

        private static void getEmpBetweenSalary()
        {
            var employeeData = employees.Where(t => t.Salary >500000 && t.Salary < 800000);
            foreach (var employee in employeeData)
            {
                Console.WriteLine("FullName : " + employee.FirstName + " " + employee.LastName);
                Console.WriteLine("Salary : " + employee.Salary);
                Console.WriteLine("Joining Date : " + employee.JoiningDate);
                Console.WriteLine("Department : " + employee.Department);
                Console.WriteLine("\n");
            }
        }

        private static void getEmpSalaryLessThan800000()
        {
            var employeeData = employees.Where(t => t.Salary < 800000);
            foreach (var employee in employeeData)
            {
                Console.WriteLine("FullName : " + employee.FirstName + " " + employee.LastName);
                Console.WriteLine("Salary : " + employee.Salary);
                Console.WriteLine("Joining Date : " + employee.JoiningDate);
                Console.WriteLine("Department : " + employee.Department);
                Console.WriteLine("\n");
            }
        }

        private static void getEmpSalaryGreaterThan600000()
        {
            var employeeData = employees.Where(t => t.Salary > 600000);
            foreach (var employee in employeeData)
            {
                Console.WriteLine("FullName : " + employee.FirstName + " " + employee.LastName);
                Console.WriteLine("Salary : " + employee.Salary);
                Console.WriteLine("Joining Date : " + employee.JoiningDate);
                Console.WriteLine("Department : " + employee.Department);
                Console.WriteLine("\n");
            }
        }

        private static void getEmployeeStartJContains4()
        {
            var employeeData = employees.Where(t => t.FirstName.StartsWith("J") && t.FirstName.Length == 4);
            foreach (var employee in employeeData)
            {
                Console.WriteLine("FullName : " + employee.FirstName + " " + employee.LastName);
                Console.WriteLine("Salary : " + employee.Salary);
                Console.WriteLine("Joining Date : " + employee.JoiningDate);
                Console.WriteLine("Department : " + employee.Department);
                Console.WriteLine("\n");
            }
        }

        private static void getEmployeeEndsNContain4()
        {
            var employeeData = employees.Where(t => t.FirstName.EndsWith("n") && t.FirstName.Length == 4);
            foreach (var employee in employeeData)
            {
                Console.WriteLine("FullName : " + employee.FirstName + " " + employee.LastName);
                Console.WriteLine("Salary : " + employee.Salary);
                Console.WriteLine("Joining Date : " + employee.JoiningDate);
                Console.WriteLine("Department : " + employee.Department);
                Console.WriteLine("\n");
            }
        }

        private static void getEmployeeEndsWithN()
        {
            var employeeData = employees.Where(t => t.FirstName.EndsWith("n"));
            foreach (var employee in employeeData)
            {
                Console.WriteLine("FullName : " + employee.FirstName + " " + employee.LastName);
                Console.WriteLine("Salary : " + employee.Salary);
                Console.WriteLine("Joining Date : " + employee.JoiningDate);
                Console.WriteLine("Department : " + employee.Department);
                Console.WriteLine("\n");
            }
        }

        private static void getEmployeeContainsO()
        {
            var employeeData = employees.Where(t => t.FirstName.Contains("o"));
            foreach (var employee in employeeData)
            {
                Console.WriteLine("FullName : " + employee.FirstName + " " + employee.LastName);
                Console.WriteLine("Salary : " + employee.Salary);
                Console.WriteLine("Joining Date : " + employee.JoiningDate);
                Console.WriteLine("Department : " + employee.Department);
                Console.WriteLine("\n");
            }
        }

        private static void getEmployeeStartWithJ()
        {
            var employeeData = employees.Where(t => t.FirstName.StartsWith("J"));
            foreach (var employee in employeeData)
            {
                Console.WriteLine("FullName : " + employee.FirstName + " " + employee.LastName);
                Console.WriteLine("Salary : " + employee.Salary);
                Console.WriteLine("Joining Date : " + employee.JoiningDate);
                Console.WriteLine("Department : " + employee.Department);
                Console.WriteLine("\n");
            }
        }

        private static void getEmployeeNotInclude()
        {
            Console.WriteLine("prince");
            var employeeData = employees.Where(t => t.FirstName != "John" || t.FirstName != "Roy");
            foreach (var employee in employeeData)
            {
                Console.WriteLine("FullName : " + employee.FirstName + " " + employee.LastName);
                Console.WriteLine("Salary : " + employee.Salary);
                Console.WriteLine("Joining Date : " + employee.JoiningDate);
                Console.WriteLine("Department : " + employee.Department);
                Console.WriteLine("\n");
            }
        }

        private static void getEmployeeByBothName()
        {
            var employeeData = employees.Where(t => t.FirstName == "John" || t.FirstName == "Roy");
            foreach (var employee in employeeData)
            {
                Console.WriteLine("FullName : " + employee.FirstName + " " + employee.LastName);
                Console.WriteLine("Salary : " + employee.Salary);
                Console.WriteLine("Joining Date : " + employee.JoiningDate);
                Console.WriteLine("Department : " + employee.Department);
                Console.WriteLine("\n");
            }
        }

        private static void getEmployeeByName()
        {
            var singleEmployee = employees.Where(t => t.FirstName == "John").FirstOrDefault();
            Console.WriteLine("FullName : " + singleEmployee.FirstName + " " + singleEmployee.LastName);
            Console.WriteLine("Salary : " + singleEmployee.Salary);
            Console.WriteLine("Joining Date : " + singleEmployee.JoiningDate);
            Console.WriteLine("Department : " + singleEmployee.Department);
            Console.WriteLine("\n");
        }

        private static void getFirstNameAscAndSalaryDes()
        {
            var employeeData = employees.OrderBy(data => data.FirstName).ThenByDescending(data => data.Salary);
            foreach (var employee in employeeData)
            {
                Console.WriteLine("Employee First Name : " + employee.FirstName + "  Salary : " + employee.Salary);
                Console.WriteLine("\n");
            }
        }

        private static void getFirstNameDescending()
        {
            var employeeData = employees.OrderByDescending(data => data.FirstName);
            foreach (var employee in employeeData)
            {
                Console.WriteLine("Employee First Name : " + employee.FirstName);
                Console.WriteLine("\n");
            }
        }

        private static void getFirstNameAscending()
        {
            var employeeData = employees.OrderBy(data => data.FirstName);
            foreach (var employee in employeeData)
            {
                Console.WriteLine("Employee First Name : " + employee.FirstName);
                Console.WriteLine("\n");
            }
        }

        private static void getFirstNameAndDOJ()
        {
            var employeeData = from employee in employees select new { employee.FirstName, employee.JoiningDate };
            foreach (var employee in employeeData)
            {
                Console.WriteLine("First Name : " + employee.FirstName);
                Console.WriteLine("Joining year : " + employee.JoiningDate.Year);
                Console.WriteLine("Joining Month : " + employee.JoiningDate.Month);
                Console.WriteLine("Joining Date : " + employee.JoiningDate.Day);
                Console.WriteLine("\n");
            }
        }

        private static void getDifferentDepartment()
        {
            var employeeDepartmentData = from employee in employees select new { employee.Department };
            var employeeDifferentDept = employeeDepartmentData.Distinct();
            foreach(var dept in employeeDifferentDept)
            {
                Console.WriteLine(dept.Department);
            }
        }

        private static void getFirstNameLowerCase()
        {
            var employeeData = from employee in employees select new { employee.FirstName };
            foreach (var name in employeeData)
            {
                Console.WriteLine("First Name : " + name.FirstName.ToLower());
            }
        }

        private static void getFirstNameUpperCase()
        {
            var employeeData = from employee in employees select new { employee.FirstName };
            foreach (var name in employeeData)
            {
                Console.WriteLine("First Name : " + name.FirstName.ToUpper());
            }
        }

        private static void getFirstNameLength()
        {
            var employeeData = from employee in employees select new { employee.FirstName };
            foreach(var name in employeeData)
            {
                Console.WriteLine("First Name length : " + name.FirstName.Length);
            }
        }

        private static void getFullName()
        {
            var fullName = from employee in employees select new { employee.FirstName, employee.LastName };
            foreach (var name in fullName)
            {
                Console.WriteLine(name.FirstName + " " + name.LastName);
            }
        }

        private static void showEmployeeDetails()
        {
            Console.WriteLine("\n");
            foreach (var employee in employees)
            {
                Console.WriteLine("FullName : " + employee.FirstName + " " + employee.LastName);
                Console.WriteLine("Salary : " + employee.Salary);
                Console.WriteLine("Joining Date : " + employee.JoiningDate);
                Console.WriteLine("Department : " + employee.Department);
                Console.WriteLine("\n");
            }
        }
    }
}
