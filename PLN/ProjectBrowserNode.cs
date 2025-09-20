using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLN
{
    public enum ProjectBrowserNodeType
    {
        ViewFloor1F,
        ViewFloor2F,
        ViewFloor3F,
        ViewFloor4F,
        ViewFloor5F,
        ViewElevationWest,
        ViewElevationEast,
        ViewElevationSouth,
        ViewElevationNorth,
        View3D,
        DrawablesLine,
        DrawablesPoint,
        ElementsBeam,
        ElementsColumn,
        ElementsRoom,
    }

    internal class ProjectBrowserNode : TreeNode
    {
        public ProjectBrowserNodeType NodeType { get; private set; }
        public ProjectBrowserNode(string name, ProjectBrowserNodeType nodeType)
            : base(name)
        {
            NodeType = nodeType;
        }
    }
}
