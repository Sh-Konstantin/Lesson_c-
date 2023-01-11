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
        int MAXPos = i;        
        for (int j=i+1; j<array.Length; j++)
        {
            if (array[j] > array[MAXPos] ) MAXPos = j;
        }
        int temporary = array[i]; 
        array[i] = array[MAXPos];
        array[MAXPos] = temporary;
     }
}

PrintArray (arr);
SellectionSort(arr);

PrintArray (arr);  