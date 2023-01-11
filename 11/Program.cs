int[] arr = {5,3,7,9,6,1,4,8,3};

void PrintArray(int [] array)
{
    int count = array.Length;
    for (int i=0; i<count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SellectionSort(int[] array)
{
     for (int i=0; i<array.Length-1; i++)
     {
        int minPos = i;        
        for (int j=i+1; j<array.Length; j++)
        {
            if (array[j] < array[minPos] ) minPos = j;
        }
        int temporary = array[i]; 
        array[i] = array[minPos];
        array[minPos] = temporary;
     }
}

PrintArray (arr);
SellectionSort(arr);

PrintArray (arr);  