using System;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    public void SaveToFile(string file)
    {
        JsonSerializerOptions options = new JsonSerializerOptions{IncludeFields = true, WriteIndented = true};
        string jsonString = JsonSerializer.Serialize(_entries, options);
        File.WriteAllText(file, jsonString);
    }
    public void LoadFromFile(string file)
    {
        JsonSerializerOptions options = new JsonSerializerOptions{IncludeFields = true, WriteIndented = true};
        string jsonString = File.ReadAllText(file);
        _entries = JsonSerializer.Deserialize<List<Entry>>(jsonString,options);
    }
}