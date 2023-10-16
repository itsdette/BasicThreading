using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicThreading1
{
    public partial class FrmBasicThread : Form
    {

        public FrmBasicThread()
        {
            InitializeComponent();
        }
        private void btnRun_Click(object sender, EventArgs e)
        {
            ThreadStart Thread = new ThreadStart(MyThreadClass.Thread1);

            Thread ThreadA = new Thread(Thread);
            ThreadA.Start();
            ThreadA.Name = "Thread A in Process";

            Thread ThreadB = new Thread(Thread);
            ThreadB.Start();
            ThreadB.Name = "Thead B in Process";

            Console.WriteLine(label1.Text.ToString());

            ThreadA.Join();
            ThreadB.Join();

            label1.Text = "-End of thread-";
            Console.WriteLine(label1.Text.ToString());
        }
    }
}
