namespace laba8
{
    partial class Choose
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
            btnbalancedtree = new Button();
            btnredblacktree = new Button();
            SuspendLayout();
            // 
            // btnbalancedtree
            // 
            btnbalancedtree.Location = new Point(80, 116);
            btnbalancedtree.Margin = new Padding(3, 2, 3, 2);
            btnbalancedtree.Name = "btnbalancedtree";
            btnbalancedtree.Size = new Size(247, 105);
            btnbalancedtree.TabIndex = 0;
            btnbalancedtree.Text = "Використати збалансоване дерево";
            btnbalancedtree.UseVisualStyleBackColor = true;
            btnbalancedtree.Click += btnbalancedtree_Click;
            // 
            // btnredblacktree
            // 
            btnredblacktree.Location = new Point(373, 116);
            btnredblacktree.Margin = new Padding(3, 2, 3, 2);
            btnredblacktree.Name = "btnredblacktree";
            btnredblacktree.Size = new Size(247, 105);
            btnredblacktree.TabIndex = 1;
            btnredblacktree.Text = "Використати червоно чорне дерево дерево";
            btnredblacktree.UseVisualStyleBackColor = true;
            btnredblacktree.Click += btnredblacktree_Click;
            // 
            // Choose
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(btnredblacktree);
            Controls.Add(btnbalancedtree);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Choose";
            Text = "Choose";
            ResumeLayout(false);
        }

        #endregion

        private Button btnbalancedtree;
        private Button btnredblacktree;
    }
}