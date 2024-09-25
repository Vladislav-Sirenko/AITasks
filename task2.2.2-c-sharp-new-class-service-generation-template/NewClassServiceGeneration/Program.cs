using NewClassServiceGeneration;
using System.Diagnostics.CodeAnalysis;

namespace NewMethodCreation
{
    [ExcludeFromCodeCoverage]
    internal class Program
    {
        protected Program() { }
        static void Main(string[] args)
        {
            var fullTimeEmployee = EmployeeFactory.CreateEmployee("FullTime");
            var partTimeEmployee = EmployeeFactory.CreateEmployee("parttime");
            var temporaryEmployee = EmployeeFactory.CreateEmployee("temporary");
            var contractor = EmployeeFactory.CreateEmployee("contractor");

            if (fullTimeEmployee != null) { fullTimeEmployee.Display(); }
            if (partTimeEmployee != null) { partTimeEmployee.Display(); }
            if (temporaryEmployee != null) { temporaryEmployee.Display(); }
            if (contractor != null) { contractor.Display(); }


            Console.ReadLine();
        }
    }
}