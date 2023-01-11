// int [] array = {4,465,464,1853,154,654,659};
// int n = array.Length;
// int find = 464; 

// int index = 0;

// while (index < n )
// {
//     if (array[index]==find)
//     {

//         Console.WriteLine (index); 
//         break;
//     }
//     index++;

// }

void NewMethod  (int [] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index<length)
    {
        collection[index] = new Random().Next(1,10);  
        index++;
    }
}

void PrintMethod (int [] coll)
{
    int count = coll.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(coll[position]);
        position++;
    }
}

int IndexOf (int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;

    while (index<count)
    {
        if(collection[index] == find)
        {

            position = index;
            break;
            
        }
        index++;

    }
    return position;


}



int [] array = new int [10];   

NewMethod(array);
PrintMethod(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);
