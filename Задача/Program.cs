Console.WriteLine("введите размер массива");
int SizeMas = int.Parse(Console.ReadLine()!);


string[] mas = new string[SizeMas];
int SizeFinishMas = 0;
for (int i = 0; i < SizeMas; i++) //Внутри этого цикла вводиться текст с клавиатуры для каждого элемента массива
{
    Console.WriteLine("Введите текст");
    mas[i] = Console.ReadLine()!; ;
    if (mas[i].Length <= 3) SizeFinishMas += 1; //определяется размер итогового массива

}
Console.WriteLine($"[{String.Join(", ", mas)}]");
Console.WriteLine($"Размер итогового массива = {SizeFinishMas}");

string[] FinishMas = new string[SizeFinishMas];
int K = 0;
for (int i = 0; i < SizeMas; i++)// в итоговый массив вносятся элементы из первого согласно условию задачи
{
    if (mas[i].Length <= 3)
    {
        FinishMas[K] = mas[i];
        K += 1;
    }
}
Console.WriteLine($"[{String.Join(", ", FinishMas)}]");


////////////////////////////////////Другой способ//////////////////////////////



// Console.WriteLine("введите размер массива");
// int SizeMas = int.Parse(Console.ReadLine()!);
// string[] FinishMas = CreatMas(SizeMas);
// PrintMas(FinishMas);

// SizeFinishMas(FinishMas);
// int SizeFin = SizeFinishMas(FinishMas);
// Console.WriteLine($"Размер итогового массива = {SizeFin}");

// string[] FinishMasFin = CreatFinishMas(FinishMas, SizeFin);
// PrintMas(FinishMasFin);


//////////////////////////////////////////////////////

// string[] CreatMas(int SizeMas)
// {
//     string[] mas = new string[SizeMas];
//     for (int i = 0; i < SizeMas; i++)
//     {
//         Console.WriteLine("Введите текст");
//         mas[i] = Console.ReadLine()!;
//     }
//     return mas;
// }

// void PrintMas(string[] mas)
// {
//        Console.WriteLine($"[{String.Join(", ", mas)}]");
// }

// int SizeFinishMas(string[] mas)
// {
//     int SizeFinishMas = 0;
//     for (int i = 0; i < mas.Length; i++)
//     {
//         if (mas[i].Length <= 3) SizeFinishMas += 1;
//     }
//     return SizeFinishMas;
// }

// string[] CreatFinishMas(string[] mas, int size)
// {
//     string[] FinMas = new string[size];
//     int K = 0;
//     for (int i = 0; i < mas.Length; i++)
//     {
//         if (mas[i].Length <= 3) 
//         {
//             FinMas[K] = mas[i];
//             K += 1;
//         }
//     }
//     return FinMas;
// }
