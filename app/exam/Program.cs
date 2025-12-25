


using exam.Classes;

Console.Write("Введите количество чисел: ");
int count = int.Parse(Console.ReadLine());
int[] array = new int[count];
for (int i = 0; i < count; i++)
{
    Console.Write($"Введите {i + 1} - е число: ");
    array[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("Ввод завершен!!!");
array = Method.MnojChisel(array);
for(int i = 0;i < array.Length;i++)
{
    Console.Write(array[i] + " ");
}
