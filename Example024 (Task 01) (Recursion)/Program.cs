// Задача 1: Задайте значения M и N.
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// Использовать рекурсию, не использовать циклы.

int m = -5;
int n = 8;

void ShowNaturNums (int m, int n){
    if (m > n) return;
    if (m < 0) m = 0;
    ShowNaturNums (m, n - 1);
    Console.Write (n + " ");
}
ShowNaturNums (m, n);