using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labirint
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Sound.play_start();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkbxSound_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbxSound.Checked)
            {
                chkbxSound.Text = "Sound ON";
                Sound.sound_on();
            }
            else {
                chkbxSound.Text = "Sound OFF";
                Sound.sound_off();
                }
            Sound.play_key();
        }
    }
}
