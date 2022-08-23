
int sizeArray = InputInt("Введите размер массива:");
string [] newArray = new string[sizeArray];

FillArray(newArray);
string [] newArraySort = new string[SizeNewArraySort(newArray)];
PrintArray(newArray);
Console.Write(" -> ");
PrintArray(SortArray(newArray, newArraySort));



int InputInt(string output)
{
    Console.WriteLine(output);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray(string [] array)
{
    for(int i = 0; i < array.Length;i++)
    {
        Console.WriteLine($"Введите {i+1} - й элемент массива:");
        array[i] = Console.ReadLine();

    }
}

void PrintArray(string [] array)
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

int SizeNewArraySort(string [] array)
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

string [] SortArray(string[] array1, string[] array2)
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
