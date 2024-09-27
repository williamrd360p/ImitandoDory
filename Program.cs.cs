Console.Clear();

Console.WriteLine("Imitando dory");
string frase = Console.ReadLine()!;

string FraseEmBaleies = frase

 .Replace("a", "aaa" )
 .Replace("A", "AAA" )
 .Replace("e", "eee" )
 .Replace("E", "EEE" )
 .Replace("i", "iii" )
 .Replace("I", "III" )
 .Replace("o", "ooo" )
 .Replace("O", "OOO" )
 .Replace("u", "uuu")
 .Replace("U", "UUU")
;

Console.WriteLine($"\n em baleiês:\n\n {FraseEmBaleies}");



