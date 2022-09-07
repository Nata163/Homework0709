// программа, которая принимает на вход число N и выдает таблицу кубов чисел от 1 до N с помощью массива

int[] GetCubeNumbers(int num)
{
    int[] cubeNumbers = new int[num];

    for (int i = 1; i <= num ; i++)
    {
        cubeNumbers[i-1] = i * i * i;
    }
    return cubeNumbers;
}

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

int[] result = GetCubeNumbers(num);
for (int i = 0; i < result.Length; i++) 
{
    Console.WriteLine(result[i]);
}
