double[] grades = new double[4];

for(int i = 1; i <= 3; i++) {
    Console.WriteLine($"Informe a nota {i}");
    grades[i] = Convert.ToDouble(Console.ReadLine());
}

double sum = 0;
int count = 0;

for(int i = 1; i <= 3; i++) {
    sum += grades[i];
    count++;
}

double avarage = sum/count;

Console.WriteLine($"Sua média final é {avarage:F2}");
