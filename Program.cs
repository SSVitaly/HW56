void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(0, 11);
        }
    }
}

int rows = 5;
int coloms = 4;
int[,] Array = new int[rows, coloms];
FillArray(Array);
PrintArray(Array);
int[] Sum = new int[rows];
int number = 0;
for (int i = 0; i < Array.GetLength(0); i++)
{
    for (int j = 0; j < Array.GetLength(1); j++)
    {
        Sum[i] += Array[i, j];
    }
}
int max = Sum[0];
for (int i = 0; i < Sum.Length; i++)
{
    if (Sum[i] > max)
    {
        max = Sum[i];
        number = i;
    }
}
Console.WriteLine($"Строка с максимальной суммой элементов: {number}");