string [] InputSrtingArray ()
{
    Console.Write($"Введите количество элементов массива: ");
    int n = Convert.ToInt32(Console.ReadLine());
    while (n <= 0)
    {
        Console.Write($"Введите значение больше нуля ");
        n = Convert.ToInt32(Console.ReadLine());
    }
    string [] stringArray = new string [n];
    for (int i=0; i<n; i++)
    {
        Console.Write($"Введите {i+1}-й элемент строчного массива: ");
        stringArray[i] = Console.ReadLine(); 
    }
    return stringArray;
}
    
void ShowStringArray (string [] array)
{
    for (int i=0; i<array.Length; i++)
        Console.Write(array[i]+" | ");
    Console.WriteLine();
}

int FindSizeForNewArray (string [] array,int count)
{
    int size = 0;
    for (int i=0; i< array.Length; i++)
        if (array[i].Length <= count) size++;
    return size;
}

string [] CreateArrayOfShortStrings (string [] array, int size, int count)
{   
    string [] shortArray = new string [size];
    int j=0;
        for (int i=0; i< array.Length; i++)
            if (array[i].Length <= count) 
            {
                shortArray[j] = array[i];
                j++;
            }
        return shortArray;
}

string[] initialArray = InputSrtingArray();
ShowStringArray(initialArray);
Console.Write($"Введите максимальную длинну элемента в новом массиве: ");
int count= Convert.ToInt32(Console.ReadLine());
int size = FindSizeForNewArray(initialArray,count);
if (size >0) 
{
    string [] newArray = CreateArrayOfShortStrings(initialArray,size,count);
    ShowStringArray(newArray);
}
else 
Console.Write($"В исходном массиве отсутсвуют элементы, соотвествующие условию");
