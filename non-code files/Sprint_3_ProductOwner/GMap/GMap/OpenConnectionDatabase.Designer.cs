namespace GMap
{
    partial class OpenConnectionDatabase
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
            this.TB_ServerAddress = new System.Windows.Forms.TextBox();
            this.TB_Password = new System.Windows.Forms.TextBox();
            this.TB_ServerUname = new System.Windows.Forms.TextBox();
            this.TB_Database = new System.Windows.Forms.TextBox();
            this.TB_ServerPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TB_ServerAddress
            // 
            this.TB_ServerAddress.Location = new System.Drawing.Point(13, 13);
            this.TB_ServerAddress.Name = "TB_ServerAddress";
            this.TB_ServerAddress.Size = new System.Drawing.Size(100, 20);
            this.TB_ServerAddress.TabIndex = 0;
            this.TB_ServerAddress.Text = "localhost";
            // 
            // TB_Password
            // 
            this.TB_Password.Location = new System.Drawing.Point(12, 117);
            this.TB_Password.Name = "TB_Password";
            this.TB_Password.Size = new System.Drawing.Size(100, 20);
            this.TB_Password.TabIndex = 1;
            this.TB_Password.Text = "1234";
            // 
            // TB_ServerUname
            // 
            this.TB_ServerUname.Location = new System.Drawing.Point(12, 91);
            this.TB_ServerUname.Name = "TB_ServerUname";
            this.TB_ServerUname.Size = new System.Drawing.Size(100, 20);
            this.TB_ServerUname.TabIndex = 2;
            this.TB_ServerUname.Text = "Admin";
            // 
            // TB_Database
            // 
            this.TB_Database.Location = new System.Drawing.Point(13, 65);
            this.TB_Database.Name = "TB_Database";
            this.TB_Database.Size = new System.Drawing.Size(100, 20);
            this.TB_Database.TabIndex = 3;
            this.TB_Database.Text = "Project_3";
            // 
            // TB_ServerPort
            // 
            this.TB_ServerPort.Location = new System.Drawing.Point(12, 39);
            this.TB_ServerPort.Name = "TB_ServerPort";
            this.TB_ServerPort.Size = new System.Drawing.Size(100, 20);
            this.TB_ServerPort.TabIndex = 4;
            this.TB_ServerPort.Text = "5432";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "User name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Server Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(125, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Database Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(125, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Server Port";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(118, 143);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // OpenConnectionDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 177);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_ServerPort);
            this.Controls.Add(this.TB_Database);
            this.Controls.Add(this.TB_ServerUname);
            this.Controls.Add(this.TB_Password);
            this.Controls.Add(this.TB_ServerAddress);
            this.Name = "OpenConnectionDatabase";
            this.Text = "OpenConnectionDatabase";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_ServerAddress;
        private System.Windows.Forms.TextBox TB_Password;
        private System.Windows.Forms.TextBox TB_ServerUname;
        private System.Windows.Forms.TextBox TB_Database;
        private System.Windows.Forms.TextBox TB_ServerPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}