Console.WriteLine("Digite seu nome: ");
string name = Console.ReadLine();

string nameReversed = new string(name.Reverse().ToArray());
Console.WriteLine($"Nome invertido: {nameReversed}");
Console.WriteLine($"Total de letras: {name.Length}");