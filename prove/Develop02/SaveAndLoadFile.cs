using System.Runtime.CompilerServices;

public class SaveAndLoadFile
{
    public string _fileName;
    public List<Write> _listName;
    public List<string> _promptsList;

    public void Save(List<Write> _listName)
    {

        using (StreamWriter outputFile = new StreamWriter(_fileName))
                {
                    foreach (string prompt in _promptsList)
                    {
                        outputFile.WriteLine(prompt);
                    }
                    outputFile.WriteLine("|~|");
                    foreach (Write entry in _listName)
                    {
                        outputFile.WriteLine($"{entry._date}||{entry._prompt}||{entry._response}");
                    }
                }
    }

    public void Load(List<Write> _listName, List<string> _promptsList)
    {
        string[] lines = System.IO.File.ReadAllLines(_fileName);

            _listName.Clear();
            _promptsList.Clear();
            int partNumber = 0;

            foreach (string line in lines){
                string[] parts = line.Split("||");
                if (line == "|~|"){
                    partNumber += 1;
                }
                
                if (partNumber == 0) {
                    _promptsList.Add(line);
                }
                else
                {
                    if (line != "|~|")
                    {
                        Write oldEntry = new Write();
                        oldEntry._date = parts[0];
                        oldEntry._prompt = parts[1];
                        oldEntry._response = parts[2];
                
                        _listName.Add(oldEntry);
                    }
                }
            }
    }
}