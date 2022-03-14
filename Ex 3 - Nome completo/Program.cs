Console.WriteLine("Informe seu nome:");
string name = Console.ReadLine();
Console.WriteLine("Informe seu sobrenome:");
string lastName = Console.ReadLine();

string fullName = $"O nome completo do usuário é {name} {lastName}";
Console.WriteLine(fullName);