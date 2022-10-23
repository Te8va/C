using System;
Console.WriteLine("Введите a и b (a>b):");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int q,r,x=0,x2=1,x1=0,y=1,y1=1,y2=0;
if (a>b) {
while (b>0)
{
    q=a/b;
    r=a-q*b;
    x=x2-q*x1;
    y=y2-q*y1;
    a=b;
    b=r;
    x2=x1;
    x1=x;
    y2=y1;
    y1=y;
}
Console.WriteLine($"НОД {a}");
Console.WriteLine($"Коэффициент перед большим числом {x2}");
Console.WriteLine($"Коэффициент перед меньщим числом  {y2}");
Console.WriteLine($"{a}=a*{x2}+b*{y2}");
}
else {
    Console.WriteLine("Неверные данные");
}
Console.ReadKey();
