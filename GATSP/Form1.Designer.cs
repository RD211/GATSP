namespace GATSP
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.btn_changeData = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.timer_evolve = new System.Windows.Forms.Timer(this.components);
            this.lbl_min = new System.Windows.Forms.Label();
            this.chart_evolution = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.trackBar_top = new System.Windows.Forms.TrackBar();
            this.trackBar_reproduction = new System.Windows.Forms.TrackBar();
            this.lbl_reproduction = new System.Windows.Forms.Label();
            this.lbl_top = new System.Windows.Forms.Label();
            this.lbl_mutation = new System.Windows.Forms.Label();
            this.trackBar_mutation = new System.Windows.Forms.TrackBar();
            this.btn_export = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart_evolution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_top)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_reproduction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_mutation)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_changeData
            // 
            this.btn_changeData.Location = new System.Drawing.Point(12, 12);
            this.btn_changeData.Name = "btn_changeData";
            this.btn_changeData.Size = new System.Drawing.Size(110, 88);
            this.btn_changeData.TabIndex = 0;
            this.btn_changeData.Text = "Change data set";
            this.btn_changeData.UseVisualStyleBackColor = true;
            this.btn_changeData.Click += new System.EventHandler(this.btn_changeData_Click);
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(128, 12);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(110, 88);
            this.btn_start.TabIndex = 1;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // timer_evolve
            // 
            this.timer_evolve.Interval = 10;
            this.timer_evolve.Tick += new System.EventHandler(this.timer_evolve_Tick);
            // 
            // lbl_min
            // 
            this.lbl_min.AutoSize = true;
            this.lbl_min.Location = new System.Drawing.Point(213, 425);
            this.lbl_min.Name = "lbl_min";
            this.lbl_min.Size = new System.Drawing.Size(35, 13);
            this.lbl_min.TabIndex = 2;
            this.lbl_min.Text = "label1";
            this.lbl_min.Click += new System.EventHandler(this.lbl_min_Click);
            // 
            // chart_evolution
            // 
            chartArea2.Name = "ChartArea1";
            this.chart_evolution.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart_evolution.Legends.Add(legend2);
            this.chart_evolution.Location = new System.Drawing.Point(216, 138);
            this.chart_evolution.Name = "chart_evolution";
            this.chart_evolution.Size = new System.Drawing.Size(572, 300);
            this.chart_evolution.TabIndex = 3;
            this.chart_evolution.Text = "CHART";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(245, 13);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(234, 119);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // trackBar_top
            // 
            this.trackBar_top.Location = new System.Drawing.Point(12, 184);
            this.trackBar_top.Maximum = 100;
            this.trackBar_top.Name = "trackBar_top";
            this.trackBar_top.Size = new System.Drawing.Size(198, 45);
            this.trackBar_top.TabIndex = 8;
            this.trackBar_top.Scroll += new System.EventHandler(this.trackBar_top_Scroll);
            // 
            // trackBar_reproduction
            // 
            this.trackBar_reproduction.Location = new System.Drawing.Point(12, 273);
            this.trackBar_reproduction.Maximum = 100;
            this.trackBar_reproduction.Name = "trackBar_reproduction";
            this.trackBar_reproduction.Size = new System.Drawing.Size(198, 45);
            this.trackBar_reproduction.TabIndex = 9;
            this.trackBar_reproduction.Scroll += new System.EventHandler(this.trackBar_reproduction_Scroll);
            // 
            // lbl_reproduction
            // 
            this.lbl_reproduction.AutoSize = true;
            this.lbl_reproduction.Location = new System.Drawing.Point(12, 242);
            this.lbl_reproduction.Name = "lbl_reproduction";
            this.lbl_reproduction.Size = new System.Drawing.Size(71, 13);
            this.lbl_reproduction.TabIndex = 10;
            this.lbl_reproduction.Text = "Reproduction";
            // 
            // lbl_top
            // 
            this.lbl_top.AutoSize = true;
            this.lbl_top.Location = new System.Drawing.Point(12, 156);
            this.lbl_top.Name = "lbl_top";
            this.lbl_top.Size = new System.Drawing.Size(26, 13);
            this.lbl_top.TabIndex = 11;
            this.lbl_top.Text = "Top";
            // 
            // lbl_mutation
            // 
            this.lbl_mutation.AutoSize = true;
            this.lbl_mutation.Location = new System.Drawing.Point(15, 324);
            this.lbl_mutation.Name = "lbl_mutation";
            this.lbl_mutation.Size = new System.Drawing.Size(48, 13);
            this.lbl_mutation.TabIndex = 13;
            this.lbl_mutation.Text = "Mutation";
            // 
            // trackBar_mutation
            // 
            this.trackBar_mutation.Location = new System.Drawing.Point(15, 355);
            this.trackBar_mutation.Maximum = 100;
            this.trackBar_mutation.Name = "trackBar_mutation";
            this.trackBar_mutation.Size = new System.Drawing.Size(198, 45);
            this.trackBar_mutation.TabIndex = 12;
            this.trackBar_mutation.Scroll += new System.EventHandler(this.trackBar_mutation_Scroll);
            // 
            // btn_export
            // 
            this.btn_export.Location = new System.Drawing.Point(485, 12);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(110, 88);
            this.btn_export.TabIndex = 14;
            this.btn_export.Text = "Export";
            this.btn_export.UseVisualStyleBackColor = true;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_export);
            this.Controls.Add(this.lbl_mutation);
            this.Controls.Add(this.trackBar_mutation);
            this.Controls.Add(this.lbl_top);
            this.Controls.Add(this.lbl_reproduction);
            this.Controls.Add(this.trackBar_reproduction);
            this.Controls.Add(this.trackBar_top);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lbl_min);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.btn_changeData);
            this.Controls.Add(this.chart_evolution);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_evolution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_top)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_reproduction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_mutation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_changeData;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Timer timer_evolve;
        private System.Windows.Forms.Label lbl_min;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_evolution;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TrackBar trackBar_top;
        private System.Windows.Forms.TrackBar trackBar_reproduction;
        private System.Windows.Forms.Label lbl_reproduction;
        private System.Windows.Forms.Label lbl_top;
        private System.Windows.Forms.Label lbl_mutation;
        private System.Windows.Forms.TrackBar trackBar_mutation;
        private System.Windows.Forms.Button btn_export;
    }
}

