// ввод пользователем желаемой длины массива для дальнейшей работы
Console.Write("Введите количество строк в массиве: ");
int n = int.Parse(Console.ReadLine());

// ввод отдельных строк в созданный массив
string[] arr = new string[n];
for (int i = 0; i < n; i++)
{
    Console.Write($"Введите строку {i + 1}: ");
    arr[i] = Console.ReadLine();
}

// создание пустого массива для хранения промежуточных результатов
string[] result = new string[n];
int index = 0;

// поиск строк, длина которых <= 3
for (int i = 0; i < n; i++)
{
    string s = arr[i];
    if (s.Length <= 3)
    {
        result[index++] = s;
    }
}

// вывод результата 
Console.WriteLine("Строки, длина которых меньше или равна 3:");
for (int i = 0; i < index; i++)
{
    Console.WriteLine(result[i]);
}