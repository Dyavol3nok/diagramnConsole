// See https://aka.ms/new-console-template for more information
using diagramnConsole;
using diagramnConsole.drawio;
using System.Text.RegularExpressions;
using System.Windows;
using System.Xml;
using System.Xml.Serialization;

string destination = "show_file.txt";
const int cellShiftX = 180;
const int cellShiftY = 100;
const int startX = 60;
var x = startX;
var y = 140;
const int maxWidth = 780;

if (Environment.GetCommandLineArgs().Length >1)
{
    destination = Environment.GetCommandLineArgs()[1];
}

List<TxtEntry> txtentry = new List<TxtEntry>();
string[] lines = File.ReadAllLines(destination);

var rx = new Regex(@"\s+",RegexOptions.Compiled);
const string temp = "temp.xml";

if (lines.Length > 0)
{
    foreach (string line in lines)
    {
        string[] columns = rx.Split(line);

        txtentry.Add(new TxtEntry
        {
            Name = columns[0],
            Pos = columns[1],
            Frequency = int.Parse(columns[2]),
            RelativeFrequency = float.Parse(columns[3])
        });
    }
}
else
{
    Console.Write("The text file is empty");
    System.Environment.Exit(0);
}


var mxGM = new MxGraphModel()
{
    Dx = 1102,
    Dy = 875,
    Grid = 1,
    GridSize = 10,
    Guides = 1,
    ToolTips = 1,
    Connect = 1,
    Arrows = 1,
    Fold = 1,
    Page = 1,
    PageScale = 1,
    PageWidth = 827,
    PageHeight = 1169,
    Math = 0,
    Shadow = 0

};

var root = ShapesFactory.MakeGraphRoot();
mxGM.Root.AddRange(root);

foreach(var entry in txtentry)
{
    if(x >= maxWidth)
    {
        x = startX;
        y += cellShiftY; 
    }
    var shape = ShapesFactory.MakeClass(entry.Name, x, y);
    x += cellShiftX;
    shape[0].Parent = root[1].Id;
    mxGM.Root.AddRange(shape); //Adds shapes into MxCells
}

XmlSerializer ser = new XmlSerializer(typeof(MxGraphModel));

TextWriter writer = new StreamWriter(temp);
ser.Serialize(writer, mxGM);
writer.Close();

System.Diagnostics.Process.Start($@"{System.Environment.GetFolderPath(System.Environment.SpecialFolder.ProgramFiles)}\draw.io\draw.io.exe", temp);
