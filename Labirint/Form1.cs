using System;
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
            Level1 level1 = new Level1();
           DialogResult dr = level1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
                level2();             
        }
        private void level2()
        {

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
