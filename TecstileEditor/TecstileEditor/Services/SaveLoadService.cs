using System;
using System.IO;

namespace TecstileEditor.Services;

public static class SaveLoadService
{
    public static string ContentRoot = @"Content/";
    public static void Save()
    {
        System.Console.WriteLine("Ding!");

        string writeText = "Hello World!";
        File.WriteAllText(ContentRoot + "filename.txt", writeText);
    }
}
