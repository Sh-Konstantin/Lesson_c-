int Max (int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2>result) result=arg2;
    if (arg3>result) result=arg3;
    return result; 
}
int a1 = 161515;
int b1 = 181516;
int c1 = 135233;
int a2 = 9956;
int b2 = 66;
int c2 = 12323;
int a3 = 336;
int b3 = 636;
int c3 = 9999999;


//int Max1 = Max(a1,b1,c1);
//int Max2 = Max(a2,b2,c2);
//int Max3 = Max(a3,b3,c3);
int Max4 = Max(Max(a1,b1,c1),Max(a2,b2,c2),Max(a3,b3,c3));

Console.WriteLine(Max4);