using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressBarExamQuestion
{
    public partial class Form1 : Form
    {
        private int counter = 0;

        public Form1()
        {
            InitializeComponent();

            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = 100;
            timer.Tick += (o, args) =>
            {
                if(counter == 100) timer.Stop();
                label1.Text = $"{counter}%";
                progressBar1.Value = counter;
                counter++;

            };
            timer.Start();
        }
    }
}
