namespace DL_Converter
{
    partial class UserInterface
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txTextBox = new System.Windows.Forms.TextBox();
            this.dlTextBox = new System.Windows.Forms.TextBox();
            this.generateButton = new System.Windows.Forms.Button();
            this.txLabel = new System.Windows.Forms.Label();
            this.dlLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(267, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // txTextBox
            // 
            this.txTextBox.Location = new System.Drawing.Point(37, 49);
            this.txTextBox.Name = "txTextBox";
            this.txTextBox.Size = new System.Drawing.Size(70, 20);
            this.txTextBox.TabIndex = 1;
            // 
            // dlTextBox
            // 
            this.dlTextBox.Location = new System.Drawing.Point(158, 49);
            this.dlTextBox.Name = "dlTextBox";
            this.dlTextBox.Size = new System.Drawing.Size(70, 20);
            this.dlTextBox.TabIndex = 2;
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(94, 75);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(75, 23);
            this.generateButton.TabIndex = 3;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // txLabel
            // 
            this.txLabel.AutoSize = true;
            this.txLabel.Location = new System.Drawing.Point(53, 33);
            this.txLabel.Name = "txLabel";
            this.txLabel.Size = new System.Drawing.Size(33, 13);
            this.txLabel.TabIndex = 4;
            this.txLabel.Text = "Tx ID";
            // 
            // dlLabel
            // 
            this.dlLabel.AutoSize = true;
            this.dlLabel.Location = new System.Drawing.Point(182, 33);
            this.dlLabel.Name = "dlLabel";
            this.dlLabel.Size = new System.Drawing.Size(21, 13);
            this.dlLabel.TabIndex = 5;
            this.dlLabel.Text = "DL";
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 114);
            this.Controls.Add(this.dlLabel);
            this.Controls.Add(this.txLabel);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.dlTextBox);
            this.Controls.Add(this.txTextBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "UserInterface";
            this.Text = "DL Converter";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TextBox txTextBox;
        private System.Windows.Forms.TextBox dlTextBox;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Label txLabel;
        private System.Windows.Forms.Label dlLabel;
    }
}

