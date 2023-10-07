/**
    Group: Alt-Z
    Authors:
    - Stephen Beckstead
    - Truman Benjamin
    - Ethan Glenn
    - Wessly Green
    - Nii Gogoe
*/

using System.IO;

namespace project1
{
    public class Journal
    {

        public List<Entry> _entries = new List<Entry>();
        public String _fileName;

        public void addEntry(Entry entry)
        {
            _entries.Add(entry);
        }

        public void saveFile(string filename)
        {
            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                foreach (Entry entry in _entries)
                {
                    string[] details = entry.readEntry();
                    outputFile.WriteLine($"{details[1]}");
                }
            }
            Console.WriteLine("File saved!");
        }

        public void readFile(string filename)
        {
            string[] lines = System.IO.File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                Entry entry = new Entry(line);
                _entries.Add(entry);
            }
            Console.WriteLine("File read!");
        }

        public void Display()
        {
            int counter = 1;
            Console.WriteLine("Journal Entries:");
            foreach (Entry entry in _entries)
            {
                string[] entryDetails = entry.readEntry();
                Console.Write($"{counter} - ");
                Console.Write(entryDetails[1]);
                Console.WriteLine();
                counter++;
            }
        }
    }
}