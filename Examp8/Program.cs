int Max(int arg1, int arg2, int arg3)
{
    int res =arg1;
    if (arg2> res) res = arg2;
    if (arg3> res) res = arg3;
    return res;
}


int a1 = 12;
int b1 = 47;
int c1 = 12;
int a2 = 16;
int b2 = 49;
int c2 = 99;
int a3 = 1;
int b3 = 67;
int c3 = 65;

int max1 = Max (a1, b1, c1);
int max2 = Max (a2, b2, c2);
int max3 = Max (a3, b3, c3);
int max = Max (max1, max2, max3);
Console.WriteLine (max);