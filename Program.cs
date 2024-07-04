// See https://aka.ms/new-console-template for more information

/*Console.WriteLine(CalculateFactory(5));
Console.WriteLine(5*4*3*2*1);
// recursion => this use with tree operation
static int CalculateFactory(int number)
{
    if (number <= 1)
        return number;
    return number * CalculateFactory(number - 1);
}*/


// this will print tree of folder
/*PrintDirectoryFileSystem(@"C:\Users\J O K E R\source\repos\Advance-C#",1);
static void PrintDirectoryFileSystem(string dirPath,int level)
{
    foreach (var file in Directory.GetFiles(dirPath))
    {
       Console.WriteLine($"{new string('-',level)}{new FileInfo(file).Name}"); 
    }

    foreach (var dirName in Directory.GetDirectories(dirPath))
    {
        Console.WriteLine($"{new string('-',level)}{new FileInfo(dirName).Name}");  
        PrintDirectoryFileSystem(dirName,level+1);
    }
}*/

// print size of directory folder

Console.WriteLine(CalculateDirectorySize(@"C:\Users\J O K E R\source\repos\Advance-C#"));
static long CalculateDirectorySize(string dirPath)
{
    long size = 0;
    foreach (var file in Directory.GetFiles(dirPath))
        size += new FileInfo(file).Length; 

    foreach (var dirName in Directory.GetDirectories(dirPath))
    {
        size += CalculateDirectorySize(dirName);
    }

    return size;
}
