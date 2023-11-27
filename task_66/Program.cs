//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

//Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
//M = 1; N = 5. -> "1, 2, 3, 4, 5"
//M = 4; N = 8. -> "4, 6, 7, 8"

Console.Write("Введите число M : ") ;
int M = Convert.ToInt32(Console.ReadLine()) ;
Console.Write("Введите число N : ") ;
int N = Convert.ToInt32(Console.ReadLine()) ;
string PrintNumbers (int start, int end) 
{
    if (start == end) return start.ToString() ;
    if (start <= 0 && end <= 0) 
    {
        Console.WriteLine("Числа M и N должны быть больше 0") ;
        return (start.ToString() + " и " + end.ToString() + " < 0 - Введённые значения - недопустимы.") ;
    } 
    if (start > end) 
    {
        Console.WriteLine("Число M должно быть меньше, чем число N") ;
        return (start.ToString() + " > " + end.ToString() + " - Введённые значения - недопустимы.") ;
    } 
    if (start <= 0 && end > 0) 
    {
        start = 1 ;
    } 
    int summ = start + Convert.ToInt32(PrintNumbers(start + 1, end)) ; 
    return summ.ToString() ;
} 
Console.WriteLine(PrintNumbers(M,N)) ;

