namespace PLN
{
    public partial class Settings
    {
        public System.Int32 DisplayPrecision
        {
            get => Get<System.Int32>("DisplayPrecision");
            set => Set("DisplayPrecision", value);
        }
        public PLN.Graphics.Color BackColor
        {
            get => Get<PLN.Graphics.Color>("BackColor");
            set => Set("BackColor", value);
        }
        public PLN.Graphics.Color CursorPromptBackColor
        {
            get => Get<PLN.Graphics.Color>("CursorPromptBackColor");
            set => Set("CursorPromptBackColor", value);
        }
        public PLN.Graphics.Color CursorPromptForeColor
        {
            get => Get<PLN.Graphics.Color>("CursorPromptForeColor");
            set => Set("CursorPromptForeColor", value);
        }
        public PLN.Graphics.Color SelectionWindowColor
        {
            get => Get<PLN.Graphics.Color>("SelectionWindowColor");
            set => Set("SelectionWindowColor", value);
        }
        public PLN.Graphics.Color SelectionWindowBorderColor
        {
            get => Get<PLN.Graphics.Color>("SelectionWindowBorderColor");
            set => Set("SelectionWindowBorderColor", value);
        }
        public PLN.Graphics.Color ReverseSelectionWindowColor
        {
            get => Get<PLN.Graphics.Color>("ReverseSelectionWindowColor");
            set => Set("ReverseSelectionWindowColor", value);
        }
        public PLN.Graphics.Color ReverseSelectionWindowBorderColor
        {
            get => Get<PLN.Graphics.Color>("ReverseSelectionWindowBorderColor");
            set => Set("ReverseSelectionWindowBorderColor", value);
        }
        public PLN.Graphics.Color SelectionHighlightColor
        {
            get => Get<PLN.Graphics.Color>("SelectionHighlightColor");
            set => Set("SelectionHighlightColor", value);
        }
        public PLN.Graphics.Color JigColor
        {
            get => Get<PLN.Graphics.Color>("JigColor");
            set => Set("JigColor", value);
        }
        public PLN.Graphics.Color ControlPointColor
        {
            get => Get<PLN.Graphics.Color>("ControlPointColor");
            set => Set("ControlPointColor", value);
        }
        public PLN.Graphics.Color ActiveControlPointColor
        {
            get => Get<PLN.Graphics.Color>("ActiveControlPointColor");
            set => Set("ActiveControlPointColor", value);
        }
        public PLN.Graphics.Color SnapPointColor
        {
            get => Get<PLN.Graphics.Color>("SnapPointColor");
            set => Set("SnapPointColor", value);
        }
        public PLN.Graphics.Color MinorGridColor
        {
            get => Get<PLN.Graphics.Color>("MinorGridColor");
            set => Set("MinorGridColor", value);
        }
        public PLN.Graphics.Color MajorGridColor
        {
            get => Get<PLN.Graphics.Color>("MajorGridColor");
            set => Set("MajorGridColor", value);
        }
        public PLN.Graphics.Color AxisColor
        {
            get => Get<PLN.Graphics.Color>("AxisColor");
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
        public PLN.SnapPointType SnapMode
        {
            get => Get<PLN.SnapPointType>("SnapMode");
            set => Set("SnapMode", value);
        }
        public PLN.AngleMode AngleMode
        {
            get => Get<PLN.AngleMode>("AngleMode");
            set => Set("AngleMode", value);
        }
    }
}
