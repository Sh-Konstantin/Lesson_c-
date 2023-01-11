int Max (int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2>result) result=arg2;
    if (arg3>result) result=arg3;
    return result; 
}
int[] array = {185,235,3123,4243,543321,63231,746578,856352,93647};


int Max4 = Max(Max(array[0],array[1],array[2]),Max(array[3],array[4],array[5]),Max(array[6],array[7],array[8])); 

Console.WriteLine(Max4);