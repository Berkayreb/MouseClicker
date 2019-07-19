using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MouseClick
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(int dwFlags,int dx,int dy,int cButtons,int dwExtraInfo);
        [DllImport("user32")]
        public static extern int SetCursorPos(int x, int y);

        private const int MOUSEEVENTF_LEFTDOWN = 0x0002; /* left button down */
        private const int MOUSEEVENTF_LEFTUP = 0x0004; /* left button up */

        private SynchronizationContext context = null;
        private DateTime start, end;
        private bool first = true;
        private List<Konum> konumlar;
        private Thread runActionThread;
        int no = 0;
        int sayac = 0;

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals('c'))
            {
                end = DateTime.Now;
                
                if (first)
                {
                    start = end;
                    first = false;
                }

                int x = Cursor.Position.X;
                int y = Cursor.Position.Y;
                TimeSpan ts = end - start;
                double sec = 0;
                if (nWait.Value.Equals(0))
                {
                    sec = ts.TotalSeconds;
                    sec = Math.Round(sec, 1);
                }
                else
                {
                    sec = (double)nWait.Value;
                }

                
                start = end;
                string point = x.ToString() + ","+ y.ToString();
                
                ListViewItem lsti = new ListViewItem(new string[] { point, "0", no.ToString() });
                no = no + 1;
                Konum konum = new Konum(x, y, 0);
                lsti.Tag = konum;
                lstBilgi.Items.Add(lsti);
                int index = lstBilgi.Items.Count;
                if (index > 1)
                {
                    lstBilgi.Items[index - 1].SubItems[1].Text = sec.ToString();
                    (lstBilgi.Items[index - 1].Tag as Konum).Aralik = (int)sec;
                }
            }

            if (e.KeyChar.Equals('S'))
            {
                btnStart.PerformClick();
            }
            else if (e.KeyChar.Equals((char)Keys.Escape))//Esc
            {
                btnCancel.PerformClick();
                this.Focus();
            }
        }

        public Form1()
            
        {
            InitializeComponent();
            context = SynchronizationContext.Current;
            konumlar = new List<Konum>();
            timer1.Interval = 1000;
            


        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
            enableButtons(false);
            if (runActionThread == null || !runActionThread.IsAlive)
            {
                konumlar.Clear();

                if (chkRandom.Checked)
                {
                    

                    foreach(ListViewItem lvitem in lstBilgi.Items)
                    {
                        konumlar.Add(lvitem.Tag as Konum);

                    }
                    Random rnd1 = new Random();
                    int sayi1 = rnd1.Next(37);
                    int sayi2 = rnd1.Next(37);

                    if (sayi1 == sayi2) { sayi2=(sayi1 / 2)+2; }

                    konumlar.Remove(konumlar[sayi1]);
                    konumlar.Remove(konumlar[sayi2]);
                    runActionThread = new Thread(RunAction);
                    runActionThread.Start();

                }
                else
                {

                    foreach (ListViewItem lvi in lstBilgi.Items)
                    {
                        konumlar.Add(lvi.Tag as Konum);
                    }

                    runActionThread = new Thread(RunAction);
                    runActionThread.Start();

                }
            }
        }

        private void RunAction()
        {
            foreach(Konum konum in konumlar)
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(WorkClick), konum);
                int tmpInterval = konum.Aralik.Equals(0) ? 0 : konum.Aralik * 1000 - 100;
                Thread.Sleep(tmpInterval);
            }

            ThreadPool.QueueUserWorkItem(new WaitCallback(WorkEnableButtons), null);


        }

        private void WorkEnableButtons(object state)
        {
            this.context.Send(new SendOrPostCallback(delegate (object _state)
            {
                enableButtons(true);
            }), state);
        }

        private void WorkClick(object state)
        {
            this.context.Send(new SendOrPostCallback(delegate (object _state)
            {


                Konum konum = state as Konum;
                SetCursorPos(konum.X, konum.Y);
                Thread.Sleep(100);
                mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
            }), state);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstBilgi.Items.Clear();
            first = true;
            no = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            sayac = 0;
            if(runActionThread != null || !runActionThread.IsAlive)
            {
                runActionThread.Abort();
                enableButtons(true);
                
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (runActionThread != null && runActionThread.IsAlive)
            {
                runActionThread.Abort();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (chkMakro.Checked)
            {
                sayac++;
                if (sayac >= nMakro.Value)
                {
                    btnStart.PerformClick();
                    sayac = 0;

                }
            }
        }

        private void enableButtons(bool enable)
        {
            btnStart.Enabled = enable;
            btnClear.Enabled = enable;
            btnCancel.Enabled = enable;
            lstBilgi.Enabled = enable;
        }
    }
}
