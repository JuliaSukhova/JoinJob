Console.WriteLine("Введите value: ");

// int value = 14;
int value = Convert.ToInt32(Console.ReadLine());

if (value % 7 == 0 && value % 23 == 0)
{
  Console.WriteLine("YES");
}
else
{
  Console.WriteLine("NO");
}