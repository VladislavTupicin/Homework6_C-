// Пользователь вводит с клавивтуры М чисел.
// Посчитайте, сколько чисел больше 0 ввел пользователь.
//0, 7, 8, -2, -2 -> 2
//-1, -7, 567, 89, 223 -> 3

Console.Clear();

Console.Write("Введи количество чисел: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] massiveNumbers = new int[m];

void InputNumbers(int m)
{
    for (int i = 0; i < m; i++)
    {
        Console.Write($"Введи {i+1}-ое число: ");
        massiveNumbers[i] = Convert.ToInt32(Console.ReadLine());
    }
}

int Comparison(int[] massiveNumbers)
{
    int count = 0;
    for (int i = 0; i < massiveNumbers.Length; i++)
    {
        if(massiveNumbers[i] > 0 )
        {
            count += 1;
        } 
    }
    return count;
}

InputNumbers(m);

Console.WriteLine($"Введено чисел больше 0 = {Comparison(massiveNumbers)} ");
