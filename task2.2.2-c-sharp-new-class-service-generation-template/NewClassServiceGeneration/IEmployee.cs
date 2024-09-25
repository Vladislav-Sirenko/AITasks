using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewClassServiceGeneration
{
    public interface IEmployee
    {
        double HourlyRate { get; }
        string Display();
    }
}
