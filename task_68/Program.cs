//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9


public class WriteN
{
   static void Main () 
   {
    Console.Write("Введите M = ") ;
    int m = Convert.ToInt32(Console.ReadLine()) ;
    Console.Write("Введите N = ") ;
    int n = Convert.ToInt32(Console.ReadLine()) ;
    if ((m < 0 ) || (n < 0 )) 
    {
        Console.WriteLine($"Числа m = {m}; n = {n} должны быть положительные ") ;
    } 
    else
    {
        if (((n <= 12) && (m <= 3)) || ((n == 0) && (m < 6))) 
        Console.WriteLine($"Вычисления функции Аккермана при m = {m};n = {n} A({m.ToString()},{n.ToString()}) = {akkerman(m,n).ToString()}") ;
        
    
    } 
   } 
   public static int akkerman(int i, int j) 
   {
    if (i == 0) return j + 1 ;
    else if (j == 0) return akkerman(i - 1, 1) ;
    else return akkerman(i - 1, akkerman(i, j - 1)) ;
   }

} 