/* Задачи находятся в ветках:
Задача 64 - ветка main;
Задача 66 - ветка vetka2;
Задача 68 - ветка vetka3;
*/

Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"

System.Console.WriteLine(PrintNumbers(1, 100));

string PrintNumbers(int start, int end)
{
	if (start == end)
	{
		return start.ToString();
	}
	return start + " " + PrintNumbers(start+1, end);
}
