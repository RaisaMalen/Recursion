// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

int m = 3;
int n = 2;

int Ackerman (int m, int n){
    if (m == 0){
        return n + 1;}
        else 
        if (n == 0){
            return Ackerman (m - 1, 1);
            }
            else {
                return Ackerman (m - 1, Ackerman (m, n -1));
                }
}

Console.Write (Ackerman (m, n));