namespace EmployeeProject.Model
{
    public interface IEmployee
    {
        public List<Employee> GetAllEmployee();
        public Employee GetEmployeeById(int id);
        public Employee GetEmployeeByName(string name);



        public void  AddEmployee(Employee employee);

        public void UpdateEmployee(int id , Employee employee);

        public void DeleteEmployee(int id);

    }

    public class EmployeeRepostory : IEmployee
    {
        public List<Employee> employees = new List<Employee>
        {
            new Employee {EmployeeId = 1 , EmployeeName="Thameem" ,EmployeeAge=20, EmployeeEmail="Thameemp@gmail.com",EmployeePhone=1234567890},
            new Employee {EmployeeId = 2 ,EmployeeName="Shamil",EmployeeAge=22,EmployeeEmail="Shamilpn@gmail.com",EmployeePhone=2234567890}
        };

        public List <Employee>  GetAllEmployee()
        {
            return employees;
        }
        public Employee GetEmployeeById(int id)
        {
            var EmpById = employees.FirstOrDefault(x => x.EmployeeId == id);
            return EmpById;
        }
        public Employee GetEmployeeByName(string name)
        {
            var EmpByName = employees.FirstOrDefault(y => y.EmployeeName == name);
            return EmpByName;
        }


        public void AddEmployee(Employee employee)
        {
            employee.EmployeeId = employees.Count+1;
            employees.Add(employee);
        }


        public void UpdateEmployee(int id, Employee employee)
        {
            var Updemployee = employees.FirstOrDefault(Z=> Z.EmployeeId == id);
            Updemployee.EmployeeName = employee.EmployeeName;
            Updemployee.EmployeeAge = employee.EmployeeAge;
            Updemployee.EmployeeEmail = employee.EmployeeEmail;
            Updemployee.EmployeePhone = employee.EmployeePhone;
        }

        public void DeleteEmployee(int id)
        {
            var DelEmp=employees.FirstOrDefault(V=>V.EmployeeId == id);
            employees.Remove(DelEmp);
        }
    }
}
