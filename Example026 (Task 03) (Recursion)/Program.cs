// Задача 3: Задайте произвольный массив.
// Выведете его элементы, начиная с конца.
// Использовать рекурсию, не использовать циклы.

int [] array = {2, 15, 8, -3, 7};

void ShowArrayFromEnd (int [] array){
    if (array.Length == 0) return;
    else{
        Console.Write (array [array.Length-1]+ " ");
        Array.Resize (ref array, array.Length-1);
        ShowArrayFromEnd (array);
    }
}
ShowArrayFromEnd (array);