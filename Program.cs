Console.WriteLine("Program do analizy liczb całkowitych.");
Console.WriteLine("Dostępne operacje: average, max, min.");
Console.WriteLine("Podaj liczby całkowite oddzielone przecinkami:");
string? input = Console.ReadLine();

if (string.IsNullOrWhiteSpace(input))
{
    Console.WriteLine("Nie podano żadnych liczb.");
    return;
}

try
{
    string[] parts = input.Split(',');
    int[] values = new int[parts.Length];

    for (int i = 0; i < parts.Length; i++)
    {
        values[i] = int.Parse(parts[i].Trim());
    }

    Console.WriteLine("Dane zostały poprawnie wczytane.");
}
catch
{
    Console.WriteLine("Błąd: podaj wyłącznie liczby całkowite oddzielone przecinkami.");
}