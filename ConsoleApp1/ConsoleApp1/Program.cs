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
<<<<<<< Updated upstream
Console.WriteLine("AGAIN Here we have the world");

static double ObliczSrednia(int[] tablica)
{
    if (tablica == null || tablica.Length == 0)
    {
        throw new ArgumentException("Tablica nie może być pusta");
    }

    double suma = 0;
    foreach (int liczba in tablica)
    {
        suma += liczba;
    }
    return suma / tablica.Length;
}
=======
Console.WriteLine("AGAIN Here we have the world");
>>>>>>> Stashed changes
