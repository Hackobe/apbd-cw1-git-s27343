public static class StatisticsHelper
{
    public static double CalculateAverage(int[] values)
    {
        if (values.Length == 0)
        {
            throw new ArgumentException("Tablica nie może być pusta.");
        }

        int sum = 0;

        for (int i = 0; i < values.Length; i++)
        {
            sum += values[i];
        }

        return (double)sum / values.Length;
    }
}