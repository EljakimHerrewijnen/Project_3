/*  Deze file is van: "Marco den Hollander"
*
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;

namespace GMap
{
    public partial class FormOld
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.gmap = new GMap.NET.WindowsForms.GMapControl();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DropdownYear = new System.Windows.Forms.ComboBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DropdownCrime = new System.Windows.Forms.ComboBox();
            this.PolygonDrawold = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.PolygonErase = new System.Windows.Forms.Button();
            this.Fijnoort = new System.Windows.Forms.Button();
            this.LatBox = new System.Windows.Forms.TextBox();
            this.LongBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.testbox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // gmap
            // 
            this.gmap.Bearing = 0F;
            this.gmap.CanDragMap = true;
            this.gmap.Dock = System.Windows.Forms.DockStyle.Left;
            this.gmap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmap.GrayScaleMode = false;
            this.gmap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmap.LevelsKeepInMemmory = 5;
            this.gmap.Location = new System.Drawing.Point(0, 0);
            this.gmap.Margin = new System.Windows.Forms.Padding(10);
            this.gmap.MarkersEnabled = true;
            this.gmap.MaxZoom = 18;
            this.gmap.MinZoom = 11;
            this.gmap.MouseWheelZoomEnabled = true;
            this.gmap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.ViewCenter;
            this.gmap.Name = "gmap";
            this.gmap.NegativeMode = false;
            this.gmap.Padding = new System.Windows.Forms.Padding(10);
            this.gmap.PolygonsEnabled = true;
            this.gmap.RetryLoadTile = 0;
            this.gmap.RoutesEnabled = true;
            this.gmap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmap.ShowTileGridLines = false;
            this.gmap.Size = new System.Drawing.Size(621, 619);
            this.gmap.TabIndex = 0;
            this.gmap.Zoom = 15D;
            this.gmap.OnMapZoomChanged += new GMap.NET.MapZoomChanged(this.gmap_ZoomChanged);
            this.gmap.Load += new System.EventHandler(this.gmap_Load);
            this.gmap.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gmap_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(634, 33);
            this.trackBar1.Maximum = 18;
            this.trackBar1.Minimum = 11;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(45, 525);
            this.trackBar1.TabIndex = 25;
            this.trackBar1.TickFrequency = 10;
            this.trackBar1.Value = 16;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(689, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Select Area:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(689, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Select Year:";
            // 
            // DropdownYear
            // 
            this.DropdownYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DropdownYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DropdownYear.FormattingEnabled = true;
            this.DropdownYear.Items.AddRange(new object[] {
            "",
            "2012",
            "2013",
            "2014"});
            this.DropdownYear.Location = new System.Drawing.Point(761, 70);
            this.DropdownYear.Name = "DropdownYear";
            this.DropdownYear.Size = new System.Drawing.Size(230, 21);
            this.DropdownYear.TabIndex = 20;
            // 
            // checkBox2
            // 
            this.checkBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(789, 6);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(104, 17);
            this.checkBox2.TabIndex = 19;
            this.checkBox2.Text = "Show Heatmaps";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(689, 6);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(94, 17);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Text = "Show Pointers";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(637, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Zoom";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(689, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Select Data:";
            // 
            // DropdownCrime
            // 
            this.DropdownCrime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DropdownCrime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DropdownCrime.FormattingEnabled = true;
            this.DropdownCrime.Items.AddRange(new object[] {
            "",
            "Diefstal",
            "Drugsoverlast",
            "Geweld",
            "Inbraak",
            "Vandalisme",
            "Overlast",
            "Schoon en heel",
            "Verkeer",
            "Overig"});
            this.DropdownCrime.Location = new System.Drawing.Point(761, 33);
            this.DropdownCrime.Name = "DropdownCrime";
            this.DropdownCrime.Size = new System.Drawing.Size(230, 21);
            this.DropdownCrime.TabIndex = 14;
            this.DropdownCrime.SelectedIndexChanged += new System.EventHandler(this.DropdownCrime_SelectedIndexChanged);
            // 
            // PolygonDrawold
            // 
            this.PolygonDrawold.Location = new System.Drawing.Point(881, 205);
            this.PolygonDrawold.Name = "PolygonDrawold";
            this.PolygonDrawold.Size = new System.Drawing.Size(107, 23);
            this.PolygonDrawold.TabIndex = 26;
            this.PolygonDrawold.Text = "Draw Polygons";
            this.PolygonDrawold.UseVisualStyleBackColor = true;
            this.PolygonDrawold.Click += new System.EventHandler(this.Test_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(689, 388);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 28;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "",
            "Charlois",
            "Delfshaven",
            "Feijenoord",
            "Hillegersberg Schiebroek",
            "Hoek van Holland",
            "Hoogvliet",
            "IJselmonde",
            "Kralingen Crooswijk",
            "Noord",
            "Overschie",
            "Pernis",
            "Prins Alexander",
            "Rozenburg",
            "Stadscentrum"});
            this.comboBox2.Location = new System.Drawing.Point(761, 107);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(230, 21);
            this.comboBox2.TabIndex = 29;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // PolygonErase
            // 
            this.PolygonErase.Location = new System.Drawing.Point(881, 234);
            this.PolygonErase.Name = "PolygonErase";
            this.PolygonErase.Size = new System.Drawing.Size(107, 23);
            this.PolygonErase.TabIndex = 33;
            this.PolygonErase.Text = "Erase Polygons";
            this.PolygonErase.UseVisualStyleBackColor = true;
            this.PolygonErase.Click += new System.EventHandler(this.PolygonErase_Click);
            // 
            // Fijnoort
            // 
            this.Fijnoort.Location = new System.Drawing.Point(836, 287);
            this.Fijnoort.Name = "Fijnoort";
            this.Fijnoort.Size = new System.Drawing.Size(155, 41);
            this.Fijnoort.TabIndex = 34;
            this.Fijnoort.Text = "instant feijenoord";
            this.Fijnoort.UseVisualStyleBackColor = true;
            this.Fijnoort.Click += new System.EventHandler(this.Fijnoort_Click);
            // 
            // LatBox
            // 
            this.LatBox.Location = new System.Drawing.Point(723, 140);
            this.LatBox.Name = "LatBox";
            this.LatBox.Size = new System.Drawing.Size(100, 20);
            this.LatBox.TabIndex = 35;
            this.LatBox.Text = "Memes";
            this.LatBox.TextChanged += new System.EventHandler(this.LatBox_TextChanged);
            // 
            // LongBox
            // 
            this.LongBox.Location = new System.Drawing.Point(868, 140);
            this.LongBox.Name = "LongBox";
            this.LongBox.Size = new System.Drawing.Size(100, 20);
            this.LongBox.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(695, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Lat";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(831, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "Long";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Charlois",
            "Delfshaven",
            "Feijenoord",
            "Schiebroek",
            "Hoek_van_Holland",
            "Hoogvliet",
            "IJsselmonde",
            "Kralingen",
            "Noord",
            "Overschie",
            "Pernis",
            "Prins_Alexander",
            "Rozenburg",
            "Stadscentrum",
            "Cool",
            "Blijdorp"});
            this.checkedListBox1.Location = new System.Drawing.Point(689, 175);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 214);
            this.checkedListBox1.TabIndex = 40;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(668, 404);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Area Info";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(323, 203);
            this.chart1.TabIndex = 41;
            this.chart1.Text = "Area Info";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // testbox
            // 
            this.testbox.AutoSize = true;
            this.testbox.Location = new System.Drawing.Point(836, 175);
            this.testbox.Name = "testbox";
            this.testbox.Size = new System.Drawing.Size(80, 17);
            this.testbox.TabIndex = 42;
            this.testbox.Text = "checkBox3";
            this.testbox.UseVisualStyleBackColor = true;
            // 
            // FormOld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1000, 619);
            this.Controls.Add(this.testbox);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LongBox);
            this.Controls.Add(this.LatBox);
            this.Controls.Add(this.Fijnoort);
            this.Controls.Add(this.PolygonErase);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PolygonDrawold);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DropdownYear);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DropdownCrime);
            this.Controls.Add(this.gmap);
            this.MinimumSize = new System.Drawing.Size(1016, 658);
            this.Name = "FormOld";
            this.Text = "Blipmap";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NET.WindowsForms.GMapControl gmap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox DropdownYear;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox DropdownCrime;
        private System.Windows.Forms.TrackBar trackBar1;

        private System.Windows.Forms.Button PolygonDrawold;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button PolygonErase;
        private System.Windows.Forms.Button Fijnoort;
        private System.Windows.Forms.TextBox LatBox;
        private System.Windows.Forms.TextBox LongBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private CheckedListBox checkedListBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private CheckBox testbox;
    }
}
