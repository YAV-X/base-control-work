// string[] array = { "1234", "1567", "-2", "computer science" };
// string[] array = { "Russia", "Denmark", "Kazan" };
string[] array = { "Hello", "2", "world", ":-)", "qwerty", "123", "мир" };

// Подсчет кол-ва элементов в новом массиве
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        count++;
    }
}

// Создание нового массива
string[] new_arr = new string[count];

// Заполнение нового массива
int index = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        new_arr[index] = array[i];
        index++;
    }
}

// Вывод нового массива
for (int i = 0; i < new_arr.Length; i++)
{
    Console.WriteLine(new_arr[i]);
}
