using ProgressTask.Model;
using ProgressTask.Actions;

namespace ProgressDisplay
{
    public class ProgressResults
    {
        public static void Counter(ProgressMeterModel progressMeterModel, int countUpTo)
        {
            progressMeterModel.Total = countUpTo;

            for (int idxNumbers = 1; idxNumbers <= countUpTo; idxNumbers++)
            {
                progressMeterModel.Completed = idxNumbers;
                progressMeterModel.Status = "Processing...";
                progressMeterModel.Percent = (progressMeterModel.Completed * 100 / progressMeterModel.Total).ToString();
                if (progressMeterModel.Total == progressMeterModel.Completed)
                {
                    progressMeterModel.Status = "Completed";
                }
                ProgressTaskHub.SendServerData(progressMeterModel);
            }
        }
    }
}