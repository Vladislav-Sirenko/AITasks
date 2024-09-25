using System;

namespace NewClassServiceGeneration
{
    public class EmployeeFactory
    {
        public static IEmployee CreateEmployee(string type)
        {
            if (string.IsNullOrEmpty(type))
                throw new ArgumentException("Type cannot be empty", nameof(type));

            switch (type)
            {
                case "FullTime":
                    return new FullTimeEmployee();
                case "PartTime":
                    return new PartTimeEmployee();
                case "Temporary":
                    return new TemporaryEmployee();
                case "Contractor":
                    return new Contractor();
                default:
                    throw new NotSupportedException($"Cannot create employee of type {type}");
            }
        }
    }
}