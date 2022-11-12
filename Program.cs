// числа в промежутке от N до 1.


/*
void ShowNumbers(int n)
{
    if(n <= 0)
    {
        Console.WriteLine($"{n} <- не натуральное число");
    }
    Console.Write(" " + n);
    if (n > 1) ShowNumbers(n-1);
            
}
Console.WriteLine("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());
ShowNumbers(n);

*/

// сумма натуральных элементов в промежутке от M до N.

/*

int SumNumbers(int m, int n)
{
    int sum = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        sum = m + SumNumbers(m, n);
        return sum;
    }
}
Console.WriteLine("Введите первое число:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int n = Convert.ToInt32(Console.ReadLine());
SumNumbers(m, n);
Console.Write($"Сумма натуральных элементов в промежутке от {m} до {n} -> ");
Console.Write(SumNumbers(m - 1, n));

*/


//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29


int FunciaAkkermana(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else 
        if (n == 0 && m > 0)
        {
            return FunciaAkkermana(m - 1, 1);
        }
    else
    {
        return (FunciaAkkermana(m - 1, FunciaAkkermana(m, n - 1)));
    }
}

Console.WriteLine("Введите первое число:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int n = Convert.ToInt32(Console.ReadLine());

FunciaAkkermana(m,n);
Console.Write("Функция Аккермана равна: ");
Console.Write(FunciaAkkermana(m, n));

