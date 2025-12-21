using System;
using System.IO;
using System.Text.Json;
using TecstileEditor.Models;

namespace TecstileEditor.Services;

public static class SaveLoadService
{
    public static string? ContentRoot = @"Content/";
    public static void Save()
    {
        if (ContentRoot == null)
            return; // Prompt to pick new folder here
    
        string jsonString = JsonSerializer.Serialize(TerrainDataModel.terrainData);
        File.WriteAllText(ContentRoot + "filename.txt", jsonString);
    }
    public static void Open()
    {
        
    }
}
