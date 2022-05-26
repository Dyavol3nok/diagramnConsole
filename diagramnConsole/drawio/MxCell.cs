using System.Xml.Serialization;

namespace diagramnConsole.drawio
{
    public class MxCell
    {
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
        [XmlAttribute(AttributeName = "value")]
        public string Value { get; set; }
        [XmlAttribute(AttributeName = "style")]
        public string Style { get; set; }
        [XmlAttribute(AttributeName = "vertex")]
        public int Vertex { get; set; }
        [XmlAttribute(AttributeName = "parent")]
        public string Parent { get; set; }
        [XmlElement("mxGeometry")]
        public MxGeometry MxGeometry { get; set; } 
    }
}
