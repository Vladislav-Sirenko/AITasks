namespace NewClassServiceGeneration
{
    public class Contractor : IEmployee
    {
        public double HourlyRate => 40;

        public string Display()
        {
            return $"Contractor with hourly rate {HourlyRate}";
        }
    }
}
