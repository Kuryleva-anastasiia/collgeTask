using System;
using System.Windows.Forms;
using GraphicsRead;
using GraphicsOut;
using BuildGraphic;
using System.Windows.Forms.DataVisualization.Charting;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] array = Read.readFile();

            label1.Text = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                textBox1.Text += array[i] + "\r\n";
            }

            button2.Enabled = true;
            button3.Enabled = true;
        }

		private void button2_Click(object sender, EventArgs e)
		{
            string[] array = Read.readFile();
            string[] arrayX = Build.buildGraphic(array, 1);
            string[] arrayY = Build.buildGraphic(array, 2);
            chart1.Series[0].ChartType = SeriesChartType.Line;

            chart1.Series[0].Points.Clear();
            for (int i = 1; i < arrayX.Length; i++)
            {
                int y = Convert.ToInt32(arrayX[i]) + Convert.ToInt32(arrayX[i]) * Convert.ToInt32(arrayX[i]);
                chart1.Series[0].Points.AddXY(arrayX[i], y);
            }
        }

		private void button3_Click(object sender, EventArgs e)
		{
            Out.WhriteInFile(label1.Text + "\n" + textBox1.Text);
            chart1.Series[0].Points.Clear();
            textBox1.Text = "";
		}

		private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
            if (e.KeyChar == ' ')
            {
                e.KeyChar = '\t';
            }
		}
	}
}
