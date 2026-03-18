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

    public static double CalculateMax(int[] values)
    {
        if (values.Length == 0 || values == null)
        {
            return 0;
        }
	
        double max = 0;
        foreach (var value in values)
        {
            if (value > max)
            {
                max = value;
            }
        }

        return max;
    }
    public static int CalculateMin(int[] values)
    {
        if (values == null || values.Length == 0)
        {
            return 0;
        }
        
        int min = values[0];
        foreach (var val in values)
        {
            if (val < min) min = val;
        }
        return min;
    }
}
