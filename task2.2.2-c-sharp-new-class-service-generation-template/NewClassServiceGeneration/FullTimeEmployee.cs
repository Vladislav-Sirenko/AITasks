using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewClassServiceGeneration
{
    public class FullTimeEmployee : IEmployee
    {
        public double HourlyRate => 35;

        public string Display()
        {
            return $"FullTime Employee with hourly rate {HourlyRate}";
        }
    }
}
