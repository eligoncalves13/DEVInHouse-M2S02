static double GradeAverage(double[] numbers){
    double avarage;
    double sum = 0;
    int count = 0;
            
    for(int i = 0; i < 30; i++)
        {             
            sum += numbers[i];
            count++;
        }

    avarage = sum/count;

    return avarage;
}

double[] numbers = new double[30];
Random random = new Random();
double classAvarage;

Console.WriteLine("Notas da turma: ");
for(int i = 0; i < 30; i++)
    {
        double randomNumber = random.Next(0, 11);
        numbers[i] = randomNumber;
        Console.WriteLine(numbers[i]);
    }

classAvarage = GradeAverage(numbers);

Console.WriteLine($"Média da Turma: {classAvarage:F2}");

double maxValue = numbers.Max();
Console.WriteLine($"Maior nota da turma: {maxValue}");
double minValue = numbers.Min();
Console.WriteLine($"Menor nota da turma: {minValue}");