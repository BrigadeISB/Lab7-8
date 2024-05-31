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
    public partial class Choose : Form
    {
        public Choose()
        {
            InitializeComponent();
        }

        private void btnbalancedtree_Click(object sender, EventArgs e)
        {
            Balanced_Tree balanced_Tree = new Balanced_Tree();
            balanced_Tree.Show();
        }

        private void btnredblacktree_Click(object sender, EventArgs e)
        {
            //RedBlackTreeForm redBlackTree = new RedBlackTreeForm();
            //redBlackTree.Show();
        }
    }
}
