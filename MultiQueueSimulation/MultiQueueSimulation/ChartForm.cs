using MultiQueueModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MultiQueueSimulation
{
    public partial class ChartForm : Form
    {
        public HashSet<int> ServersID;
        public static int server = 0;
        public ChartForm()
        {
            InitializeComponent();
           
        }
        private void LoadServer_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= SimTable.SimSys.NumberOfServers; i++)
                 ServersComboBox.Items.Add(i.ToString());
        }

        private void ServersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            server = int.Parse(ServersComboBox.SelectedItem.ToString());
            Server ser = SimTable.SimSys.Servers[server - 1];
            
            var series = new Series("Server " + ServersComboBox.SelectedItem.ToString());
            int[] x = new int[ser.List_X.Count() + 5];
            int[] y = new int[ser.List_y.Count() + 5];
            for (int i = 0; i < ser.List_X.Count(); i++)
            {
                 x[i] = ser.List_X[i];
                 y[i] = ser.List_y[i];
            }
            series.Points.DataBindXY(x, y);
            ServerBusy.Series.Clear();
            ServerBusy.Series.Add(series);
            ServerBusy.Series["Server " + ServersComboBox.SelectedItem.ToString()]["PointWidth"] = "1";
            label1.Text = ser.AverageServiceTime.ToString();
            label2.Text = ser.IdleProbability.ToString();
            label3.Text = ser.Utilization.ToString();
        }

        
    }
}
