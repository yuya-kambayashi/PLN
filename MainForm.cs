using BaseCAD.Document;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseCAD
{
    public partial class MainForm : Form
    {
        string currentCommand = "";
        int commandStep = 0;
        Point2D[] pickedPoints = new Point2D[20];
        Drawable newItem;
        Drawable hoverItem;
        OutlineStyle hoverItemStyle;

        private CADDocument doc;
        public MainForm()
        {
            InitializeComponent();
        }
    }
}
