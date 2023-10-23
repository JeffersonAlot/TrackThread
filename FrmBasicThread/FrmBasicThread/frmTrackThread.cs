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

namespace FrmBasicThread
{
    public partial class frmTrackThread : Form
    {
        public frmTrackThread()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string start = "- Before starting Thread -";
            label1.Text = start;
            Console.WriteLine(start);

            Thread ThreadA, ThreadB, ThreadC, ThreadD;

            ThreadStart delThreadStart1 = new ThreadStart(MyThreadClass.Thread1Loop);

            ThreadStart delThreadStart2 = new ThreadStart(MyThreadClass.Thread2Loop);

            ThreadA = new Thread(delThreadStart1);
            ThreadA.Name = "Thread A Process";
            ThreadB = new Thread(delThreadStart2);
            ThreadB.Name = "Thread B Process";
            ThreadC = new Thread(delThreadStart1);
            ThreadC.Name = "Thread C Process";
            ThreadD = new Thread(delThreadStart2);
            ThreadD.Name = "Thread D Process";

            ThreadA.Priority = ThreadPriority.Highest;
            ThreadB.Priority = ThreadPriority.Normal;
            ThreadC.Priority = ThreadPriority.AboveNormal;
            ThreadD.Priority = ThreadPriority.BelowNormal;

            ThreadA.Start();
            ThreadB.Start();
            ThreadC.Start();
            ThreadD.Start();

            ThreadA.Join();
            ThreadB.Join();
            ThreadC.Join();
            ThreadD.Join();

            string end = "- End of Thread -";
            label1.Text = end;
            Console.WriteLine(end);
        }
    }
}
