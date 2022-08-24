
int sizeNewArray = InputInt("Введите размер массива:");              //Задаем размер массива с консоли
string [] newArray = new string[sizeNewArray];

FillArray(newArray);                                                      // Заполнение массива с консоли по элементно
string [] threeSymbolArray = new string[SizeThreeSymbolArray(newArray)];   //Задаем размер массива из строк длина которых меньше или равна 3. Делаем это через метод
PrintArray(newArray);                                                       // Вывод исходного массива на консоль
Console.Write(" -> ");
PrintArray(ThreeSymbolArray(newArray, threeSymbolArray));                       // Вывод  массива c длиной строк меньше или равной 3 на консоль



int InputInt(string output)   // Метод запроса размера исходного массива строк
{
    Console.WriteLine(output);
    return Convert.ToInt32(Console.ReadLine());
}


void FillArray(string [] array)   // Метод заполнение массива с терминала
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите {i+1} - й элемент массива:");
        array[i] = Console.ReadLine();

    }
}

void PrintArray(string [] array)  // Метод вывода массива в терминал
{
    if(array.Length == 0)
    {
       Console.Write($"[ ]"); 
    }
  for(int i = 0; i < array.Length; i++)
    {
     if(i == 0 & array.Length ==1 )
     {
        Console.Write($" [\"{array[i]}\"]");
     } 
     else if(i == 0)
     {
        Console.Write($" [\"{array[i]}\",");
     } 
     else if(i < array.Length-1)
     {
        Console.Write($" \"{array[i]}\",");
     }
     else
     {
        Console.Write($" \"{array[i]}\"]");
     }
    }
}

int SizeThreeSymbolArray(string [] array)   // Метод определения размера для нового массива строк с 3-мя или меньше символами
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            count++;
        }
    }
    return count;
}

string [] ThreeSymbolArray(string[] array1, string[] array2) // Метод заполнения массива строками из 3 и менее элементами
{
int index = 0;
for( int i = 0; i < array1.Length; i++)
{
    if(array1[i].Length <=3)
    {
       array2[index] = array1[i];
       index++;
    }
}
return array2;
}
