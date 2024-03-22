// See https://aka.ms/new-console-template for more information
Console.WriteLine("This time it's not the world");
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}
Console.WriteLine("Here we have the world");
for (int a = 1; a <= 10; a++)
{
    Console.WriteLine(a);
}
Console.WriteLine("AGAIN Here we have the world");
static int ZnajdzMax(int[] tablica)
{
    if (tablica == null || tablica.Length == 0)
    {
        throw new ArgumentException("Tablica nie może być pusta");
    }

    int maksymalnaWartosc = tablica[0];
    foreach (int liczba in tablica)
    {
        if (liczba > maksymalnaWartosc)
        {
            maksymalnaWartosc = liczba;
        }
    }
    return maksymalnaWartosc;
}