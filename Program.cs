//Time Complexity is O(n^2) and space Complexity is O(1)

int[] arr = { -4, 5, 10, 8, -10, -6, -4, -2, -5, 3, 5, -4, -5, -1, 1, 6, -7, -6, -7, 8 };

Console.WriteLine("Unsorted Array");
Console.WriteLine("{" + string.Join(", ", arr) + "}");

int[] sortedArra = BubbleSort(arr);

Console.WriteLine("Sorted Array with Bubble sort");
Console.WriteLine("{" + string.Join(", ", sortedArra) + "}");

int[] BubbleSort(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[i] > array[j])
            {
                // If the current element is greater than the next element, swap them
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }
    }

    return array;
}