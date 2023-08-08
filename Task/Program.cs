// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
string [] FillArray (string text)
{
    System.Console.WriteLine(text);
    int size = Convert.ToInt32(Console.ReadLine());
    string[] array = new string [size];
    for(int i = 0; i<array.Length; i++)
    {
        System.Console.WriteLine($"Введите {i} элемент масива: ");
        array[i] = Console.ReadLine();
    } 
    return array;
}
void PrinArray(string[] array)
{
   
        System.Console.WriteLine("[" + string.Join(", ",array)+ "]");
     
}
//
string [] test = FillArray("введите длину масива :");
PrinArray(test);