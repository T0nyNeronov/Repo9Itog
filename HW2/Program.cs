// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных
// элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.WriteLine("Введите начальное число N ");
int n=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите конечное число M ");
int m =Convert.ToInt32(Console.ReadLine());


int SumNum (int m)
{
    if (n==m)
    {
        return n;
    }
    else if (m>n)
    {
      return(m+SumNum(m-1));     
    }
     else
     {
       return(m+SumNum(m+1));      
     }
    
}

Console.WriteLine("Сумма натуральных элемтов в промежутке равна " +SumNum(m));
