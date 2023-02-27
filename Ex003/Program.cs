
int GetNumber(string text)
{
  Console.Write(text);
  return Convert.ToInt32(Console.ReadLine());
}

int value = GetNumber("Введите value: ");
if (value % 7 == 0 && value % 23 == 0)
{
  Console.WriteLine("YES");
}
else
{
  Console.WriteLine("NO");
}