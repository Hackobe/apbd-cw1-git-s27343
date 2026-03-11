Console.WriteLine("Podaj liczby całkowite oddzielone przecinkami:");
string? input = Console.ReadLine();

if (string.IsNullOrWhiteSpace(input))
{
    Console.WriteLine("Nie podano danych.");
    return;
}

string[] parts = input.Split(',');
int[] values = new int[parts.Length];

for (int i = 0; i < parts.Length; i++)
{
    values[i] = int.Parse(parts[i].Trim());
}

Console.WriteLine("Dane zostały poprawnie wczytane.");