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
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Parser = new System.Windows.Forms.OpenFileDialog();
            this.Parser_Textbox = new System.Windows.Forms.TextBox();
            this.Parser_Button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.Server_Address_TB = new System.Windows.Forms.TextBox();
            this.Server_Port_TB = new System.Windows.Forms.TextBox();
            this.Server_UName_TB = new System.Windows.Forms.TextBox();
            this.Server_UPass_TB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Server_Data_TB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Server_Connect = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(898, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parserToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.restartToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // parserToolStripMenuItem
            // 
            this.parserToolStripMenuItem.Name = "parserToolStripMenuItem";
            this.parserToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.parserToolStripMenuItem.Text = "Parser";
            this.parserToolStripMenuItem.Click += new System.EventHandler(this.parserToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.restartToolStripMenuItem.Text = "Restart";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
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
            this.Parser_Textbox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Parser_Textbox.Size = new System.Drawing.Size(433, 297);
            this.Parser_Textbox.TabIndex = 1;
            this.Parser_Textbox.TextChanged += new System.EventHandler(this.Parser_Textbox_TextChanged);
            // 
            // Parser_Button
            // 
            this.Parser_Button.AutoSize = true;
            this.Parser_Button.Location = new System.Drawing.Point(12, 330);
            this.Parser_Button.Name = "Parser_Button";
            this.Parser_Button.Size = new System.Drawing.Size(75, 23);
            this.Parser_Button.TabIndex = 2;
            this.Parser_Button.Text = "Parse!";
            this.Parser_Button.UseVisualStyleBackColor = true;
            this.Parser_Button.Click += new System.EventHandler(this.Parser_Button_Click);
            // 
            // textBox1
            // 
            this.textBox1.HideSelection = false;
            this.textBox1.Location = new System.Drawing.Point(451, 27);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(435, 297);
            this.textBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(576, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Webbrowser!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(94, 330);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Clear TextBox";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(451, 330);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Clear TextBox";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(657, 366);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(229, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "Push to database";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(657, 330);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(229, 23);
            this.button5.TabIndex = 8;
            this.button5.Text = "Copy to Clipboard";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Server_Address_TB
            // 
            this.Server_Address_TB.Location = new System.Drawing.Point(12, 368);
            this.Server_Address_TB.Name = "Server_Address_TB";
            this.Server_Address_TB.Size = new System.Drawing.Size(100, 20);
            this.Server_Address_TB.TabIndex = 9;
            this.Server_Address_TB.Text = "127.0.0.1";
            // 
            // Server_Port_TB
            // 
            this.Server_Port_TB.Location = new System.Drawing.Point(12, 394);
            this.Server_Port_TB.Name = "Server_Port_TB";
            this.Server_Port_TB.Size = new System.Drawing.Size(100, 20);
            this.Server_Port_TB.TabIndex = 10;
            this.Server_Port_TB.Text = "5432";
            // 
            // Server_UName_TB
            // 
            this.Server_UName_TB.Location = new System.Drawing.Point(251, 368);
            this.Server_UName_TB.Name = "Server_UName_TB";
            this.Server_UName_TB.Size = new System.Drawing.Size(100, 20);
            this.Server_UName_TB.TabIndex = 11;
            this.Server_UName_TB.Text = "postgres";
            // 
            // Server_UPass_TB
            // 
            this.Server_UPass_TB.Location = new System.Drawing.Point(251, 394);
            this.Server_UPass_TB.Multiline = true;
            this.Server_UPass_TB.Name = "Server_UPass_TB";
            this.Server_UPass_TB.PasswordChar = '*';
            this.Server_UPass_TB.Size = new System.Drawing.Size(100, 20);
            this.Server_UPass_TB.TabIndex = 12;
            this.Server_UPass_TB.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 374);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Server Address";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 397);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(366, 374);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "User Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(366, 397);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "User Password";
            // 
            // Server_Data_TB
            // 
            this.Server_Data_TB.Location = new System.Drawing.Point(13, 421);
            this.Server_Data_TB.Name = "Server_Data_TB";
            this.Server_Data_TB.Size = new System.Drawing.Size(100, 20);
            this.Server_Data_TB.TabIndex = 17;
            this.Server_Data_TB.Text = "Project_3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(122, 427);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Database Name";
            // 
            // Server_Connect
            // 
            this.Server_Connect.Location = new System.Drawing.Point(251, 424);
            this.Server_Connect.Name = "Server_Connect";
            this.Server_Connect.Size = new System.Drawing.Size(193, 23);
            this.Server_Connect.TabIndex = 19;
            this.Server_Connect.Text = "Connect to Database";
            this.Server_Connect.UseVisualStyleBackColor = true;
            this.Server_Connect.Click += new System.EventHandler(this.Server_Connect_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(492, 406);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 458);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Not Connected";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(898, 597);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Server_Connect);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Server_Data_TB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Server_UPass_TB);
            this.Controls.Add(this.Server_UName_TB);
            this.Controls.Add(this.Server_Port_TB);
            this.Controls.Add(this.Server_Address_TB);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Parser_Button);
            this.Controls.Add(this.Parser_Textbox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox Server_Address_TB;
        private System.Windows.Forms.TextBox Server_Port_TB;
        private System.Windows.Forms.TextBox Server_UName_TB;
        private System.Windows.Forms.TextBox Server_UPass_TB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Server_Data_TB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Server_Connect;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
    }
}

