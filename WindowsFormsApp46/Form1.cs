using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApp46
{
    public partial class Form1 : Form
    {

        Thread thread;
       
        public Form1()
        {
            InitializeComponent();

        }

       void Progress(object progressBar)
        {
            ProgressBar progress = (ProgressBar)progressBar;
            for (int i = 0; i<progress.Maximum;i++)
            {
                progress.Invoke(new Action(() => progress.Value = i));
                Thread.Sleep(50);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {  
                thread = new Thread(new ParameterizedThreadStart(Progress));
                thread.Start(progressBar1);
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            thread = new Thread(new ParameterizedThreadStart(Progress));
            thread.Start(progressBar2);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
          
        }
    }
}
