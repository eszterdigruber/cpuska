//Sima csere:
int[] array = { 1, 5, 7, 3, 8 };
int tempnm;
for (int i = 0; i < array.Length; i++)
{
    for (int j = 0; j < array.Length - 1; j++)
    {
        if (array[j] > array[j + 1])
        {
            tempnm = array[j];
            array[j] = array[j + 1];
            array[j + 1] = tempnm;
        }
    }
}

//Buborék:
Random rnd = new Random();
int[] genarray = new int[5];
for (int i = 0; i < 5; i++)
{
    genarray[i] = rnd.Next(10, 20);
}
int ll = genarray.Length;
int csere2;
for (int i = ll - 1; i > 0; i--)
{
    for (int j = 0; j < i; j++)
    {
        if (genarray[j] > genarray[j + 1])
        {
            csere2 = genarray[j];
            genarray[j] = genarray[j + 1];
            genarray[j + 1] = csere2;
        };
    };
};

//n-1 csere, ha a[i] > a[i + 1]:
int[] a = new int[5];
for (int i = 0; i < 5; i++)
{
    a[i] = rnd.Next(10, 20);
}
int n = a.Length;
int tmp;
for (int j = 0; j < n - 1; j++)
{
    if (a[j] > a[j + 1])
    {
        tmp = a[j];
        a[j] = a[j + 1];
        a[j + 1] = tmp;
    }
}

//(n - 1) * (n - 1), ha a[i] > a[i + 1];
int[] b = new int[5];
for (int i = 0; i < 5; i++)
{
    b[i] = rnd.Next(10, 20);
}
int m = b.Length;
int tmpn;
for (int i = 0; i < n - 1; i++)
{
    for (int j = 0; j < n - 1; j++)
    {
        if (b[j] > b[j + 1])
        {
            tmpn = b[j];
            b[j] = b[j + 1];
            b[j + 1] = tmpn;
        }
    }
}