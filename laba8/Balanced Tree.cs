using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba8
{
    public partial class Balanced_Tree : Form
    {
        balancedTree<int> charger = new();
        int power;
        List<int> path = new List<int>();
        public Balanced_Tree()
        {
            InitializeComponent();
            charger.Insert(50);
            charger.Insert(30);
            charger.Insert(20);
            charger.Insert(40);
            charger.Insert(70);
            charger.Insert(60);
            charger.Insert(80);
            charger.Insert(55);
            charger.Insert(35);
            charger.Insert(25);
            charger.Insert(45);
            charger.Insert(75);
            charger.Insert(65);
            charger.Insert(85);
            charger.Insert(90);
        }

        private void buttonSavePower_Click(object sender, EventArgs e)
        {
            try
            {
                power = int.Parse(texboxFindPower.Text);
                texboxFindPower.Enabled = false;
                buttonSavePower.Enabled = false;
                buttonRes.Enabled = true;
            }
            catch
            {
                texboxFindPower.Text = null;
                MessageBox.Show("Неправильно введено потужність, використовувати лише цифр");
            }
        }

        private void buttonPrintTree_Click(object sender, EventArgs e)
        {
            ImgTree imgTree = new ImgTree(charger);
            imgTree.Show();
        }

        private void buttonAddCharger_Click(object sender, EventArgs e)
        {
            textboxPoverAdd.Visible = true;
            buttonSaveCharger.Visible = true;
        }

        private void buttonSaveCharger_Click(object sender, EventArgs e)
        {
            try
            {
                charger.Insert(int.Parse(textboxPoverAdd.Text));
                //textboxPoverAdd.Visible = false;
                //buttonSaveCharger.Visible = false;
                textboxPoverAdd.Text = string.Empty;
            }
            catch
            {
                texboxFindPower.Text = null;
                MessageBox.Show("Неправильно введено потужність, використовувати лише цифри");
            }
        }

        private void buttonRes_Click(object sender, EventArgs e)
        {
            string s = "";
            int findPower = charger.FindClosestValue(power);
            if (findPower != null && findPower >= power)
            {
                path = charger.ValuesFromRootToTarget(findPower);
                listboxRes.Items.Add($"Робот запросив пристрій потужністю: {findPower}");
                listboxRes.Items.Add($"Шлях до пристро з потужністю {findPower}:");
                foreach (var value in path)
                {
                    s += value + "->";

                }
                listboxRes.Items.Add($"{s}");
                Imgrezbalanced imgresbalanced = new Imgrezbalanced(charger, path);
                imgresbalanced.Show();
            }
            else
            {
                listboxRes.Items.Add("Немає підходящого зарядного притрою");
            }
        }

        private void buttonDeleteCharger_Click(object sender, EventArgs e)
        {
            textboxPowerToDelete.Visible = true;
            buttonDeletePower.Visible = true;
        }

        private void buttonDeletePower_Click(object sender, EventArgs e)
        {
            try
            {
                int iscontain = charger.FindClosestValue(int.Parse(textboxPowerToDelete.Text));
                if (iscontain == int.Parse(textboxPowerToDelete.Text))
                {
                    charger.Delete(int.Parse(textboxPowerToDelete.Text));
                    MessageBox.Show($"Пристрій з потужністю {int.Parse(textboxPowerToDelete.Text)} виведений з ладу та знищений");
                }
                else { MessageBox.Show("Немає пристрою з такою потужністю"); }
                //textboxPowerToDelete.Visible = false;
                //buttonDeletePower.Visible = false;
                textboxPowerToDelete.Text = string.Empty;
            }
            catch { MessageBox.Show("Неправильно введено значення потужності пристрою, використовуйте лише цифри"); }
        }

    }
}
