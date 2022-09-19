Console.WriteLine("Введите число 1: ");
int num1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int num2=Convert.ToInt32(Console.ReadLine());

bool isAliq(int n1, int n2)
{
   return n1%n2==0;    
}

if (isAliq(num1,num2)) Console.WriteLine($"{num1} кратно {num2}");
else Console.WriteLine($"{num1} Не кратно {num2}, остаток {num1%num2}");

// if (num1%num2==0)
// {
//     Console.WriteLine("Кратно");
// }
// else
// {
//     int second=num1%num2;
//     Console.WriteLine($"Не кратно, остаток {second}");
// }