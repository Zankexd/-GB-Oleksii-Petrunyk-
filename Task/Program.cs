string[] arr = { "sad", "1234", "^^^@!", "X3D" };
string[] Vyvod(string[] arr)
{
    int count = 1;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            count = +1;
        }
    }
    
    string[] AnotherArr = new string[count+1];
  
    for (int j = 0; j < arr.Length; j++)
    {
        if (arr[j].Length <= 3)
        {
            AnotherArr[count] = arr[j];
            count -=1;
        }
    }
    if (AnotherArr.Length>0)
    {
    for (int k = 0; k < AnotherArr.Length; k++)
    {  
       Console.Write($" {AnotherArr[k],2}");
    }
    }
    return AnotherArr;
    
}

string[]argus=Vyvod(arr);
Console.WriteLine();
Console.WriteLine();
for(int i=0;i<argus.Length;i++)
{
    Console.Write($" {argus[i],2}");
}