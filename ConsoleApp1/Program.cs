static double AverageValue(int[] arr)
{
    int sum = 0;
    foreach (int i in arr)
    {
        sum += i;
    }

    return (double)sum / arr.Length;
}

static int MaxValue(int[] arr)
{
    Console.WriteLine("No way!!!");
    int max = 0;
    foreach (int i in arr)
    {
        if (max < i)
        {
            max = i;
        }

        
    }

    return max;
}