using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PA5
{

    public partial class AlarmMessageBox : Form
    {
        private readonly Timer _timer;
        SoundPlayer ring = new SoundPlayer(Properties.Resources.yeet);
        public AlarmMessageBox(Timer timer)
        {
            InitializeComponent();
            ring.PlayLooping();
            _timer = timer;
        }
 
        private void btSnooze_Click(object sender, EventArgs e)
        {
            ring.Stop();
            _timer.Start();
            Dispose();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            ring.Stop();
            Dispose();
        }
    }
}
