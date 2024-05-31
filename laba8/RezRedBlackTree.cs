using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba8
{
    public partial class RezRedBlackTree : Form
    {
        private const int NodeRadius = 20;
        private const int HorizontalSpacing = 50;
        private const int VerticalSpacing = 50;
        private Panel panel;
        RedBlackTree fleetToshow = new RedBlackTree();
        List<int> pathtoshow = new List<int>();
        public RezRedBlackTree(RedBlackTree fleet, List<int> path)
        {
            InitializeComponent();
            InitializePanel();
            fleetToshow = fleet;
            pathtoshow = path;
        }
        private void InitializePanel()
        {
            panel = new Panel();
            panel.Dock = DockStyle.Fill;
            panel.Paint += Panel_Paint;
            Controls.Add(panel);
        }

        private void Panel_Paint(object sender, PaintEventArgs e)
        {
            DrawTree(e.Graphics);
        }

        private void DrawTree(Graphics graphics)
        {
            DrawNode(fleetToshow.root, graphics, panel.Width / 2, 50, panel.Width / 4);
        }

        private void DrawNode(Node node, Graphics graphics, int x, int y, int offsetX)
        {
            if (pathtoshow.Find(x => x == node.data) > 0)
            {
                Pen pen = new Pen(Color.Green, 4);
                graphics.DrawEllipse(pen, x - NodeRadius, y - NodeRadius, 2 * NodeRadius, 2 * NodeRadius);
            }
            else
            {
                graphics.DrawEllipse(Pens.Black, x - NodeRadius, y - NodeRadius, 2 * NodeRadius, 2 * NodeRadius);
            }
            if (node.color == Colors.Black)
            {
                graphics.FillEllipse(Brushes.Black, x - NodeRadius, y - NodeRadius, 2 * NodeRadius, 2 * NodeRadius);
            }
            else if (node.color == Colors.Red)
            {
                graphics.FillEllipse(Brushes.Red, x - NodeRadius, y - NodeRadius, 2 * NodeRadius, 2 * NodeRadius);
            }
            graphics.DrawString(node.data.ToString(), new Font("Arial", 10), Brushes.White, x - 10, y - 10);
            if (node.left != null)
            {
                int newX = x - offsetX;
                int newY = y + VerticalSpacing;
                graphics.DrawLine(Pens.Black, x, y + NodeRadius, newX, newY - NodeRadius);
                DrawNode(node.left, graphics, newX, newY, offsetX / 2);
            }
            if (node.right != null)
            {
                int newX = x + offsetX;
                int newY = y + VerticalSpacing;
                graphics.DrawLine(Pens.Black, x, y + NodeRadius, newX, newY - NodeRadius);
                DrawNode(node.right, graphics, newX, newY, offsetX / 2);
            }
        }
    }
}
