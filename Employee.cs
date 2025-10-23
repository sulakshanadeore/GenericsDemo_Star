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
        new Employee{ Empid=101,EmpName="Tim",Deptno=20},
        new Employee{ Empid=102,EmpName="Tim",Deptno=30},
        new Employee{ Empid=103,EmpName="Jack",Deptno=30},
        new Employee{ Empid=104,EmpName="Jill",Deptno=30}

         };

        public Employee FindFirstMatch(string name)
        {
            Employee firstmatch = empList.FindAll(item => item.EmpName == name).FirstOrDefault();

            //IEnumerable<Employee> firstmatch = empList.FindAll(item => item.EmpName == name).Skip(1).Take(1);
            //Employee empSingle=firstmatch.Single();

            Employee firstmatch = empList.FindAll(item => item.EmpName == name).Skip(1).Take(1).Single();
           


            return firstmatch;

        }


        public List<Employee> FindAllEmployeesWithSameName(string name)
        { 
            List<Employee> matchingnames=empList.FindAll(item=>item.EmpName==name);
            return matchingnames;
        
        
        }


        public void NewEmployee(Employee employee) { 
        empList.Add(employee);  

        }


        public List<Employee> GetAllEmpList()
        {
            return empList;
        
        }

        public void DeleteEmployee(int empid)
        {
            Employee obj = empList.Find(item => item.Empid == empid);
            if (obj != null)
            {
                empList.Remove(obj);
            }
            else
            {
                Console.WriteLine($"Not found employeeid= {empid}");
            }

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
        public Employee FindEmployee(int empid) {
            Employee obj = empList.Find(item => item.Empid == empid);
            if (obj != null)
            {
                return obj;
            }
            else { Console.WriteLine("not found..."); }
            return null;
        }

    
    }
}
