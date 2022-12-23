// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using static System.Console;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

//Задание 1
//Пользователь вводит с клавиатуры число в диапазоне от 1 до 100. Если число кратно 3 (делится на 3 без 
//остатка) нужно вывести слово Fizz. Если число кратно 5
//нужно вывести слово Buzz. Если число кратно 3 и 5 нужно 
//вывести Fizz Buzz. Если число не кратно не 3 и 5 нужно 
//вывести само число.
//Если пользователь ввел значение не в диапазоне от 1
//до 100 требуется вывести сообщение об ошибке.
//1///////////////////////////////////////////////////////////////
int tmp = 0;
bool xz = true; 
while (xz)
{
    try { tmp = Convert.ToInt32(ReadLine()); }
    catch (Exception e) { WriteLine("ты написал не то!!!!"); tmp = 0; }
    if (tmp <= 0 || tmp > 100) { WriteLine("на фиг со своими цифрами!!! ГЫ ГЫ ГЫ"); xz = true; }
    else if ((tmp % 5) == 0 && (tmp % 3) == 0) { WriteLine("Fizz Buzz"); /*xz = false;*/ }
    else if ((tmp % 3) == 0) { WriteLine("Fizz"); /*xz = false;*/ }
    else if ((tmp % 5) == 0) { WriteLine("Buzz"); }
    else { WriteLine(tmp); xz = true; }
}

//Задание 2
//Пользователь вводит с клавиатуры два числа. Первое  
//число — это значение, второе число процент, который 
//необходимо посчитать. Например, мы ввели с клавиатуры 
//90 и 10. Требуется вывести на экран 10 процентов от 90. 
//Результат: 9
//2///////////////////////////////////////////////////////////////
float celoe = 0;
float procent;
WriteLine("Введите целое число :");
celoe = Convert.ToInt32(ReadLine());
WriteLine("Введите процент от числа :");
procent = Convert.ToInt32(ReadLine());
//float iskomoe_chislo = celoe * ((1 + procent) / 100);
float iskomoe_chislo = (celoe / 100) * procent;
WriteLine(procent + " Процентов от числа " + celoe + " = " + iskomoe_chislo);


//Задание 3
//Пользователь вводит с клавиатуры четыре цифры. 
//Необходимо создать число, содержащее эти цифры. Например, если с клавиатуры введено 1, 5, 7, 8 тогда нужно 
//сформировать число 1578
//3///////////////////////////////////////////////////////////////
////int chislo1 = Convert.ToInt32(ReadLine());
////int chislo2 = Convert.ToInt32(ReadLine());
////int chislo3 = Convert.ToInt32(ReadLine());
////int chislo4 = Convert.ToInt32(ReadLine());
////WriteLine(int.Parse(chislo1.ToString() + chislo2.ToString() + chislo3.ToString() + chislo4.ToString()));
string chislo1 = ReadLine();
string chislo2 = ReadLine();
string chislo3 = ReadLine();
string chislo4 = ReadLine();
WriteLine(long.Parse(chislo1.ToString() + chislo2.ToString() + chislo3.ToString() + chislo4.ToString()));

//Задание 4
//Пользователь вводит шестизначное число. После чего 
//пользователь вводит номера разрядов для обмена цифр. 
//Например, если пользователь ввёл один и шесть — это 
//значит, что надо обменять местами первую и шестую 
//цифры.
//Число 723895 должно превратиться в 523897.
//Если пользователь ввел не шестизначное число требуется вывести сообщение об ошибке
//4///////////////////////////////////////////////////////////////
string? chislo = "0";
bool reset = false;
int Low, Hight;
WriteLine("введите шестизначное число :");
try { chislo = ReadLine(); if (chislo.Length == 6) { WriteLine("норма"); } else { WriteLine("Не норма"); } }
catch (IOException e) { WriteLine("Ошибка ввода!! :"); }
do
{
    Console.WriteLine("Введите позицию"); Low = Convert.ToInt32(Console.ReadLine()); Low -= 1;
    Console.WriteLine("Введите позицию"); Hight = Convert.ToInt32(Console.ReadLine()); Hight -= 1;
    if (Hight > chislo.Length - 1) { WriteLine("Ошибка ввода!! : в строке нету столько символов"); reset = true; }
} while (reset);
char[] char_arr = chislo.ToCharArray();
char tmps = chislo[Low];
char_arr[Low] = char_arr[Hight];
char_arr[Hight] = tmps;
string xxz = new string(char_arr);
//WriteLine(xz);
WriteLine(Convert.ToInt32(xxz));

