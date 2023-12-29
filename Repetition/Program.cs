using System.Threading.Channels;

int MyArray = int.Parse(Console.ReadLine());
int [] array =[12, 13, 14, 5, 56 ];
foreach (int i in array) 
{
    if (i == MyArray)
    {
        Console.WriteLine(i);
    }
    else
    { 
        Console.WriteLine("false " + i); 
    }
}
for (int i = 0; i < array.Length; i++) 
{
    if (array[i] == MyArray)
    {
        array[i] = int.Parse(Console.ReadLine());
    }
    else 
    {
        array[i] *= 2;
    }
}