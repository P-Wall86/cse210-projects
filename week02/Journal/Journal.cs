public class Journal
{
    public List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (var entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)  //I used StreamWriter to create a CSV file.
    {
        using (StreamWriter writer = new StreamWriter(file))
        {
            foreach (var entry in _entries)
            {
                string date = EscapeCsvValue (entry._date);
                string prompt = EscapeCsvValue(entry._promptText);
                string entryText = EscapeCsvValue(entry._entryText);

                writer.WriteLine($"{date},{prompt},{entryText}"); //I used a comma to separate values and store data.
            }
        }
    }

    public void LoadFromFile(string file)
    {
        if (File.Exists(file))
        {
            _entries.Clear();
            string[] lines = File.ReadAllLines(file);

            foreach (var line in lines)
            {
                string[] columns = ParseCsvLine(line);

                if (columns.Length == 3)
                {
                    string date = columns[0];
                    string prompt = columns[1];
                    string entryText = columns[2];

                    _entries.Add(new Entry(date, prompt, entryText));
                }
            }
        }
        else
        {
            Console.WriteLine("File does not exist.");
        }
    }

    public string EscapeCsvValue(string value)
    {
        if (value.Contains(",") || value.Contains("\"") || value.Contains("\n"))
        {
            value = $"\"{value.Replace("\"", "\"\"")}\"";
        }
        return value;
    }

    public string[] ParseCsvLine(string line) //This function was particularly difficult to write since I wasn't much allowed
                                             //to make a syntax mistake. Correctly parsing a CSV file is a challenge.
    {
        var result = new List<string>();
        bool insideQuote = false;
        string currentField = string.Empty;

        for (int i = 0; i < line.Length; i++) 
        {
            char c = line[i];

            if (c == '"')
            {
                insideQuote = !insideQuote;
            }
            else if (c == ',' && !insideQuote)
            {
                result.Add(currentField);
                currentField = string.Empty;
            }
            else
            {
                currentField += c;
            }
        }


        result.Add(currentField);

        return result.ToArray();
    }
}