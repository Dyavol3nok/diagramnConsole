using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diagramnConsole.drawio
{
    public static class ShapesFactory
    {
        static public MxCell MakeHeader(string title, int x, int y)
        {
            return new MxCell 
            {
                Id = Guid.NewGuid().ToString(), 
                Value = title,
                Style = "swimlane;fontStyle=1;align=center;verticalAlign=top;childLayout=stackLayout;horizontal=1;startSize=26;horizontalStack=0;resizeParent=1;resizeParentMax=0;resizeLast=0;collapsible=1;marginBottom=0;",
                Vertex = 1,
                MxGeometry = new MxGeometry 
                {
                    X = x,
                    Y = y,
                    Width = 160,
                    Height = 86,
                    As = "geometry"
                }

            };
        }

        static public MxCell MakeSeparator()
        {
            return new MxCell
            {
                Id = Guid.NewGuid().ToString(),
                Value = "",
                Style = "line;strokeWidth=1;fillColor=none;align=left;verticalAlign=middle;spacingTop=-1;spacingLeft=3;spacingRight=3;rotatable=0;labelPosition=right;points=[];portConstraint=eastwest;",
                Vertex = 1,
                MxGeometry = new MxGeometry
                {
                    Y = 52,
                    Width = 160,
                    Height = 8,
                    As = "geometry"
                }

            };
        }

        static public MxCell MakeField(string name, string type)
        {
            return new MxCell
            {
                Id = Guid.NewGuid().ToString(),
                Value = $"+ {name}: {type}",
                Style = "text;strokeColor=none;fillColor=none;align=left;verticalAlign=top;spacingLeft=4;spacingRight=4;overflow=hidden;rotatable=0;points=[[0,0.5],[1,0.5]];portConstraint=eastwest;",
                Vertex = 1,
                MxGeometry = new MxGeometry
                {
                    Y = 26,
                    Width = 160,
                    Height = 26,
                    As = "geometry"
                }
            };
        }

        static public MxCell MakeMethod(string name, string type)
        {
            return new MxCell
            {
                Id = Guid.NewGuid().ToString(),
                Value = $"+ {name}(): {type}",
                Style = "text;strokeColor=none;fillColor=none;align=left;verticalAlign=top;spacingLeft=4;spacingRight=4;overflow=hidden;rotatable=0;points=[[0,0.5],[1,0.5]];portConstraint=eastwest;",
                Vertex = 1,
                MxGeometry = new MxGeometry
                {
                    Y = 60,
                    Width = 160,
                    Height = 26,
                    As = "geometry"
                }
            };
        }
               
        static public List<MxCell> MakeClass(string name, int x, int y)
        {
            var header = MakeHeader(name, x, y);
            var field = MakeField("field", "type");
            field.Parent = header.Id;
            var seperator = MakeSeparator();
            seperator.Parent = header.Id;
            var method = MakeMethod("method", "type");
            method.Parent = header.Id;

            List<MxCell> list = new List<MxCell>
            { 
                header,
                field,
                seperator,
                method
            };
       
            return list;
        }

        static public List<MxCell> MakeGraphRoot()
        {
            var mxCell1 = new MxCell { Id = Guid.NewGuid().ToString() };
            var mxCell2 = new MxCell { Id = Guid.NewGuid().ToString(), Parent = mxCell1.Id };

            List<MxCell> root = new List<MxCell>
            {
                mxCell1, mxCell2
            };

            return root;
        }
    }
}
