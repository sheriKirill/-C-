//  Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Clear();
Console.Write("Введите А: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите C: ");
int numberC = Convert.ToInt32(Console.ReadLine());
if (numberA >= numberB && numberA >= numberC) {
    Console.WriteLine("Наибольшее число: " + numberA);
}
else if (numberB >= numberA && numberB >= numberC) {
    Console.WriteLine("Наибольшее число: " + numberB);
}
else {
    Console.WriteLine("Наибольшее число: " + numberC);
}