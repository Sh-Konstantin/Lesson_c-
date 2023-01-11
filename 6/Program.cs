Console.Clear();
//Console.SetCursorPosition(10,4);
//Console.WriteLine ("*");


int xa = 30, ya = 15, xb = 30, yb = 30, xc = 1, yc = 30;

int x = xa, y = xb;
int count = 0;

while (count<10000)
{

    int vfvf = new Random().Next(0,3);
    if  (vfvf == 0)
    {

        x = (x + xa) / 2;
        y = (y + ya) / 2;
        

    }
    if (vfvf ==1)
    {

        x = (x + xb) / 2;
        y = (y + yb) / 2;
        
    }
    if (vfvf ==2)
    {

        x = (x + xc) / 2;
        y = (y + yc) / 2;
    
    }
    Console.SetCursorPosition(x,y);
    Console.WriteLine ("*");
    count++;
}