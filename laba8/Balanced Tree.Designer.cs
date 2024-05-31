namespace laba8
{
    partial class Balanced_Tree
    {

        private System.ComponentModel.IContainer components = null;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonSavePower = new Button();
            texboxFindPower = new TextBox();
            buttonPrintTree = new Button();
            buttonAddCharger = new Button();
            textboxPoverAdd = new TextBox();
            buttonSaveCharger = new Button();
            listboxRes = new ListBox();
            buttonRes = new Button();
            buttonDeletePower = new Button();
            textboxPowerToDelete = new TextBox();
            buttonDeleteCharger = new Button();
            SuspendLayout();
            // 
            // buttonSavePower
            // 
            buttonSavePower.Location = new Point(54, 39);
            buttonSavePower.Margin = new Padding(3, 2, 3, 2);
            buttonSavePower.Name = "buttonSavePower";
            buttonSavePower.Size = new Size(186, 50);
            buttonSavePower.TabIndex = 5;
            buttonSavePower.Text = "Зберегти значення потужності шуканого пристрою";
            buttonSavePower.UseVisualStyleBackColor = true;
            buttonSavePower.Click += buttonSavePower_Click;
            // 
            // texboxFindPower
            // 
            texboxFindPower.Location = new Point(90, 11);
            texboxFindPower.Margin = new Padding(3, 2, 3, 2);
            texboxFindPower.Name = "texboxFindPower";
            texboxFindPower.Size = new Size(110, 23);
            texboxFindPower.TabIndex = 4;
            // 
            // buttonPrintTree
            // 
            buttonPrintTree.Location = new Point(387, 11);
            buttonPrintTree.Margin = new Padding(3, 2, 3, 2);
            buttonPrintTree.Name = "buttonPrintTree";
            buttonPrintTree.Size = new Size(186, 78);
            buttonPrintTree.TabIndex = 6;
            buttonPrintTree.Text = "Вивести дерево";
            buttonPrintTree.UseVisualStyleBackColor = true;
            buttonPrintTree.Click += buttonPrintTree_Click;
            // 
            // buttonAddCharger
            // 
            buttonAddCharger.Location = new Point(387, 99);
            buttonAddCharger.Margin = new Padding(3, 2, 3, 2);
            buttonAddCharger.Name = "buttonAddCharger";
            buttonAddCharger.Size = new Size(186, 22);
            buttonAddCharger.TabIndex = 7;
            buttonAddCharger.Text = "Додати пристрій";
            buttonAddCharger.UseVisualStyleBackColor = true;
            buttonAddCharger.Click += buttonAddCharger_Click;
            // 
            // textboxPoverAdd
            // 
            textboxPoverAdd.Location = new Point(364, 126);
            textboxPoverAdd.Margin = new Padding(3, 2, 3, 2);
            textboxPoverAdd.Name = "textboxPoverAdd";
            textboxPoverAdd.Size = new Size(110, 23);
            textboxPoverAdd.TabIndex = 8;
            textboxPoverAdd.Visible = false;
            // 
            // buttonSaveCharger
            // 
            buttonSaveCharger.Location = new Point(513, 125);
            buttonSaveCharger.Margin = new Padding(3, 2, 3, 2);
            buttonSaveCharger.Name = "buttonSaveCharger";
            buttonSaveCharger.Size = new Size(82, 22);
            buttonSaveCharger.TabIndex = 9;
            buttonSaveCharger.Text = "Зберегти";
            buttonSaveCharger.UseVisualStyleBackColor = true;
            buttonSaveCharger.Visible = false;
            buttonSaveCharger.Click += buttonSaveCharger_Click;
            // 
            // listboxRes
            // 
            listboxRes.Enabled = false;
            listboxRes.FormattingEnabled = true;
            listboxRes.ItemHeight = 15;
            listboxRes.Location = new Point(29, 99);
            listboxRes.Margin = new Padding(3, 2, 3, 2);
            listboxRes.Name = "listboxRes";
            listboxRes.Size = new Size(255, 214);
            listboxRes.TabIndex = 12;
            // 
            // buttonRes
            // 
            buttonRes.Enabled = false;
            buttonRes.Location = new Point(387, 162);
            buttonRes.Margin = new Padding(3, 2, 3, 2);
            buttonRes.Name = "buttonRes";
            buttonRes.Size = new Size(186, 49);
            buttonRes.TabIndex = 11;
            buttonRes.Text = "Отримати шлях";
            buttonRes.UseVisualStyleBackColor = true;
            buttonRes.Click += buttonRes_Click;
            // 
            // buttonDeletePower
            // 
            buttonDeletePower.Location = new Point(513, 282);
            buttonDeletePower.Margin = new Padding(3, 2, 3, 2);
            buttonDeletePower.Name = "buttonDeletePower";
            buttonDeletePower.Size = new Size(99, 22);
            buttonDeletePower.TabIndex = 26;
            buttonDeletePower.Text = "Підтвердити";
            buttonDeletePower.UseVisualStyleBackColor = true;
            buttonDeletePower.Visible = false;
            buttonDeletePower.Click += buttonDeletePower_Click;
            // 
            // textboxPowerToDelete
            // 
            textboxPowerToDelete.Location = new Point(364, 281);
            textboxPowerToDelete.Margin = new Padding(3, 2, 3, 2);
            textboxPowerToDelete.Name = "textboxPowerToDelete";
            textboxPowerToDelete.Size = new Size(110, 23);
            textboxPowerToDelete.TabIndex = 25;
            textboxPowerToDelete.Visible = false;
            // 
            // buttonDeleteCharger
            // 
            buttonDeleteCharger.Location = new Point(387, 225);
            buttonDeleteCharger.Margin = new Padding(3, 2, 3, 2);
            buttonDeleteCharger.Name = "buttonDeleteCharger";
            buttonDeleteCharger.Size = new Size(186, 52);
            buttonDeleteCharger.TabIndex = 24;
            buttonDeleteCharger.Text = "Видалити пошкоджений пристрій";
            buttonDeleteCharger.UseVisualStyleBackColor = true;
            buttonDeleteCharger.Click += buttonDeleteCharger_Click;
            // 
            // Balanced_Tree
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.supernova_2_1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(700, 338);
            Controls.Add(buttonDeletePower);
            Controls.Add(textboxPowerToDelete);
            Controls.Add(buttonDeleteCharger);
            Controls.Add(listboxRes);
            Controls.Add(buttonRes);
            Controls.Add(buttonSaveCharger);
            Controls.Add(textboxPoverAdd);
            Controls.Add(buttonAddCharger);
            Controls.Add(buttonPrintTree);
            Controls.Add(buttonSavePower);
            Controls.Add(texboxFindPower);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Balanced_Tree";
            Text = "Balanced_Tree";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSavePower;
        private TextBox texboxFindPower;
        private Button buttonPrintTree;
        private Button buttonAddCharger;
        private TextBox textboxPoverAdd;
        private Button buttonSaveCharger;
        private ListBox listboxRes;
        private Button buttonRes;
        private Button buttonDeletePower;
        private TextBox textboxPowerToDelete;
        private Button buttonDeleteCharger;
    }
}