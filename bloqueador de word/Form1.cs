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
using System.Diagnostics;
using System.Media;
namespace bloqueador_de_word
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            int i;
            InitializeComponent();
        }
        public int sec = 0;
        public int mile = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            

            timer1.Start();
            this.WindowState = FormWindowState.Minimized;
            foreach (Process proceso in Process.GetProcesses())
            {
                if (proceso.ProcessName == "WINWORD")
                {
                    proceso.Kill();
                }
            }
        }
        SoundPlayer player;
        private void timer1_Tick(object sender, EventArgs e)
        {
            mile += 1;
            if (mile == 61)
            {
                sec += 1;
                mile = 0;
                foreach (Process proceso in Process.GetProcesses())
                {
                    if (proceso.ProcessName == "WINWORD")
                    {
                        proceso.Kill();
                    }
                   
                }
            }
        }
        
        
    }
}
