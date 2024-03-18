Console.WriteLine("---------------- Imitando Dory ----------------\n");

Console.Write("Digite uma frase para ser traduzida em baleiês: ");
string frase = Console.ReadLine()!;

string tradBaleies = frase
    .Replace("a", "aaa")
    .Replace("A", "AAA")
    .Replace("e", "eee")
    .Replace("E", "EEE")
    .Replace("i", "iii")
    .Replace("I", "III")
    .Replace("o", "ooo")
    .Replace("O", "OOO")
    .Replace("u", "uuu")
    .Replace("U", "UUU")
;

Console.WriteLine($"\nEm baleiês: {tradBaleies}");