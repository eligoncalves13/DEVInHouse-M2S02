int number;
int factorial = 1;

do {
    Console.WriteLine("Digite um número inteiro de 0 a 10: ");
    number = Convert.ToInt32(Console.ReadLine());
} while(number < 0 || number > 10);

for(int i = number; i > 1; i--) {
    factorial *= i;
}

Console.WriteLine($"Fatorial de {number} é {factorial}");
