// See https://aka.ms/new-console-template for more information
using diagramnConsole;
using System.Text.RegularExpressions;

Console.WriteLine("Hello, World!");

string destination = "show_file.txt";
List<Csventry> csventry = new List<Csventry>();
string[] lines = File.ReadAllLines(destination);

var rx = new Regex(@"\s+",RegexOptions.Compiled);

foreach (string line in lines)
{
    string[] columns = rx.Split(line);

    if (columns.Length != 2)
    {
        continue;
    }
    csventry.Add(new Csventry{ Count = int.Parse(columns[1]), Name = columns[0] }) ;
}