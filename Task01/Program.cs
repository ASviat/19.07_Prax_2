int num=new Random().Next(10,100);
Console.WriteLine($"Случайное число равно: {num}");
int firstDigit=num/10;
int secondDigit=num%10;
if (firstDigit>secondDigit) Console.WriteLine($"=>{firstDigit}");
else Console.WriteLine($"=>{secondDigit}");