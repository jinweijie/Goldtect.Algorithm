namespace Goldtect.Algorithm
{
    class BubbleSortAlgorithm
    {
        public static void Sort(ref int[] arr)
        {
            int temp;
            for (int i = arr.Length - 1; i > 0; i--)
            {
                for (int j = 0; j <= i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
    }
}
