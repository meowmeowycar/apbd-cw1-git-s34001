namespace APBD1;

public class StatisticHelper
{
    public static double CalculateAverage(int[] values)
    {
        if (values.Length == 0 || values == null)
        {
            return 0;
        }
	
        double sum = 0;
        foreach (var value in values)
        {
            sum = sum + value;
        }

        return sum / values.Length;
    }	    
}
