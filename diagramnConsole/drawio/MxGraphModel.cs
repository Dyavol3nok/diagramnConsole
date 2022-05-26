using System.Xml.Serialization;

namespace diagramnConsole.drawio
{
    [XmlRoot("mxGraphModel")]
    public class MxGraphModel
    {
        [XmlAttribute(AttributeName = "dx")]
        public int Dx { get; set; }
        [XmlAttribute(AttributeName = "dy")]
        public int Dy { get; set; }
        [XmlAttribute(AttributeName = "grid")]
        public int Grid { get; set; }
        [XmlAttribute(AttributeName = "gridSize")]
        public int GridSize { get; set; }
        [XmlAttribute(AttributeName = "guides")]
        public int Guides { get; set; }
        [XmlAttribute(AttributeName = "tooltips")]
        public int ToolTips { get; set; }
        [XmlAttribute(AttributeName = "connect")]
        public int Connect { get; set; }
        [XmlAttribute(AttributeName = "arrows")]
        public int Arrows { get; set; }
        [XmlAttribute(AttributeName = "fold")]
        public int Fold { get; set; }
        [XmlAttribute(AttributeName = "page")]
        public int Page { get; set; }
        [XmlAttribute(AttributeName = "pageScale")]
        public int PageScale { get; set; }
        [XmlAttribute(AttributeName = "pageWidth")]
        public int PageWidth { get; set; }
        [XmlAttribute(AttributeName = "pageHeight")]
        public int PageHeight { get; set; }
        [XmlAttribute(AttributeName = "math")]
        public int Math { get; set; }
        [XmlAttribute(AttributeName = "shadow")]
        public int Shadow { get; set; }
        [XmlArray("root")]
        [XmlArrayItem("mxCell")]
        public List<MxCell> Root { get; set; } = new List<MxCell>();
    }
}
