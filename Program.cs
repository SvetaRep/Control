string[] array = Array();
string[] result = FindArray(array, 3);
Console.WriteLine($"[{string.Join(", ", array)}] -> [{string.Join(", ", result)}]");
string[] FindArray(string[] input, int n) 
{
    string[] output =new string[GetFindArray(input, n)];
    for(int i=0, j=0; i<input.Length; i++) 
    {
        if(input[i].Length<=n) 
        {
            output[j]=input[i];
            j++;
        }
    }
    return output;
}
int GetFindArray(string[] input, int n) 
{
    int count=0;
    for(int i=0; i<input.Length; i++) 
    {
        if(input[i].Length<=n) 
        {
            count++;
        }
    }
    return count;
}
string[] Array() 
{
    Console.Write("Введите значения через пробел: ");
    return Console.ReadLine().Split(" ");
}