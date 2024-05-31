using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba8
{
    public partial class Imgrezbalanced : Form
    {
        private const int NodeRadius = 20;
        private const int HorizontalSpacing = 50;
        private const int VerticalSpacing = 50;
        private Panel panel;
        balancedTree<int> fleetToshow = new balancedTree<int>();
        List<int> pathtoshow = new List<int>();
        public Imgrezbalanced(balancedTree<int> fleet, List<int> path)
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

        private void DrawNode(BalancedTreeNode<int> node, Graphics graphics, int x, int y, int offsetX)
        {
            if (pathtoshow.Find(x => x == node.Value) > 0)
            {
                graphics.FillEllipse(Brushes.Green, x - NodeRadius, y - NodeRadius, 2 * NodeRadius, 2 * NodeRadius);
            }
            else
            {
                graphics.FillEllipse(Brushes.Blue, x - NodeRadius, y - NodeRadius, 2 * NodeRadius, 2 * NodeRadius);
            }
            graphics.DrawEllipse(Pens.Black, x - NodeRadius, y - NodeRadius, 2 * NodeRadius, 2 * NodeRadius);
            graphics.DrawString(node.Value.ToString(), new Font("Arial", 10), Brushes.White, x - 10, y - 10);

            if (node.Left != null)
            {
                int newX = x - offsetX;
                int newY = y + VerticalSpacing;
                graphics.DrawLine(Pens.Black, x, y + NodeRadius, newX, newY - NodeRadius);
                DrawNode(node.Left, graphics, newX, newY, offsetX / 2);
            }
            if (node.Right != null)
            {
                int newX = x + offsetX;
                int newY = y + VerticalSpacing;
                graphics.DrawLine(Pens.Black, x, y + NodeRadius, newX, newY - NodeRadius);
                DrawNode(node.Right, graphics, newX, newY, offsetX / 2);
            }
        }
    }
}
