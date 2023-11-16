
namespace TCPData
{
    public class Data
    {

        public static List<Employee> GetEmployees() => new List<Employee>() {
            new Employee()
            {
                Id=1,
                AnnualSalary=10000,
                DepartmentId=1,
                FirstName="Bob",
                IsManager=true,
                LastName="Odinkirk",
            },
            new Employee()
            {
                Id=4,
                AnnualSalary=1230000,
                DepartmentId=1,
                FirstName="Aditya",
                IsManager=true,
                LastName="Shah",
            },
                new Employee()
            {
                Id=2,
                AnnualSalary=5610000,
                DepartmentId=2,
                FirstName="Patick",
                IsManager=false,
                LastName="Batman",
            },
                new Employee()
            {
                Id=3,
                AnnualSalary=10345000,
                DepartmentId=3,
                FirstName="Synthia",
                IsManager=false,
                LastName="Roberts",
            },
        };

        public static List<Department> GetDepartments() => new List<Department>()
        {
            new Department()
            {
                Id = 1,
                LongName="Information Techonology",
                ShortName="IT"

            },new Department()
            {
                Id = 2,
                LongName="Human Techonology",
                ShortName="HT"

            },new Department()
            {
                Id = 3,
                LongName="Animal Techonology",
                ShortName="IT"

            },new Department()
            {
                Id = 4,
                LongName="Artificial Intelligence",
                ShortName="AI"

            },new Department()
            {
                Id = 5,
                LongName="Human Resource",
                ShortName="HR"

            },
        };
    }
}
