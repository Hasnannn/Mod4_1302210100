// See https://aka.ms/new-console-template for more information
using System;

class KodeBuah
{
    private readonly Dictionary<string, string> NamaBuah = new Dictionary<string, string> {
        {"Apel", "A00"}, {"Aprikot","B00"}, {"Alpukat", "C00"}, {"Pisang", "D00"},
        {"Paprika","E00"}, {"Blackberry", "F00"}, {"Ceri", "H00"}, {"Kelapa", "I00"},
        {"Jagung", "J00"}};

    public string GetKodeBuah(string Id)
    {
        if (KodeBuah.TryGetValue(Id, out string Kode))
        {
            return string.Empty;
        }
        else
        {
            return Kode;
        }
    }
}
class MainProgram
{
    static void Main(string[] args)
    {
        KodeBuah KodeBuah = new KodeBuah();

        string Buahan = KodeBuah.GetKodeBuah("Apel");
        Console.WriteLine(Buahan);

    }
}
