using System.Collections.Specialized;

int[] N = { 1, 2, 3, 4, 5 };
int summ = 0;

foreach (int M in N)
{
   Console.WriteLine(M);
   summ += M;
}
Console.WriteLine(summ);



string[] days = { "Понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье" };

string g = "!";

foreach (string F in days)
{
   Console.WriteLine($"{F}{g}");
}



string[] name = { "аня", "ваня", "илья", "антон" };
int numb = 1;

foreach (string names in name)
{
   Console.WriteLine($"{numb}. {names}");
   numb++;
}



string i = Console.ReadLine();

for (int l = i.Length - 1; l >= 0; l--)
{
   Console.Write(i[l]);
}
