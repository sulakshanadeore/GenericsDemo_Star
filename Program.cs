using GenericsLibraryDemo;

internal class Program
{
    private static void Main(string[] args)
    {
        // List<Employee> emps = new List<Employee> 
        // {
        // new Employee{Empid=10,EmpName="Jill",Deptno=10 },
        // new Employee{ Empid=11,EmpName="Jim",Deptno=20},
        // new Employee{ Empid=12,EmpName="Jack",Deptno=30}

        // };


        //List<Employee> emplist = new List<Employee>(); 

        // //create employee object
        // Employee employee = new Employee();
        // employee.Empid = 1;
        // employee.EmpName = "Raj";
        // employee.Deptno = 10;

        // //add employee object to list
        // emplist.Add(employee);


        // //Collection Initializer
        // emplist.Add(new Employee { Empid=2,EmpName="Ratan",Deptno=10});

        // //Object Initialiser-- create employee object
        // Employee e2 = new Employee {Empid=3,EmpName="Jack",Deptno=20 };
        // //add object to list
        // emplist.Add(e2);


        char ans = 'Y';
        EmployeeService employeeService = new EmployeeService();

        Console.WriteLine("1.Add \n2.Remove \n3.Update \n4.Find \n5.ShowAll \n6.Find By Name \n7.FirstMatch \n10.Exit");
        
        while (ans=='Y')
        {
            Console.WriteLine("Enter your choice");
            int choice=Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 7:
                    Console.WriteLine("Enter the name to find");
                    string name = Console.ReadLine();
                    Employee edata = employeeService.FindFirstMatch(name);
                        Console.WriteLine(edata.Empid + " " + edata.EmpName);

                    break;
                case 1:
                    Employee emp=new Employee();
                    Console.WriteLine("Enter EmployeeID");
                    emp.Empid = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Name");
                    emp.EmpName = Console.ReadLine().Trim();
                    Console.WriteLine("Enter Deptno");
                    emp.Deptno=Convert.ToInt32(Console.ReadLine());
                    employeeService.NewEmployee(emp);
                    break;
                case 2:
                    Console.WriteLine("Enter EmployeeID");
                    int empid = Convert.ToInt32(Console.ReadLine());
                    employeeService.DeleteEmployee(empid);
                    break;
                case 3:
                    Console.WriteLine("Enter EmployeeID");
                     empid = Convert.ToInt32(Console.ReadLine());

                    Employee emptoUpdate=new Employee();
                    Console.WriteLine("Enter Name");
                    emptoUpdate.EmpName = Console.ReadLine().Trim();
                    Console.WriteLine("Enter Deptno");
                    emptoUpdate.Deptno = Convert.ToInt32(Console.ReadLine());

                    employeeService.UpdateEmployeeData(empid, emptoUpdate); 
                    break;
                case 4:

                    Console.WriteLine("Enter EmployeeID");
                     empid = Convert.ToInt32(Console.ReadLine());

                    Employee empdata=employeeService.FindEmployee(empid);
                    Console.WriteLine(empdata.Empid);
                    Console.WriteLine(empdata.EmpName);
                    Console.WriteLine(empdata.Deptno);
                    break;
                case 5:
                    List<Employee> allemps=employeeService.GetAllEmpList();
                    foreach (var item in allemps)
                    {
                        Console.WriteLine($"{item.Empid}|{item.EmpName}|{item.Deptno}");

                    }
                    break;
                    case 6:
                    Console.WriteLine("Enter the name to find");
                    string nameToFind=Console.ReadLine();
                   List<Employee> sameNameEmps=employeeService.FindAllEmployeesWithSameName(nameToFind);
                    foreach (var item in sameNameEmps)
                    {
                        Console.WriteLine(item.Empid + "  "  +item.EmpName);
                    }

                    break;
                case 10:
                    Environment.Exit(1);
                    break;

            }
            Console.WriteLine("Do u want to continue");
            ans=Convert.ToChar(Console.ReadLine()); 

        }


           
    }
}