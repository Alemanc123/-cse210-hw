using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(string prompt, string response, string date)
    {
        Entry newEntry = new Entry(date, prompt, response);
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine($"{entry._date}|{entry._prompt}|{entry._response}");
            }
        }
        Console.WriteLine("Journal saved successfully.\n");
    }

    public void LoadFromFile(string filename)
    {
        _entries.Clear();
        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 3)
                {
                    _entries.Add(new Entry(parts[0], parts[1], parts[2]));
                }
            }
            Console.WriteLine("Journal loaded successfully.\n");
        }
        else
        {
            Console.WriteLine("File not found.\n");
        }
    }
}