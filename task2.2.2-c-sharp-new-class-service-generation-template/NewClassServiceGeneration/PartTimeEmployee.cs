using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewClassServiceGeneration
{
    public class PartTimeEmployee : IEmployee
    {
        public double HourlyRate => 25;

        public string Display()
        {
            return $"PartTime Employee with hourly rate {HourlyRate}";
        }
    }
}
