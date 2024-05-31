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
    public partial class RedBlackTreeForm : Form
    {
        RedBlackTree fleet = new RedBlackTree();
        int piratesCount;
        List<int> path = new List<int>();
        public RedBlackTreeForm()
        {
            InitializeComponent();
            fleet.Insert(20);
            fleet.Insert(30);
            fleet.Insert(40);
            fleet.Insert(50);
            fleet.Insert(60);
            fleet.Insert(70);
            fleet.Insert(80);
            fleet.Insert(15);
        }

        private void btnsavepirate_Click(object sender, EventArgs e)
        {
            try
            {
                piratesCount = int.Parse(tbNumofpirate.Text);
                tbNumofpirate.Enabled = false;
                btnsavepirate.Enabled = false;
                btnrez.Enabled = true;
            }
            catch
            {
                tbNumofpirate.Text = null;
                MessageBox.Show("Неправильно введено к-ть піратів, використовувати лише цифри");
            }
        }

        private void btnprinttree_Click(object sender, EventArgs e)
        {
            ImgRedBlacktree imgRedGreentree = new ImgRedBlacktree(fleet);
            imgRedGreentree.Show();

        }

        private void btnaddship_Click(object sender, EventArgs e)
        {
            tbsailorNum.Visible = true;
            btnsaveSailor.Visible = true;
        }

        private void btnsaveSailor_Click(object sender, EventArgs e)
        {
            try
            {
                fleet.Insert(int.Parse(tbsailorNum.Text));
                tbsailorNum.Visible = false;
                btnsaveSailor.Visible = false;
                tbsailorNum.Text = string.Empty;
            }
            catch
            {
                tbNumofpirate.Text = null;
                MessageBox.Show("Неправильно введено к-ть моряків, використовувати лише цифри");
            }
        }

        private void btnrez_Click(object sender, EventArgs e)
        {
            string s = "";
            int? attackShip = fleet.FindMinGreaterOrEqual(piratesCount);
            //int temp = attackShip.Value;
            if (attackShip != null)
            {
                path = fleet.FindPathToLeaf(attackShip.Value);
                lbrez.Items.Add($"Admiral's Signal: {attackShip} sailors");
                lbrez.Items.Add($"Path to leaf with {attackShip} sailors:");
                foreach (var value in path)
                {
                    s += value + "->";

                }
                
                lbrez.Items.Add($"{s}");
                RezRedBlackTree rezRedBlackTree = new RezRedBlackTree(fleet, path);
                rezRedBlackTree.Show();

            }
            else
            {
                lbrez.Items.Add("No suitable ship found for attack.");
            }

        }

        private void btndeleteship_Click(object sender, EventArgs e)
        {
            tbNumofsailorTodalate.Visible = true;
            btndeletasailor.Visible = true;
        }

        private void btndeletasailor_Click(object sender, EventArgs e)
        {
            try
            {
                int? iscontain = fleet.FindMinGreaterOrEqual(int.Parse(tbNumofsailorTodalate.Text));
                if(iscontain.Value == int.Parse(tbNumofsailorTodalate.Text)) 
                {
                    fleet.Delete(int.Parse(tbNumofsailorTodalate.Text));
                    MessageBox.Show($"Корабель з {int.Parse(tbNumofsailorTodalate.Text)} моряками сів на міль");
                }
                else { MessageBox.Show("Немає коробля з такою кількістю моряків"); }
                tbNumofsailorTodalate.Visible = false;
                btndeletasailor.Visible = false;
                tbNumofsailorTodalate.Text = string.Empty;
            }
            catch { MessageBox.Show("Неправильно введено значення моряків, або корябля з такою кількістю моряків не було, використовуйте лише цифри"); }
        }
    }
}
