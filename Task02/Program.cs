int num=new Random().Next(100,1000);

Console.WriteLine($"Введенное число: {num}");



// int num1=num/100;
// int num3=num%10;
// Console.WriteLine($"Вывод: {num1}{num3}");

int mtd(int numero)
{
    int n1=numero/100;
    int n3=numero%10;
    return n1*10+n3;
}
int result=mtd(num);
Console.WriteLine($"Вывод: {result}");