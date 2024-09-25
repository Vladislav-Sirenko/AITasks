using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewClassServiceGeneration
{
    public class TemporaryEmployee : IEmployee
    {
        public double HourlyRate => 20;

        public string Display()
        {
            return $"Temporary Employee with hourly rate {HourlyRate}";
        }
    }
}
