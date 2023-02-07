/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Math.Pow не использовать

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/

/*int Digit (int num_a, int num_b)
{
int dig =1;
for (int current = 1; current <= num_b; current++)
{
    dig=dig*num_a;
}
return dig;
}

Console.WriteLine ("Input your number_a");
int number_a= Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Input your number_b");
int number_b = Convert.ToInt32 (Console.ReadLine());
if ( number_b > 0)// ограничила, так как первоначально тип поставила int,если не ограничивать, 
//то при степени отрицательной результатом может быть дробное число, в этм случае, тип нужно double
{
    int res_dig= Digit ( number_a, number_b);
    Console.WriteLine ($" number {number_a} to the power {number_b} is {Digit ( number_a, number_b)} ");
}
else
{
    Console.WriteLine (" Impossible value");
}
*/
 

/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/
/*int Digits (int number)
{
    int dig=0;
    int sum=0;
    while (number>0)
    {
        dig=number%10;
        sum=sum+dig;
        number=number/10;
    }
   
    return sum;

}

Console.WriteLine ("Input your number:");
int num= Convert.ToInt32 (Console.ReadLine());

if ( num >= 0)
{
  int summa= Digits (num);
  Console.WriteLine ($" {num}  ->  summa {Digits ( num)} ");
}
else
{
    Console.WriteLine (" Impossible value");   
}
*/



/*Задача 29: Напишите программу, которая задаёт массив из произвольного колчества элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]*/
/*int [] NewArray (int size_array)
{
    int [] array= new int[size_array];
    for (int i=0;i< size_array; i++)
       {
        array[i]= new Random().Next (0,100);// диапазон мин 0, макс 99
       }
       return array;
      
}

void PrintArray (int [] array01)
{
    for (int i=0; i < array01.Length; i++)
         Console.Write (array01[i] + " ");
}

int [] array02 = NewArray (5);// количество элементов
PrintArray (array02);
*/