// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

void main(){
    string[] myArray1 = {"Hello", "2", "world", ":-)"};
    string[] myArray2 = {"1234", "1567", "-2", "computer science"};
    string[] myArray3 = {"Russia", "Denmark", "Kazan"};
    Console.Write("До изменения -> ");
    Console.WriteLine("{0}", string.Join(", ", myArray1));
    Console.Write("После изменения -> ");
    Console.WriteLine("{0}", string.Join(", ", threeInArow(myArray1)));
    Console.Write("До изменения -> ");
    Console.WriteLine("{0}", string.Join(", ", myArray2));
    Console.Write("После изменения -> ");
    Console.WriteLine("{0}", string.Join(", ", threeInArow(myArray2)));
    Console.Write("До изменения -> ");
    Console.WriteLine("{0}", string.Join(", ", myArray3));
    Console.Write("После изменения -> ");
    Console.WriteLine("{0}", string.Join(", ", threeInArow(myArray3)));
}

string[] threeInArow(string[] arr){
    string[] remaked_arr = new string[arr.Length];
    int count = 0;
    foreach (string item in arr)
    {
        if(item.Length <= 3){
            remaked_arr[count] = item;
            count++;
        }
    }
    remaked_arr = remaked_arr.Where(x => !string.IsNullOrEmpty(x)).ToArray();
    return remaked_arr;
}

main();