int[] a = {34, 88, 17, 5, 99, 78, 25, 94, 76, 55};
int s = 0;
int p = 0;
int k  = 0;
int n = 101;
for (int i = 0; i < 10; i++)
{
    if (a[i] < n)
    {
        n = a[i];
    }
    if (a[i] > s)
    {
        s = a[i];
    }
    p = p +a[i];
    k=k+1;

}
Console.WriteLine(n);
Console.WriteLine(s);
Console.WriteLine(p);
Console.WriteLine(k);
Console.WriteLine(p/k-(s+n)/2);