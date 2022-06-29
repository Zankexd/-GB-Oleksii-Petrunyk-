string[] arr = { "s123ууd", "124", "!", "X3ууD" };
string[] Vyvod(string[] arr)
{
    int count = 1;
    int LengthFirstArray=arr.Length;
    for (int i = 0; i < LengthFirstArray; i++)if (arr[i].Length <= 3)count = +1;
    string[] AnotherArr = new string[count+1];
     for (int j = 0; j < arr.Length; j++)
    {
        if (arr[j].Length <= 3)
        {
            AnotherArr[count] = arr[j];
            count -=1;
        }
    }    
    if (AnotherArr.Length>0)for (int k = 0; k < AnotherArr.Length; k++)Console.Write($" {AnotherArr[k],2}");   
    return AnotherArr;        
}
Console.WriteLine("Проверка на первого массива по условиям ТЗ и Запись его в новый массив.");
Console.Write("arr =");
string[]argus=Vyvod(arr);
Console.WriteLine();
Console.WriteLine("-----------");
Console.WriteLine("-----------");
Console.WriteLine("Проверка коректной записи в массив.");
Console.Write("Массив argus=");
for(int i=0;i<argus.Length;i++)
{
    Console.Write($" {argus[i],2}");
}