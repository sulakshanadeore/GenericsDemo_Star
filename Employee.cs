namespace GenericsLibraryDemo
{
    public class Employee
    {
        public int Empid { get; set; }
        public string EmpName { get; set; }
        public int Deptno { get; set; }
    }

    public class EmployeeService {

        static List<Employee> empList = new List<Employee>() {
         new Employee{Empid=100,EmpName="Tim",Deptno=10 },
        new Employee{ Empid=101,EmpName="Sim",Deptno=20},
        new Employee{ Empid=102,EmpName="Gill",Deptno=30}
         };

        public void NewEmployee(Employee employee) { 
        empList.Add(employee);  

        }


        public List<Employee> GetAllEmpList()
        {
            return empList;
        
        }

        public void DeleteEmployee(int empid)
        { 
        }

        public void UpdateEmployeeData(int empid, Employee emp)
        {
        
       Employee obj= empList.Find(item=>item.Empid==empid);
            if (obj != null) {
            obj.EmpName = emp.EmpName;
                obj.Deptno = emp.Deptno;
                Console.WriteLine("Updated successfully...");
            }
            else
            {
                Console.WriteLine("not found");
            }
        
        }
        //public Employee FindEmployee(int empid) { 
        
        //}

    
    }
}
