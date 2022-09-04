string[] array = { "Саша", "Маша", "12", ":-D", "Ян" };
string[] array1 = new string[array.Length];
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
        array1[i] = array[i];
}
Console.WriteLine("[" + string.Join(" ", array1) + "]");