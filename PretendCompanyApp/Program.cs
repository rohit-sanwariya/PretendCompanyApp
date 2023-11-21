using TCPData;
using TCPExtensions;
namespace PretendCompanyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();
            list = Data.GetEmployees();
            List<Employee> managers =  list.CoFilter(emp => emp.IsManager);
            foreach (Employee emp in managers) {
                Console.WriteLine(emp.FirstName);
            }
            decimal averagSalary = managers.Average(m => m.AnnualSalary);
            Console.WriteLine(averagSalary);
        }

    }
}