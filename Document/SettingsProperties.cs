namespace BaseCAD
{
    public partial class Settings
    {
        public System.Int32 DisplayPrecision
        {
            get => Get<System.Int32>("DisplayPrecision");
            set => Set("DisplayPrecision", value);
        }
        public BaseCAD.Graphics.Color BackColor
        {
            get => Get<BaseCAD.Graphics.Color>("BackColor");
            set => Set("BackColor", value);
        }
        public BaseCAD.Graphics.Color CursorPromptBackColor
        {
            get => Get<BaseCAD.Graphics.Color>("CursorPromptBackColor");
            set => Set("CursorPromptBackColor", value);
        }
        public BaseCAD.Graphics.Color CursorPromptForeColor
        {
            get => Get<BaseCAD.Graphics.Color>("CursorPromptForeColor");
            set => Set("CursorPromptForeColor", value);
        }
        public BaseCAD.Graphics.Color SelectionWindowColor
        {
            get => Get<BaseCAD.Graphics.Color>("SelectionWindowColor");
            set => Set("SelectionWindowColor", value);
        }
        public BaseCAD.Graphics.Color SelectionWindowBorderColor
        {
            get => Get<BaseCAD.Graphics.Color>("SelectionWindowBorderColor");
            set => Set("SelectionWindowBorderColor", value);
        }
        public BaseCAD.Graphics.Color ReverseSelectionWindowColor
        {
            get => Get<BaseCAD.Graphics.Color>("ReverseSelectionWindowColor");
            set => Set("ReverseSelectionWindowColor", value);
        }
        public BaseCAD.Graphics.Color ReverseSelectionWindowBorderColor
        {
            get => Get<BaseCAD.Graphics.Color>("ReverseSelectionWindowBorderColor");
            set => Set("ReverseSelectionWindowBorderColor", value);
        }
        public BaseCAD.Graphics.Color SelectionHighlightColor
        {
            get => Get<BaseCAD.Graphics.Color>("SelectionHighlightColor");
            set => Set("SelectionHighlightColor", value);
        }
        public BaseCAD.Graphics.Color JigColor
        {
            get => Get<BaseCAD.Graphics.Color>("JigColor");
            set => Set("JigColor", value);
        }
        public BaseCAD.Graphics.Color ControlPointColor
        {
            get => Get<BaseCAD.Graphics.Color>("ControlPointColor");
            set => Set("ControlPointColor", value);
        }
        public BaseCAD.Graphics.Color ActiveControlPointColor
        {
            get => Get<BaseCAD.Graphics.Color>("ActiveControlPointColor");
            set => Set("ActiveControlPointColor", value);
        }
        public BaseCAD.Graphics.Color SnapPointColor
        {
            get => Get<BaseCAD.Graphics.Color>("SnapPointColor");
            set => Set("SnapPointColor", value);
        }
        public BaseCAD.Graphics.Color MinorGridColor
        {
            get => Get<BaseCAD.Graphics.Color>("MinorGridColor");
            set => Set("MinorGridColor", value);
        }
        public BaseCAD.Graphics.Color MajorGridColor
        {
            get => Get<BaseCAD.Graphics.Color>("MajorGridColor");
            set => Set("MajorGridColor", value);
        }
        public BaseCAD.Graphics.Color AxisColor
        {
            get => Get<BaseCAD.Graphics.Color>("AxisColor");
            set => Set("AxisColor", value);
        }
        public System.Int32 PickBoxSize
        {
            get => Get<System.Int32>("PickBoxSize");
            set => Set("PickBoxSize", value);
        }
        public System.Int32 ControlPointSize
        {
            get => Get<System.Int32>("ControlPointSize");
            set => Set("ControlPointSize", value);
        }
        public System.Int32 PointSize
        {
            get => Get<System.Int32>("PointSize");
            set => Set("PointSize", value);
        }
        public System.Boolean Snap
        {
            get => Get<System.Boolean>("Snap");
            set => Set("Snap", value);
        }
        public System.Int32 SnapPointSize
        {
            get => Get<System.Int32>("SnapPointSize");
            set => Set("SnapPointSize", value);
        }
        public System.Int32 SnapDistance
        {
            get => Get<System.Int32>("SnapDistance");
            set => Set("SnapDistance", value);
        }
        public BaseCAD.SnapPointType SnapMode
        {
            get => Get<BaseCAD.SnapPointType>("SnapMode");
            set => Set("SnapMode", value);
        }
    }
}
