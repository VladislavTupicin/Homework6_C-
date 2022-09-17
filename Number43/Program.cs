// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
double[,] coefficient = new double[2, 2];
double[] crossPoint = new double[2];

void InputCoefficients()
{
    for (int i = 0; i < coefficient.GetLength(0); i++)
    {
        Console.Write($"Введите коэффициенты {i+1}-го уравнения (y = k * x + b):\n");
        for (int j = 0; j < coefficient.GetLength(1); j++)
        {
            if(j==0)
            {
                Console.Write($"Введите коэффициент k: ");
                coefficient[i,j] = Convert.ToInt32(Console.ReadLine());
            }
            else
            {
                Console.Write($"Введите коэффициент b: ");
                coefficient[i,j] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}

double[] Decision(double[,] coefficient)
{
    crossPoint[0] = (coefficient[1,1] - coefficient[0,1]) / (coefficient[0,0] - coefficient[1,0]);
    crossPoint[1] = crossPoint[0] * coefficient[0,0] + coefficient[0,1];
    return crossPoint;
}

void OutputResponse(double[,] coefficient)
{
    if (coefficient[0,0] == coefficient[1,0] && coefficient[0,1] == coefficient[1,1]) 
    {
        Console.Write("Прямые совпадают");
    }
    else if (coefficient[0,0] == coefficient[1,0] && coefficient[0,1] != coefficient[1,1]) 
    {
        Console.Write("Прямые параллельны");
    }
    else 
    {
        Decision(coefficient);
        Console.Write($"Точка пересечения прямых: ({crossPoint[0]}, {crossPoint[1]})");
    }
}

InputCoefficients();
OutputResponse(coefficient);