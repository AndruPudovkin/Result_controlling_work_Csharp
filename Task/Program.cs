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
        array[i] = Console.ReadLine()!;
    } 
    return array;
}
void PrinArray(string[] array)
{
   
        System.Console.WriteLine("[" + string.Join(", ",array)+ "]");
     
}
string[] Function (string [] arrayFanction)
{
    int count = 0;
    for (int i=0; i < arrayFanction.Length; i++) // Определяем количество искомых строк для определения длинны нового массива 
    {
        if (arrayFanction[i].Length<=3)
        {
            count++;
        }
    } 
    string [] newArray = new string [count];
    int k = 0; // данная переменная нужна чтобы перебор массива newArray начинался не с 0 
    for (int j=0; j < arrayFanction.Length; j++) // заполняем масив 
    {
        for (int i=k; i < newArray.Length; i++) 
        {
          if (arrayFanction[j].Length<=3 )
          {
            newArray[i] = arrayFanction[j];
            k++;
          }
          break;
        } 
    } 
 return newArray;
}
//---------------------------------------------------------------------------------------
string [] array = FillArray("введите длину масива :");
PrinArray(array);
string [] newArray = Function(array);
PrinArray(newArray);
