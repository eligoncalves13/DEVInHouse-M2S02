var name = "Raffa";

TypeCode type = Type.GetTypeCode(name.GetType());

Console.WriteLine($"A variável {name} é do tipo {type}");