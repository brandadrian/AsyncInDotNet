var fileToRead = "fileToRead.txt";

//Old  way of handling async stuff
var lines = File.ReadAllLinesAsync(fileToRead).ContinueWith(result =>
{
    if (result.IsFaulted)
    {
        Console.Error.WriteLine("An error occured...");
        return;
    }

    foreach (var line in result.Result)
    {
        Console.WriteLine(line);
    }
});

//Better way of handling async stuff
await ReadFileAsnc(fileToRead);

async Task ReadFileAsnc(string fileName)
{
    var lines = await File.ReadAllLinesAsync(fileName);
    foreach (var line in lines)
    {
        Console.WriteLine(line);
    }
}

Console.WriteLine("Press any key to exit...");
Console.ReadKey();