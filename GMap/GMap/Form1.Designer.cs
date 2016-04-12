/*  Deze file is van: "Marco den Hollander"
*
*/

namespace GMap
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
            this.gmap = new GMap.NET.WindowsForms.GMapControl();
            this.DrawMarker = new System.Windows.Forms.Button();
            this.DrawMarker2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ZoomScroll = new System.Windows.Forms.HScrollBar();
            this.ZoomBox = new System.Windows.Forms.RichTextBox();
            this.XCoordBox = new System.Windows.Forms.RichTextBox();
            this.YCoordBox = new System.Windows.Forms.RichTextBox();
            this.LabelX = new System.Windows.Forms.Label();
            this.LabelY = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gmap
            // 
            this.gmap.Bearing = 0F;
            this.gmap.CanDragMap = true;
            this.gmap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmap.GrayScaleMode = false;
            this.gmap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmap.LevelsKeepInMemmory = 5;
            this.gmap.Location = new System.Drawing.Point(12, 12);
            this.gmap.MarkersEnabled = true;
            this.gmap.MaxZoom = 18;
            this.gmap.MinZoom = 0;
            this.gmap.MouseWheelZoomEnabled = false;
            this.gmap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionWithoutCenter;
            this.gmap.Name = "gmap";
            this.gmap.NegativeMode = false;
            this.gmap.PolygonsEnabled = true;
            this.gmap.RetryLoadTile = 0;
            this.gmap.RoutesEnabled = true;
            this.gmap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmap.ShowTileGridLines = false;
            this.gmap.Size = new System.Drawing.Size(621, 593);
            this.gmap.TabIndex = 0;
            this.gmap.Zoom = 11D;
            this.gmap.Load += new System.EventHandler(this.gmap_Load);
            // 
            // DrawMarker
            // 
            this.DrawMarker.Location = new System.Drawing.Point(651, 538);
            this.DrawMarker.Name = "DrawMarker";
            this.DrawMarker.Size = new System.Drawing.Size(156, 67);
            this.DrawMarker.TabIndex = 1;
            this.DrawMarker.Text = "Draw Marker";
            this.DrawMarker.UseVisualStyleBackColor = true;
            this.DrawMarker.Click += new System.EventHandler(this.DrawRect_Click);
            // 
            // DrawMarker2
            // 
            this.DrawMarker2.Location = new System.Drawing.Point(813, 538);
            this.DrawMarker2.Name = "DrawMarker2";
            this.DrawMarker2.Size = new System.Drawing.Size(151, 67);
            this.DrawMarker2.TabIndex = 2;
            this.DrawMarker2.Text = "Draw Marker 2";
            this.DrawMarker2.UseVisualStyleBackColor = true;
            this.DrawMarker2.Click += new System.EventHandler(this.DrawMarker2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(639, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Zoom";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ZoomScroll
            // 
            this.ZoomScroll.LargeChange = 1;
            this.ZoomScroll.Location = new System.Drawing.Point(676, 12);
            this.ZoomScroll.Maximum = 18;
            this.ZoomScroll.Name = "ZoomScroll";
            this.ZoomScroll.Size = new System.Drawing.Size(259, 20);
            this.ZoomScroll.TabIndex = 5;
            this.ZoomScroll.Value = 11;
            this.ZoomScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ZoomScroll_Scroll);
            // 
            // ZoomBox
            // 
            this.ZoomBox.Location = new System.Drawing.Point(938, 12);
            this.ZoomBox.Name = "ZoomBox";
            this.ZoomBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.ZoomBox.Size = new System.Drawing.Size(26, 20);
            this.ZoomBox.TabIndex = 6;
            this.ZoomBox.Text = "";
            this.ZoomBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // XCoordBox
            // 
            this.XCoordBox.Location = new System.Drawing.Point(864, 417);
            this.XCoordBox.Name = "XCoordBox";
            this.XCoordBox.Size = new System.Drawing.Size(100, 32);
            this.XCoordBox.TabIndex = 7;
            this.XCoordBox.Text = "";
            this.XCoordBox.TextChanged += new System.EventHandler(this.XCoordBox_TextChanged);
            // 
            // YCoordBox
            // 
            this.YCoordBox.Location = new System.Drawing.Point(864, 455);
            this.YCoordBox.Name = "YCoordBox";
            this.YCoordBox.Size = new System.Drawing.Size(100, 33);
            this.YCoordBox.TabIndex = 8;
            this.YCoordBox.Text = "";
            // 
            // LabelX
            // 
            this.LabelX.AutoSize = true;
            this.LabelX.Location = new System.Drawing.Point(844, 420);
            this.LabelX.Name = "LabelX";
            this.LabelX.Size = new System.Drawing.Size(14, 13);
            this.LabelX.TabIndex = 9;
            this.LabelX.Text = "X";
            this.LabelX.Click += new System.EventHandler(this.label2_Click);
            // 
            // LabelY
            // 
            this.LabelY.AutoSize = true;
            this.LabelY.Location = new System.Drawing.Point(844, 458);
            this.LabelY.Name = "LabelY";
            this.LabelY.Size = new System.Drawing.Size(14, 13);
            this.LabelY.TabIndex = 10;
            this.LabelY.Text = "Y";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(676, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(288, 64);
            this.button1.TabIndex = 11;
            this.button1.Text = "Option 1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(676, 108);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(288, 64);
            this.button2.TabIndex = 12;
            this.button2.Text = "Option 2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(676, 178);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(288, 64);
            this.button3.TabIndex = 13;
            this.button3.Text = "Option 3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(676, 248);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(288, 64);
            this.button4.TabIndex = 14;
            this.button4.Text = "Option 4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(676, 318);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(288, 64);
            this.button5.TabIndex = 15;
            this.button5.Text = "Option 5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(976, 617);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LabelY);
            this.Controls.Add(this.LabelX);
            this.Controls.Add(this.YCoordBox);
            this.Controls.Add(this.XCoordBox);
            this.Controls.Add(this.ZoomBox);
            this.Controls.Add(this.ZoomScroll);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DrawMarker2);
            this.Controls.Add(this.DrawMarker);
            this.Controls.Add(this.gmap);
            this.Name = "Form1";
            this.Text = "Blipmap";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NET.WindowsForms.GMapControl gmap;
        private System.Windows.Forms.Button DrawMarker;
        private System.Windows.Forms.Button DrawMarker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.HScrollBar ZoomScroll;
        private System.Windows.Forms.RichTextBox ZoomBox;
        private System.Windows.Forms.RichTextBox XCoordBox;
        private System.Windows.Forms.RichTextBox YCoordBox;
        private System.Windows.Forms.Label LabelX;
        private System.Windows.Forms.Label LabelY;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

