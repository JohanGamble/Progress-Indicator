namespace ProgressTask.Model
{
    public class ProgressMeterModel
    {
        public int Completed;
        public int Total;
        public string Status;
        public string Percent;

        public ProgressMeterModel()
        {
            Completed = 0;
            Total = 0;
            Status = "Unknown";
            Percent = "Unknown";
        }
    }
}