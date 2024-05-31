using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba8
{
    public partial class ImgRedBlacktree : Form
    {
        private const int NodeRadius = 20;
        private const int HorizontalSpacing = 50;
        private const int VerticalSpacing = 50;
        private Panel panel;
        RedBlackTree fleetToshow = new RedBlackTree();
        public ImgRedBlacktree(RedBlackTree fleet)
        {
            InitializeComponent();
            InitializePanel();
            fleetToshow = fleet;
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

        private void InitializeComponent()
        {
            SuspendLayout();
            ClientSize = new Size(886, 446);
            Name = "ImgRedGreentree";
            ResumeLayout(false);
        }

        private void DrawNode(Node node, Graphics graphics, int x, int y, int offsetX)
        {
            if(node.color == Colors.Black)
            {
                graphics.FillEllipse(Brushes.Black, x - NodeRadius, y - NodeRadius, 2 * NodeRadius, 2 * NodeRadius);
            }
            else if(node.color == Colors.Red)
            {
                graphics.FillEllipse(Brushes.Red, x - NodeRadius, y - NodeRadius, 2 * NodeRadius, 2 * NodeRadius);
            }
            graphics.DrawEllipse(Pens.Black, x - NodeRadius, y - NodeRadius, 2 * NodeRadius, 2 * NodeRadius);
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
