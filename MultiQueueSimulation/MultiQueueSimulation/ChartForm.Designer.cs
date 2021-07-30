namespace MultiQueueSimulation
{
    partial class ChartForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.ServerBusy = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.LoadServer = new System.Windows.Forms.Button();
            this.ServersComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ServerBusy)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ServerBusy
            // 
            chartArea5.Name = "ChartArea1";
            this.ServerBusy.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.ServerBusy.Legends.Add(legend5);
            this.ServerBusy.Location = new System.Drawing.Point(12, 41);
            this.ServerBusy.Name = "ServerBusy";
            this.ServerBusy.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Busy";
            this.ServerBusy.Series.Add(series5);
            this.ServerBusy.Size = new System.Drawing.Size(880, 401);
            this.ServerBusy.TabIndex = 0;
            this.ServerBusy.Text = "Server Busy Time";
            title5.Name = "Server Busy Time";
            this.ServerBusy.Titles.Add(title5);
            // 
            // LoadServer
            // 
            this.LoadServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadServer.Location = new System.Drawing.Point(12, 12);
            this.LoadServer.Name = "LoadServer";
            this.LoadServer.Size = new System.Drawing.Size(125, 23);
            this.LoadServer.TabIndex = 1;
            this.LoadServer.Text = "Load Server";
            this.LoadServer.UseVisualStyleBackColor = true;
            this.LoadServer.Click += new System.EventHandler(this.LoadServer_Click);
            // 
            // ServersComboBox
            // 
            this.ServersComboBox.FormattingEnabled = true;
            this.ServersComboBox.Location = new System.Drawing.Point(167, 12);
            this.ServersComboBox.Name = "ServersComboBox";
            this.ServersComboBox.Size = new System.Drawing.Size(165, 21);
            this.ServersComboBox.TabIndex = 2;
            this.ServersComboBox.SelectedIndexChanged += new System.EventHandler(this.ServersComboBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Utilization";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "IdleProbability";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "AverageServiceTime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "WaitingProbability";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "IdleProbability";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "AverageWaitingTime";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(915, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 333);
            this.panel1.TabIndex = 15;
            // 
            // ChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 459);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ServersComboBox);
            this.Controls.Add(this.LoadServer);
            this.Controls.Add(this.ServerBusy);
            this.Name = "ChartForm";
            this.Text = "Chart Form";
            ((System.ComponentModel.ISupportInitialize)(this.ServerBusy)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ServerBusy;
        private System.Windows.Forms.Button LoadServer;
        private System.Windows.Forms.ComboBox ServersComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}