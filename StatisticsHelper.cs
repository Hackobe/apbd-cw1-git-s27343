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

    public static int CalculateMax(int[] values)
    {
        if (values.Length == 0)
        {
            throw new ArgumentException("Tablica nie może być pusta.");
        }

        int max = values[0];

        for (int i = 1; i < values.Length; i++)
        {
            if (values[i] > max)
            {
                max = values[i];
            }
        }

        return max;
    }

    public static int CalculateMin(int[] values)
    {
        if (values.Length == 0)
        {
            throw new ArgumentException("Tablica nie może być pusta.");
        }

        int min = values[0];

        for (int i = 1; i < values.Length; i++)
        {
            if (values[i] < min)
            {
                min = values[i];
            }
        }

        return min;
    }
}