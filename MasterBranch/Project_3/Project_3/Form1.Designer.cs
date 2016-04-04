namespace Project_3
{
    partial class Form1
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Parser = new System.Windows.Forms.OpenFileDialog();
            this.Parser_Textbox = new System.Windows.Forms.TextBox();
            this.Parser_Button = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(834, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parserToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // parserToolStripMenuItem
            // 
            this.parserToolStripMenuItem.Name = "parserToolStripMenuItem";
            this.parserToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.parserToolStripMenuItem.Text = "Parser";
            this.parserToolStripMenuItem.Click += new System.EventHandler(this.parserToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Parser
            // 
            this.Parser.FileName = "Parser";
            this.Parser.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // Parser_Textbox
            // 
            this.Parser_Textbox.Location = new System.Drawing.Point(12, 27);
            this.Parser_Textbox.Multiline = true;
            this.Parser_Textbox.Name = "Parser_Textbox";
            this.Parser_Textbox.Size = new System.Drawing.Size(811, 214);
            this.Parser_Textbox.TabIndex = 1;
            // 
            // Parser_Button
            // 
            this.Parser_Button.Location = new System.Drawing.Point(13, 246);
            this.Parser_Button.Name = "Parser_Button";
            this.Parser_Button.Size = new System.Drawing.Size(75, 23);
            this.Parser_Button.TabIndex = 2;
            this.Parser_Button.Text = "Parse!";
            this.Parser_Button.UseVisualStyleBackColor = true;
            this.Parser_Button.Click += new System.EventHandler(this.Parser_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 281);
            this.Controls.Add(this.Parser_Button);
            this.Controls.Add(this.Parser_Textbox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parserToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog Parser;
        private System.Windows.Forms.TextBox Parser_Textbox;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button Parser_Button;
    }
}

