using System.Xml.Serialization;

namespace diagramnConsole.drawio
{
    public class MxGeometry
    {
        [XmlAttribute(AttributeName = "x")]
        public int X { get; set; }
        [XmlAttribute(AttributeName = "y")]
        public int Y { get; set; }
        [XmlAttribute(AttributeName = "width")]
        public int Width { get; set; }
        [XmlAttribute(AttributeName = "height")]
        public int Height { get; set; }
        [XmlAttribute(AttributeName = "as")]
        public string As { get; set; }
    }
}