////////////////Console.WriteLine("Введите число");
////////////////int x = Convert.ToInt32(Console.ReadLine());
////////////////Console.WriteLine("Введите позицию");
////////////////int s = Convert.ToInt32(Console.ReadLine());
////////////////int m = 1;
////////////////while (s > 1){ m *= 10;s--;}
////////////////int t = (x % m) + (x / (m * 10)) * m;
////////////////Console.WriteLine(t);




//Задание 5
//Пользователь вводит с клавиатуры дату. Приложение должно отобразить название сезона и дня недели. 
//Например, если введено 22.12.2021, приложение должно 
//отобразить Winter Wednesday
//5///////////////////////////////////////////////////////////////
Console.WriteLine("Введите дату. Пример : 12.24.2020 ");
string? data = Console.ReadLine();
string[] words = data.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
int day = 0; int monht = 0; int year = 0;
for (int i = 0; i < words.Length; i++)
{
    if (i == 0) day = Convert.ToInt32(words[i]);
    else if (i == 1) monht = Convert.ToInt32(words[i]);
    else if (i == 2) year = Convert.ToInt32(words[i]);
}
string? season = "";
if ((12 == monht) || (1 == monht) || (2 == monht)) { season = "зима "; } //Winter
else if ((3 == monht) || (4 == monht) || (5 == monht)) { season = "весна "; }//Spring
else if ((6 == monht) || (7 == monht) || (8 == monht)) { season = "лето "; } //summer
else if ((9 == monht) || (10 == monht) || (11 == monht)) { season = "осень "; }//autumn
DateTime dateValue = new DateTime(year, monht, day);
Console.Write(season);
Console.WriteLine(dateValue.ToString("dddd"));

//Задание 6
//Пользователь вводит с клавиатуры показания температуры. 
//В зависимости от выбора пользователя программа переводит температуру из Фаренгейта в Цельсий 
//или наоборот
//6///////////////////////////////////////////////////////////////
double temperature;
Console.WriteLine("Введите показания температуры. После ввода температуры ");
Console.WriteLine("введите С Цельсий или F Фаренгейт через пробел, в каком формате вводите температуру");
Console.WriteLine("Пример : 12.4 C");
string? str = Console.ReadLine();
char[] str_arr = str.ToCharArray();
int revers = 0;
for (int i = 0; i < str.Length; i++)
{
    if ((str_arr[i] == 'c') || (str_arr[i] == 'C')) { WriteLine("Цельсий "); revers = 1; }
    else if ((str_arr[i] == 'f') || (str_arr[i] == 'F')) { WriteLine("Фаренгейт "); revers = 2; }
}
string cc = str.Substring(0, str.Length - 2);
temperature = Convert.ToDouble(cc);
switch (revers)
{
    case 1: temperature = temperature * 1.8 + 32; break;//в Фаренгейт 
    case 2: temperature = (temperature - 32) / 11.8; break;//в Цельсий 
}
if (revers == 1) { WriteLine($"температура в Фаренгейтах = {temperature}"); }
else { WriteLine($"температура в Цельсиях = {temperature}"); }



//Задание 7
//Пользователь вводит с клавиатуры два числа. Нужно 
//показать все четные числа в указанном диапазоне. Если 
//границы диапазона указаны неправильно требуется произвести нормализацию границ. Например, пользователь 
//ввел 20 и 11, требуется нормализация, после которой
//7///////////////////////////////////////////////////////////////
int min, max;
Console.WriteLine("Введите позицию"); min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите позицию"); max = Convert.ToInt32(Console.ReadLine());
if (min > max) { int temp = min; min = max; max = temp; }
if ((min % 2) == 0)
{ for (int i = min; i <= max; i += 2) { Write(i); Write(","); } }
else { for (int i = min + 1; i <= max; i += 2) { Write(i); Write(","); } }
