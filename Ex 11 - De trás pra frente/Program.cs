using System;
using System.Globalization;

int count = 0;
Console.WriteLine("Informe quantos números deseja inserir no array: ");
count = Convert.ToInt32(Console.ReadLine());

int i = 0;
int[] numbers =  new int[count];

if(count > 0){
    while(i < count){
        Console.WriteLine($"Informe o número {i+1}: ");
        numbers[i] = Convert.ToInt32(Console.ReadLine());
        i++;
    }

    Console.WriteLine("Números ao digitados: ");
    for(int j = 0; j < count; j++){
        Console.WriteLine(numbers[j]);
}
    Console.WriteLine("Números ao contrário: ");
    for(int k = count-1; k >= 0; k--){
        Console.WriteLine(numbers[k]);
    }
}
 

        


