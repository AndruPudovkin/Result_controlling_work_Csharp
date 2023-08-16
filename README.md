# Описание программы

Алгоритм работы кода можно представить с помощью блок-схемы

![Alt text](%D0%91%D0%BB%D0%BE%D0%BA_%D1%81%D1%85%D0%B5%D0%BC%D0%B0.png)

В алгоритме присутствуют несколко методов:

1.  *FillArray (string text)*
Данный метод получает на вход текстовое сообщение "введите длину массива :", приглашая пользователя ко вводу массива.

2.  *PrinArray(string[] array)*
Данный метод получает на вход массив, который будет выводится в терминал.

3. *Function (string [] arrayFanction)*
Метод в котором описана основной алгоритм. На вход метод получает массив (arrayFanction []) и на выходе возвращает новый массив (newArray []) заполненный  строками длина который менее или равна 3м символам.

Для создания массива в начале определяется  длина массива:

for (int i=0; i < arrayFanction.Length; i++)

    {
        if (arrayFanction[i].Length<=3)
        {
            count++;
        }
    } 

Долее заполняется массив:

string [] newArray = new string [count];

    int k = 0;
    for (int j=0; j < arrayFanction.Length; j++) 
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

