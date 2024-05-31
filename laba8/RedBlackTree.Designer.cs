namespace laba8
{
    partial class RedBlackTreeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            lbrez = new ListBox();
            btnrez = new Button();
            btnsaveSailor = new Button();
            tbsailorNum = new TextBox();
            btnaddship = new Button();
            btnprinttree = new Button();
            btnsavepirate = new Button();
            tbNumofpirate = new TextBox();
            btndeletasailor = new Button();
            tbNumofsailorTodalate = new TextBox();
            btndeleteship = new Button();
            SuspendLayout();
            // 
            // lbrez
            // 
            lbrez.Enabled = false;
            lbrez.FormattingEnabled = true;
            lbrez.ItemHeight = 20;
            lbrez.Location = new Point(454, 176);
            lbrez.Name = "lbrez";
            lbrez.Size = new Size(291, 244);
            lbrez.TabIndex = 20;
            // 
            // btnrez
            // 
            btnrez.Enabled = false;
            btnrez.Location = new Point(89, 244);
            btnrez.Name = "btnrez";
            btnrez.Size = new Size(171, 29);
            btnrez.TabIndex = 19;
            btnrez.Text = "Отримати результат";
            btnrez.UseVisualStyleBackColor = true;
            btnrez.Click += btnrez_Click;
            // 
            // btnsaveSailor
            // 
            btnsaveSailor.Location = new Point(226, 148);
            btnsaveSailor.Name = "btnsaveSailor";
            btnsaveSailor.Size = new Size(94, 29);
            btnsaveSailor.TabIndex = 18;
            btnsaveSailor.Text = "Зберегти";
            btnsaveSailor.UseVisualStyleBackColor = true;
            btnsaveSailor.Visible = false;
            btnsaveSailor.Click += btnsaveSailor_Click;
            // 
            // tbsailorNum
            // 
            tbsailorNum.Location = new Point(55, 148);
            tbsailorNum.Name = "tbsailorNum";
            tbsailorNum.Size = new Size(125, 27);
            tbsailorNum.TabIndex = 17;
            tbsailorNum.Visible = false;
            // 
            // btnaddship
            // 
            btnaddship.Location = new Point(81, 113);
            btnaddship.Name = "btnaddship";
            btnaddship.Size = new Size(213, 29);
            btnaddship.TabIndex = 16;
            btnaddship.Text = "Додати корабель";
            btnaddship.UseVisualStyleBackColor = true;
            btnaddship.Click += btnaddship_Click;
            // 
            // btnprinttree
            // 
            btnprinttree.Location = new Point(510, 31);
            btnprinttree.Name = "btnprinttree";
            btnprinttree.Size = new Size(213, 29);
            btnprinttree.TabIndex = 15;
            btnprinttree.Text = "Вивести дерево";
            btnprinttree.UseVisualStyleBackColor = true;
            btnprinttree.Click += btnprinttree_Click;
            // 
            // btnsavepirate
            // 
            btnsavepirate.Location = new Point(226, 32);
            btnsavepirate.Name = "btnsavepirate";
            btnsavepirate.Size = new Size(213, 29);
            btnsavepirate.TabIndex = 14;
            btnsavepirate.Text = "Підтвердити к-ть піратів";
            btnsavepirate.UseVisualStyleBackColor = true;
            btnsavepirate.Click += btnsavepirate_Click;
            // 
            // tbNumofpirate
            // 
            tbNumofpirate.Location = new Point(55, 32);
            tbNumofpirate.Name = "tbNumofpirate";
            tbNumofpirate.Size = new Size(125, 27);
            tbNumofpirate.TabIndex = 13;
            // 
            // btndeletasailor
            // 
            btndeletasailor.Location = new Point(226, 346);
            btndeletasailor.Name = "btndeletasailor";
            btndeletasailor.Size = new Size(113, 29);
            btndeletasailor.TabIndex = 23;
            btndeletasailor.Text = "Підтвердити";
            btndeletasailor.UseVisualStyleBackColor = true;
            btndeletasailor.Visible = false;
            btndeletasailor.Click += btndeletasailor_Click;
            // 
            // tbNumofsailorTodalate
            // 
            tbNumofsailorTodalate.Location = new Point(55, 346);
            tbNumofsailorTodalate.Name = "tbNumofsailorTodalate";
            tbNumofsailorTodalate.Size = new Size(125, 27);
            tbNumofsailorTodalate.TabIndex = 22;
            tbNumofsailorTodalate.Visible = false;
            // 
            // btndeleteship
            // 
            btndeleteship.Location = new Point(81, 311);
            btndeleteship.Name = "btndeleteship";
            btndeleteship.Size = new Size(213, 29);
            btndeleteship.TabIndex = 21;
            btndeleteship.Text = "Корабель сів на міль";
            btndeleteship.UseVisualStyleBackColor = true;
            btndeleteship.Click += btndeleteship_Click;
            // 
            // RedBlackTreeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btndeletasailor);
            Controls.Add(tbNumofsailorTodalate);
            Controls.Add(btndeleteship);
            Controls.Add(lbrez);
            Controls.Add(btnrez);
            Controls.Add(btnsaveSailor);
            Controls.Add(tbsailorNum);
            Controls.Add(btnaddship);
            Controls.Add(btnprinttree);
            Controls.Add(btnsavepirate);
            Controls.Add(tbNumofpirate);
            Name = "RedBlackTreeForm";
            Text = "RedBlackTree";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbrez;
        private Button btnrez;
        private Button btnsaveSailor;
        private TextBox tbsailorNum;
        private Button btnaddship;
        private Button btnprinttree;
        private Button btnsavepirate;
        private TextBox tbNumofpirate;
        private Button btndeletasailor;
        private TextBox tbNumofsailorTodalate;
        private Button btndeleteship;
    }
}