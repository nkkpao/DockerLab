Console.WriteLine();
args = Environment.GetCommandLineArgs();

if(args.Length <= 1)
{
    Console.WriteLine("Zero args");
    while(true) { }
}

string filePath = args[1];

bool isFileExist = File.Exists(filePath);
if (!isFileExist)
{
    Console.WriteLine("File does not exist.");
    while (true) { }
}
using (StreamReader reader = File.OpenText(filePath))
{
    string text = reader.ReadToEnd();
    if (text == "") { Console.WriteLine("File is empty"); while (true) { } }
    Console.WriteLine(text);
    while (true) { }
}