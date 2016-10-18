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
        private readonly Timer _timer;  //variable to start the timer
        SoundPlayer ring = new SoundPlayer(Properties.Resources.yeet);  //sound

        /// <summary>
        /// Constructor when the Alarm box opens, it plays the sound
        /// </summary>
        /// <param name="timer"></param>
        public AlarmMessageBox(Timer timer)
        {
            InitializeComponent();
            ring.PlayLooping();
            _timer = timer;
        }
 
        /// <summary>
        /// if you click the snooze button, it starts the timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btSnooze_Click(object sender, EventArgs e)
        {
            ring.Stop();
            _timer.Start();
            Dispose();
        }
        /// <summary>
        /// stops the ringer, closes the app
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btOk_Click(object sender, EventArgs e)
        {
            ring.Stop();
            Dispose();
        }
    }
}
