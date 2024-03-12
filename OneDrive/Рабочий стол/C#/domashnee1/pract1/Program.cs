/*
Напишите программу, которая на вход принимает число и выдает его в квадрат
(число умноженное на само себя).
4 -> 16
-3 -> 9
-7 -> 49
*/ 

Console.WriteLine("Введи число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = number * number;
Console.WriteLine(result);
/*по результатам видно как с помощью реадлайн и райтлайн выводтся строка в компиляторе
 для ввода чисел и просмотра результата. Все прошло успешно*/

 /*Напишите программу, которое на вход принимает два числа и проверяет,
 является ли первое число квадратом второго
 a = 25; b = 5 -> да
 a = 2 b = 10 -> нет
 a = 9; b = 3 -> да
 a = -3 b = 9 -> нет
 */

Console.WriteLine("Введи два числа ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 == number2 * number2 )
{
    Console.WriteLine("является");
}
else
{
    Console.WriteLine("не является");
}
/*Хочу заметить, что при вводе компелятор автоматически
 выдает умножение на 2 от первого введеного числа по коду:if (number1 == number2 * number2)
 причина кроется в последнем числа 2 находящееся возле последней кнопки
 чтоб это избежать и кампилятор работал по коду как надо нам пишем так:
 if (number1 == number2 * number2 )
 здесь скобка находится через пробел и все работает*/

 Console.WriteLine("Введите первое число");
 int number1 = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Введите второе число");
 int number2 = Convert.ToInt32(Console.ReadLine());
 int result = number2 * number2;
 if(result == number1)
 {Console.WriteLine("первое число квадрат второго");}
 else
 {Console.WriteLine("первое число не является квадратом второго");}

Console.WriteLine("Введите числа: ");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA * numberA == numberB)
{
 Console.WriteLine("Правда");
 }
else
{
 Console.WriteLine("Лож");
}
/*Моя ошибка:Левая часть выражения назначения должна быть п 
еременной, свойством или индексатором.
Тобишь здесь я написал так:if (numberA * numberA = numberB) это ошибка
правильно так:if (numberA * numberA == numberB) с двумя ==
*/

/*!!!КОМАНДА CTRL- (КОНТРПЛЮСМИНУС) УМЕНЬШАЕТ ЭКРАН КОМПИЛЯТОРА И VC, А КОМАНДА CTRL+ (КОНТРЛПЛЮСПЛЮС) УВЕЛИЧИВАЕТ!!!!*/

