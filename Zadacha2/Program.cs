Console.Clear();
Console.Write("Введите  число: ");
int i = int.Parse(Console.ReadLine());
if (i < 1 || i > 7)
    {
       Console.Write("Введен неправильный номер");
       return;
    }
if (i == 1)
      {
        Console.WriteLine("Понедельник");
        return;
}
if (i == 2)
      {
        Console.WriteLine("Второник");
        return;
}
if (i == 3)
      {
        Console.WriteLine("Среда");
        return;
}
if (i == 4)
      {
        Console.WriteLine("Четверг");
        return;
}
if (i == 5)
      {
        Console.WriteLine("Пятница");
        return;
}
if (i == 6)
      {
        Console.WriteLine("Суббота");
        return;
}
if (i == 7)
      {
        Console.WriteLine("Воскресение");
        return;
}