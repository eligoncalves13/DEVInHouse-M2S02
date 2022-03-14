int flavor;
int count = -1;

do {
    Console.WriteLine("Você deseja uma fatia de pizza? Envie “1” para calabresa, “2” para mussarela, “3” para portuguesa ou “0” caso esteja satisfeito.");
    flavor = Convert.ToInt32(Console.ReadLine());
    count++;
} while(flavor >= 1 && flavor <= 3);

Console.WriteLine($"Você comeu {count} fatias!");